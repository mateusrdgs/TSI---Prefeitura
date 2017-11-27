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

        public void salvarOrdem(Ordem ordem)
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
                    @"INSERT INTO tblOrdem
                      VALUES ('{0}', '{1}', '{2}', {3}, '{4}')",
                      ordem.Descricao, ordem.DataAbertura,
                      ordem.DataFechamento, ordem.Status, ordem.CodFuncionario
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
                      SET sDescricao = '{0}', dDataAbertura = '{1}',
                          dDataFechamento = '{2}', nStatus = '{3}',
                          nStatus = '{4}', nCodFuncionario = '{5}'
                      WHERE nCodOrdem = '{6}'",
                      ordem.Descricao, ordem.DataAbertura,
                      ordem.DataFechamento, ordem.Status,
                      ordem.CodFuncionario, ordem.CodOrdem
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
                for (int index = 0; index < reader.FieldCount; index++)
                {
                    string property = reader.GetName(index).ToString(),
                           sliced = property.Remove(0, 1);

                    if (reader.GetName(index).ToString().StartsWith("n"))
                    {
                        int result;
                        ordem.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(ordem, int.TryParse(reader[property].ToString(), out result) ? result : 0);
                    }
                    else if (reader.GetName(index).ToString().StartsWith("d"))
                    {
                        DateTime result;
                        ordem.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(ordem, DateTime.TryParse(reader[property].ToString(), out result) ? result : DateTime.Now);
                    }
                    else
                    {
                        ordem.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(ordem, (reader[property].ToString() == null ? "" : reader[property].ToString()));
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
                for (int index = 0; index < reader.FieldCount; index++)
                {
                    string property = reader.GetName(index).ToString(),
                           sliced = property.Remove(0, 1);

                    if (reader.GetName(index).ToString().StartsWith("n"))
                    {
                        int result;
                        ordem.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(ordem, int.TryParse(reader[property].ToString(), out result) ? result : 0);
                    }
                    else if (reader.GetName(index).ToString().StartsWith("d"))
                    {
                        DateTime result;
                        ordem.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(ordem, DateTime.TryParse(reader[property].ToString(), out result) ? result : DateTime.Now);
                    }
                    else
                    {
                        ordem.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(ordem, (reader[property].ToString() == null ? "" : reader[property].ToString()));
                    }
                }

                ordens.Add(ordem);
            }
            return ordens;
        }
    }
}
