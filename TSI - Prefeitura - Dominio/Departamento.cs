namespace TSI___Prefeitura___Dominio
{
    public class Departamento
    {
        private int nCodDepartamento;
        private string sNomeDepartamento;
        private int nCodGerente;

        public Departamento()
        {

        }

        public Departamento(string nomeDepartamento)
        {
            this.NomeDepartamento = nomeDepartamento;
        }

        public Departamento(string nomeDepartamento, int codGerente)
        {
            this.NomeDepartamento = nomeDepartamento;
            this.CodGerente = codGerente;
        }

        public Departamento(int codDepartamento, string nomeDepartamento, int codGerente)
        {
            this.CodDepartamento = codDepartamento;
            this.NomeDepartamento = nomeDepartamento;
            this.CodGerente = codGerente;
        }

        public int CodDepartamento
        {
            get { return this.nCodDepartamento; }
            set { this.nCodDepartamento = value; }
        }

        public string NomeDepartamento
        {
            get { return this.sNomeDepartamento; }
            set { this.sNomeDepartamento = value; }
        }

        public int CodGerente
        {
            get { return this.nCodGerente; }
            set { this.nCodGerente = value; }
        }
    }
}
