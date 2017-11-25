namespace TSI___Prefeitura___Dominio
{
    public class Tarefa
    {
        private int nCodTarefa;
        private string sDescricao;
        private int nCodOrdem;
        private int nCodDepartamento;
        private int nStatus;

        public Tarefa()
        {
            
        }

        public Tarefa(string descricao, int codOrdem, int codDepartamento, int status)
        {
            this.Descricao = descricao;
            this.CodOrdem = codOrdem;
            this.CodDepartamento = codDepartamento;
            this.Status = status;
        }

        public Tarefa(int codTarefa, string descricao, int codOrdem, int codDepartamento, int status)
        {
            this.CodTarefa = codTarefa;
            this.Descricao = descricao;
            this.CodOrdem = codOrdem;
            this.CodDepartamento = codDepartamento;
            this.Status = status;
        }

        public int CodTarefa
        {
            get { return this.nCodTarefa; }
            set { this.nCodTarefa = value; }
        }

        public string Descricao
        {
            get { return this.sDescricao; }
            set { this.sDescricao = value; }
        }

        public int CodOrdem
        {
            get { return this.nCodOrdem; }
            set { this.nCodOrdem = value; }
        }

        public int CodDepartamento
        {
            get { return this.nCodDepartamento; }
            set { this.nCodDepartamento = value; }
        }

        public int Status
        {
            get { return this.nStatus; }
            set { this.nStatus = value; }
        }
    }
}
