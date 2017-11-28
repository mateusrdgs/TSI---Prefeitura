﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TSI___Prefeitura___Dominio;
using TSI___Prefeitura___Repositorio;

namespace TSI___Prefeitura___Aplicacao
{
    public class FuncionarioAplicacao
    {
        private Contexto contexto;

        public void salvarFuncionario(Funcionario funcionario)
        {   
            if(funcionario.CodFuncionario <= 0)
            {
                this.cadastrarFuncionario(funcionario);
            }
            else
            {
                this.atualizarFuncionario(funcionario);
            }
        }

        public void cadastrarFuncionario(Funcionario funcionario)
        {
            string strComando =
                string.Format(
                    @"INSERT INTO tblFuncionario
                      VALUES (
                        @sNomeCompleto, @sCPF, @sEmail, @sTelefone,
                        @sRua, @nNumero, @sCEP, @sBairro,
                        @sCidade, @sEstado, @nCodPermissao, @nCodDepartamento
                    )"
                );
            using(contexto = new Contexto())
            {
                Dictionary<string, dynamic> parametros = new Dictionary<string, dynamic>();
                parametros.Add("@sNomeCompleto", funcionario.NomeCompleto);
                parametros.Add("@sCPF", funcionario.CPF);
                parametros.Add("@sEmail", funcionario.Email);
                parametros.Add("@sTelefone", funcionario.Telefone);
                parametros.Add("@sRua", funcionario.Rua);
                parametros.Add("@nNumero", funcionario.Numero);
                parametros.Add("@sCEP", funcionario.CEP);
                parametros.Add("@sBairro", funcionario.Bairro);
                parametros.Add("@sCidade", funcionario.Cidade);
                parametros.Add("@sEstado", funcionario.Estado);
                parametros.Add("@nCodPermissao", funcionario.CodPermissao);
                parametros.Add("@nCodDepartamento", funcionario.CodDepartamento);
                contexto.executarComando(strComando, parametros);
            }
        }

        public Funcionario buscarFuncionario(int nCodFuncionario)
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblFuncionario
                      WHERE nCodFuncionario = '{0}'
                    ", nCodFuncionario
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaFuncionario(reader);
            }
        }

        public List<Funcionario> buscarGerentesDisponiveis()
        {
            string strComando =
                string.Format(
                    @"SELECT func.nCodFuncionario, func.sNomeCompleto
                      FROM tblFuncionario as func
                      LEFT JOIN tblDepartamento as dept
                      ON func.nCodFuncionario = dept.nCodGerente
                      WHERE func.nCodPermissao = 2 AND dept.nCodGerente IS NULL"
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaListaFuncionario(reader);
            }
        }

        public List<Funcionario> buscarFuncionarios()
        {
            string strComando =
                string.Format(
                    @"SELECT *
                      FROM tblFuncionario
                    "
                );
            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.executarComandoRetorno(strComando);
                return this.readerParaListaFuncionario(reader);
            }
        }

        public void atualizarFuncionario(Funcionario funcionario)
        {
            string strComando =
                string.Format(
                    @"UPDATE tblFuncionario
                      SET sNomeCompleto = '{0}', sCPF = '{1}', sEmail = '{2}', sTelefone = '{3}',
                          sEndereco = '{4}', nCodPermissao = '{5}', nCodDepartamento = '{6}'",            
                    funcionario.NomeCompleto, funcionario.CPF, funcionario.Email,
                    funcionario.Telefone, funcionario.CodPermissao, funcionario.CodDepartamento
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        public void apagarFuncionario(int nCodFuncionario)
        {
            string strComando =
                string.Format(
                    @"DELETE FROM tblFuncionario
                      WHERE nCodFuncionario = '{0}'",
                    nCodFuncionario
                );
            using (contexto = new Contexto())
            {
                contexto.executarComando(strComando);
            }
        }

        private Funcionario readerParaFuncionario(SqlDataReader reader)
        {
            var funcionario = new Funcionario();
            while (reader.Read())
            {   
                foreach (var propriedade in reader)
                {
                    if (propriedade.ToString().StartsWith("n"))
                    {
                        funcionario.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(funcionario, Convert.ToInt32(reader[propriedade.ToString()]));
                    }
                    else
                    {
                        funcionario.GetType()
                                   .GetProperty(propriedade.ToString())
                                   .SetValue(funcionario, reader[propriedade.ToString()].ToString());
                    }
                }
            }
            return funcionario;
        }

        private List<Funcionario> readerParaListaFuncionario(SqlDataReader reader)
        {
            var funcionarios = new List<Funcionario>();
            while (reader.Read())
            {
                var funcionario = new Funcionario();
                for (int index = 0; index < reader.FieldCount; index++)
                {
                    string property = reader.GetName(index).ToString(),
                           sliced = property.Remove(0, 1);

                    if (reader.GetName(index).ToString().StartsWith("n"))
                    {
                        int result;
                        funcionario.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(funcionario, int.TryParse(reader[property].ToString(), out result) ? result : 0);
                    }
                    else
                    {
                        funcionario.GetType()
                                   .GetProperty(sliced)
                                   .SetValue(funcionario, (reader[property].ToString() == null ? "" : reader[property].ToString()));
                    }
                }
                funcionarios.Add(funcionario);
            }
            return funcionarios;
        }
    }
}
