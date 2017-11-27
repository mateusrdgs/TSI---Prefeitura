using System;

namespace TSI___Prefeitura___Dominio
{
    public class Ordem
    {
        private int nCodOrdem;
        private string sDescricao;
        private DateTime dDataAbertura;
        private DateTime? dDataFechamento;
        private int nStatus;
        private int nCodFuncionario;

        public Ordem()
        {

        }

        public Ordem(string descricao, DateTime dataAbertura, DateTime? dataFechamento, int status, int codFuncionario)
        {
            this.Descricao = descricao;
            this.DataAbertura = dataAbertura;
            this.DataFechamento = DataFechamento;
            this.Status = status;
            this.CodFuncionario = codFuncionario;
        }

        public Ordem(int codOrdem, string descricao, DateTime dataAbertura, DateTime? dataFechamento, int status, int codFuncionario)
        {
            this.CodOrdem = codOrdem;
            this.Descricao = descricao;
            this.DataAbertura = dataAbertura;
            this.DataFechamento = DataFechamento;
            this.Status = status;
            this.CodFuncionario = codFuncionario;
        }

        public int CodOrdem
        {
            get { return this.nCodOrdem; }
            set { this.nCodOrdem = value; }
        }

        public string Descricao
        {
            get { return this.sDescricao; }
            set { this.sDescricao = value; }
        }

        public DateTime DataAbertura
        {
            get { return this.dDataAbertura; }
            set { this.dDataAbertura = value; }
        }

        public DateTime? DataFechamento
        {
            get { return this.dDataFechamento; }
            set { this.dDataFechamento = value; }
        }

        public int Status
        {
            get { return this.nStatus; }
            set { this.nStatus = value; }
        }

        public int CodFuncionario
        {
            get { return this.nCodFuncionario; }
            set { this.nCodFuncionario = value; }
        }
    }
}
