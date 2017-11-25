namespace TSI___Prefeitura___Dominio
{
    public class Ordem
    {
        private int nCodOrdem { get; set; }
        private string sDescricao { get; set; }
        private int nCodFuncionario { get; set; }

        public Ordem()
        {

        }

        public Ordem(string descricao, int codFuncionario)
        {
            this.Descricao = descricao;
            this.CodFuncionario = codFuncionario;
        }

        public Ordem(int codOrdem, string descricao, int codFuncionario)
        {
            this.nCodOrdem = codOrdem;
            this.Descricao = descricao;
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

        public int CodFuncionario
        {
            get { return this.nCodFuncionario; }
            set { this.nCodFuncionario = value; }
        }
    }
}
