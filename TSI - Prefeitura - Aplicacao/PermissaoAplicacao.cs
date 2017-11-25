using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI___Prefeitura___Dominio;
using TSI___Prefeitura___Repositorio;

namespace TSI___Prefeitura___Aplicacao
{
    public class PermissaoAplicacao
    {
        private Contexto contexto;

        public void salvarPermissao(Permissao permissao)
        {
            if (permissao.CodPermissao <= 0)
            {
                this.cadastrarPermissao(permissao);
            }
            else
            {
                this.atualizarPermissao(permissao);
            }
        }

        public void cadastrarPermissao(Permissao permissao)
        {
            string strComando =
                string.Format(
                    @"INSERT INTO tblPermissao
                      VALUES ('{0}')",
                    permissao.Descricao
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public Permissao buscarPermissao(int nCodPermissao)
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblPermissao
                      WHERE nCodPermissao = '{0}'
                    ", nCodPermissao
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaPermissao(reader);
            }
        }

        public List<Permissao> buscarPermissoes()
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblPermissao
                    "
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaListaPermissao(reader);
            }
        }

        public void atualizarPermissao(Permissao permissao)
        {
            string strComando =
                string.Format(
                    @"UPDATE tblPermissao
                      SET sDescricao = '{0}'",
                    permissao.Descricao
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public void apagarPermissao(int nCodPermissao)
        {
            string strComando =
                string.Format(
                    @"DELETE FROM tblPermissao
                      WHERE nCodPermissao = '{0}'",
                    nCodPermissao
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        private Permissao readerParaPermissao(SqlDataReader reader)
        {
            var permissao = new Permissao();
            while (reader.Read())
            {
                foreach (var propriedade in reader)
                {
                    if (propriedade.ToString().StartsWith("n"))
                    {
                        permissao.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(permissao, Convert.ToInt32(reader[propriedade.ToString()]));
                    }
                    else
                    {
                        permissao.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(permissao, reader[propriedade.ToString()].ToString());
                    }
                }
            }
            return permissao;
        }

        private List<Permissao> readerParaListaPermissao(SqlDataReader reader)
        {
            var permissaos = new List<Permissao>();
            while (reader.Read())
            {
                var permissao = new Permissao();

                for (int index = 0; index < reader.FieldCount; index++)
                {
                    string property = reader.GetName(index).ToString(),
                           sliced = property.Remove(0, 1);

                    if (reader.GetName(index).ToString().StartsWith("n"))
                    {
                        int result;
                        permissao.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(permissao, int.TryParse(reader[property].ToString(), out result) ? result : 0);
                    }
                    else
                    {
                        permissao.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(permissao, (reader[property].ToString() == null ? "" : reader[property].ToString()));
                    }
                }
                permissaos.Add(permissao);
            }
            return permissaos;
        }
    }
}
