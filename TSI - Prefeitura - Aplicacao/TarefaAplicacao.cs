using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TSI___Prefeitura___Dominio;
using TSI___Prefeitura___Repositorio;

namespace TSI___Prefeitura___Aplicacao
{
    public class TarefaAplicacao
    {
        private Contexto contexto;

        public void salvarTarefa(Tarefa tarefa)
        {
            if (tarefa.CodTarefa <= 0)
            {
                this.cadastrarTarefa(tarefa);
            }
            else
            {
                this.atualizarTarefa(tarefa);
            }
        }

        public void cadastrarTarefa(Tarefa tarefa)
        {
            string strComando =
                string.Format(
                    @"INSERT INTO tblTarefa(sDescricao, nCodOrdem, nCodDepartamento, nStatus)
                      VALUES ('{0}', '{1}', '{2}', '{3}')",
                    tarefa.Descricao, tarefa.CodOrdem, tarefa.CodDepartamento, tarefa.Status
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public Tarefa buscarTarefa(int nCodTarefa)
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblTarefa
                      WHERE nCodTarefa = '{0}'
                    ", nCodTarefa
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaTarefa(reader);
            }
        }

        public List<Tarefa> buscarTarefasOrdem(int codTarefa)
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblTarefa
                      WHERE nCodOrdem = {0}
                    ", codTarefa
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaListaTarefa(reader);
            }
        }

        public void atualizarTarefa(Tarefa tarefa)
        {
            string strComando =
                string.Format(
                    @"UPDATE tblTarefa
                      SET sDescricao = '{0}', nCodOrdem = '{1}',
                          nCodDepartamento = '{2}', nStatus = '{3}'",
                    tarefa.Descricao, tarefa.CodOrdem,
                    tarefa.CodDepartamento, tarefa.Status
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public void apagarTarefa(int nCodTarefa)
        {
            string strComando =
                string.Format(
                    @"DELETE FROM tblTarefa
                      WHERE nCodTarefa = '{0}'",
                    nCodTarefa
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        private Tarefa readerParaTarefa(SqlDataReader reader)
        {
            var Tarefa = new Tarefa();
            while (reader.Read())
            {
                foreach (var propriedade in reader)
                {
                    if (propriedade.ToString().StartsWith("n"))
                    {
                        Tarefa.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(Tarefa, Convert.ToInt32(reader[propriedade.ToString()]));
                    }
                    else
                    {
                        Tarefa.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(Tarefa, reader[propriedade.ToString()].ToString());
                    }
                }
            }
            return Tarefa;
        }

        private List<Tarefa> readerParaListaTarefa(SqlDataReader reader)
        {
            var tarefas = new List<Tarefa>();
            while (reader.Read())
            {
                var tarefa = new Tarefa();
                for (int index = 0; index < reader.FieldCount; index++)
                {
                    string property = reader.GetName(index).ToString(),
                           sliced = property.Remove(0, 1);

                    if (reader.GetName(index).ToString().StartsWith("n"))
                    {
                        int result;
                        tarefa.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(tarefa, int.TryParse(reader[property].ToString(), out result) ? result : 0);
                    }
                    else
                    {
                        tarefa.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(tarefa, (reader[property].ToString() == null ? "" : reader[property].ToString()));
                    }
                }
                tarefas.Add(tarefa);
            }
            return tarefas;
        }
    }
}
