using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TSI___Prefeitura___Repositorio
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection conexao;

        public Contexto()
        {
            this.conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["TSI - Prefeitura"].ConnectionString);
            this.abrirConexao();
        }

        public void executarComando(string comando)
        {
            if (this.checarConexao())
            {
                this.abrirConexao();
            }
            var comandoSql = new SqlCommand
            {
                CommandText = comando,
                CommandType = CommandType.Text,
                Connection = this.conexao
            };

            comandoSql.ExecuteNonQuery();
        }
        public void executarComando(string strCommand, Dictionary<string, dynamic> parametros)
        {
            if (this.checarConexao())
            {
                this.abrirConexao();
            }
            var command = new SqlCommand
            {
                Connection = this.conexao,
                CommandText = strCommand
            };
            foreach (KeyValuePair<string, dynamic> parametro in parametros)
            {
                command.Parameters.AddWithValue(parametro.Key, (parametro.Value == null ? DBNull.Value : parametro.Value));
            };
            command.ExecuteNonQuery();
        }


        public SqlDataReader executarComandoRetorno(string comando)
        {
            if(this.checarConexao())
            {
                this.abrirConexao();
            }
            var command = new SqlCommand(comando, this.conexao);
            return command.ExecuteReader();
        }

        public dynamic executarScalar(string strCommand)
        {
            if (this.checarConexao())
            {
                this.abrirConexao();
            }
            var command = new SqlCommand
            {
                Connection = this.conexao,
                CommandText = strCommand,
                CommandType = CommandType.StoredProcedure
            };
            return command.ExecuteScalar();
        }

        public dynamic executarScalar(string strCommand, List<string> parametros, List<string> valores)
        {
            if (this.checarConexao())
            {
                this.abrirConexao();
            }
            var command = new SqlCommand
            {
                Connection = this.conexao,
                CommandText = strCommand,
                CommandType = CommandType.StoredProcedure
            };
            foreach(var parametro in parametros)
            {
                command.Parameters.AddWithValue(parametro, valores[parametros.IndexOf(parametro)]);
            };
            return command.ExecuteScalar();
        }

        private bool checarConexao()
        {
            return this.conexao.State == ConnectionState.Closed;
        }

        private void abrirConexao()
        {
            this.conexao.Open();
        }

        public void Dispose()
        {
            if(!this.checarConexao())
            {
                this.conexao.Close();
            }
        }
    }
}
