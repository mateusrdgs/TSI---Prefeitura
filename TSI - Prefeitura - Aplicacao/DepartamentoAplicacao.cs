using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TSI___Prefeitura___Dominio;
using TSI___Prefeitura___Repositorio;

namespace TSI___Prefeitura___Aplicacao
{
    public class DepartamentoAplicacao
    {
        private Contexto contexto;

        public void salvarDepartamento(Departamento departamento)
        {
            if (departamento.nCodDepartamento <= 0)
            {
                this.cadastrarDepartamento(departamento);
            }
            else
            {
                this.atualizarDepartamento(departamento);
            }
        }

        public void cadastrarDepartamento(Departamento departamento)
        {
            string strComando =
                string.Format(
                    @"INSERT INTO tblFuncionario(sNomeDepartamento, nCodGerente)
                      VALUES ('{0}', '{1}')",
                    departamento.sNomeDepartamento, departamento.nCodGerente
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public Departamento buscarFuncionario(int nCodDepartamento)
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblDepartamento
                      WHERE nCodDepartamento = '{0}'
                    ", nCodDepartamento
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaDepartamento(reader);
            }
        }

        public List<Departamento> buscarDepartamentos()
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblDepartamento
                    "
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaListaDepartamento(reader);
            }
        }

        public void atualizarDepartamento(Departamento departamento)
        {
            string strComando =
                string.Format(
                    @"UPDATE tblDepartamento
                      SET sNomeDepartamento = '{0}', nCodGerente = '{1}'",
                    departamento.sNomeDepartamento, departamento.nCodGerente
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public void apagarDepartamento(int nCodDepartamento)
        {
            string strComando =
                string.Format(
                    @"DELETE FROM tblDepartamento
                      WHERE nCodDepartamento = '{0}'",
                    nCodDepartamento
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        private Departamento readerParaDepartamento(SqlDataReader reader)
        {
            var departamento = new Departamento();
            while (reader.Read())
            {
                foreach (var propriedade in reader)
                {
                    if (propriedade.ToString().StartsWith("n"))
                    {
                        departamento.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(departamento, Convert.ToInt32(reader[propriedade.ToString()]));
                    }
                    else
                    {
                        departamento.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(departamento, reader[propriedade.ToString()].ToString());
                    }
                }
            }
            return departamento;
        }

        private List<Departamento> readerParaListaDepartamento(SqlDataReader reader)
        {
            var departamentos = new List<Departamento>();
            while (reader.Read())
            {
                var departamento = new Departamento();
                foreach (var propriedade in reader)
                {
                    if (propriedade.ToString().StartsWith("n"))
                    {
                        departamento.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(departamento, Convert.ToInt32(reader[propriedade.ToString()]));
                    }
                    else
                    {
                        departamento.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(departamento, reader[propriedade.ToString()].ToString());
                    }
                }
                departamentos.Add(departamento);
            }
            return departamentos;
        }
    }
}
