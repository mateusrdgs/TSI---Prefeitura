using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TSI___Prefeitura___Dominio;
using TSI___Prefeitura___Repositorio;

namespace TSI___Prefeitura___Aplicacao
{
    public class OrdemAplicacao
    {
        private Contexto contexto;

        public void salvarDepartamento(Ordem ordem)
        {
            if (ordem.CodOrdem <= 0)
            {
                this.cadastrarOrdem(ordem);
            }
            else
            {
                this.atualizarOrdem(ordem);
            }
        }

        public void cadastrarOrdem(Ordem ordem)
        {
            string strComando =
                string.Format(
                    @"INSERT INTO tblFuncionario(sNomeDepartamento, nCodGerente)
                      VALUES ('{0}', '{1}')",
                    ordem.Descricao, ordem.CodFuncionario
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public Ordem buscarOrdem(int nCodOrdem)
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblOrdem
                      WHERE nCodOrdem = '{0}'
                    ", nCodOrdem
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaOrdem(reader);
            }
        }

        public List<Ordem> buscarOrdens()
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblOrdem
                    "
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaListaOrdem(reader);
            }
        }

        public void atualizarOrdem(Ordem ordem)
        {
            string strComando =
                string.Format(
                    @"UPDATE tblOrdem
                      SET sDescricao = '{0}', nCodFuncionario = '{1}'",
                    ordem.Descricao, ordem.CodFuncionario
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public void apagarOrdem(int nCodOrdem)
        {
            string strComando =
                string.Format(
                    @"DELETE FROM tblOrdem
                      WHERE nCodOrdem = '{0}'",
                    nCodOrdem
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        private Ordem readerParaOrdem(SqlDataReader reader)
        {
            var ordem = new Ordem();
            while (reader.Read())
            {
                foreach (var propriedade in reader)
                {
                    if (propriedade.ToString().StartsWith("n"))
                    {
                        ordem.GetType()
                             .GetProperty(propriedade.ToString())
                             .SetValue(ordem, Convert.ToInt32(reader[propriedade.ToString()]));
                    }
                    else
                    {
                        ordem.GetType()
                             .GetProperty(propriedade.ToString())
                             .SetValue(ordem, reader[propriedade.ToString()].ToString());
                    }
                }
            }
            return ordem;
        }

        private List<Ordem> readerParaListaOrdem(SqlDataReader reader)
        {
            var ordens = new List<Ordem>();
            while (reader.Read())
            {
                var ordem = new Ordem();
                foreach (var propriedade in reader)
                {
                    if (propriedade.ToString().StartsWith("n"))
                    {
                        ordem.GetType()
                             .GetProperty(propriedade.ToString())
                             .SetValue(ordem, Convert.ToInt32(reader[propriedade.ToString()]));
                    }
                    else
                    {
                        ordem.GetType()
                             .GetProperty(propriedade.ToString())
                             .SetValue(ordem, reader[propriedade.ToString()].ToString());
                    }
                }
                ordens.Add(ordem);
            }
            return ordens;
        }
    }
}
