namespace TSI___Prefeitura___Dominio
{
    public class Funcionario
    {
        private int nCodFuncionario;
        private string sNomeCompleto;
        private string sCPF;
        private string sEmail;
        private string sTelefone;
        private string sRua;
        private int nNumero;
        private string sCEP;
        private string sBairro;
        private string sCidade;
        private string nEstado;
        private int nCodPermissao;
        private int nCodDepartamento;

        public Funcionario()
        {

        }

        public Funcionario(
            string nomeCompleto, string cpf, string email, string telefone,
            string rua, int numero, string cep, string bairro,
            string cidade, string estado, int codPermissao, int codDepartamento
        )
        {
            this.NomeCompleto = nomeCompleto;
            this.CPF = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.Rua = rua;
            this.Numero = numero;
            this.CEP = cep;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.CodPermissao = codPermissao;
            this.CodDepartamento = codDepartamento;
        }

        public Funcionario(
            int codFuncionario, string nomeCompleto, string cpf, string email,
            string telefone, string rua, int numero, string cep,
            string bairro, string cidade, string estado, int codPermissao,
            int codDepartamento
        )
        {
            this.CodFuncionario = codFuncionario;
            this.NomeCompleto = nomeCompleto;
            this.CPF = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.Rua = rua;
            this.Numero = numero;
            this.CEP = cep;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.CodPermissao = codPermissao;
            this.CodDepartamento = codDepartamento;
        }

        public int CodFuncionario
        {
            get { return this.nCodFuncionario; }
            set { this.nCodFuncionario = value; }
        }

        public string NomeCompleto
        {
            get { return this.sNomeCompleto; }
            set { this.sNomeCompleto = value; }
        }

        public string CPF
        {
            get { return this.sCPF; }
            set { this.sCPF = value; }
        }

        public string Email
        {
            get { return this.sEmail; }
            set { this.sEmail = value; }
        }

        public string Telefone
        {
            get { return this.sTelefone; }
            set { this.sTelefone = value; }
        }

        public string Rua
        {
            get { return this.sRua; }
            set { this.sRua = value; }
        }

        public int Numero
        {
            get { return this.nNumero; }
            set { this.nNumero = value; }
        }

        public string CEP
        {
            get { return this.sCEP; }
            set { this.sCEP = value; }
        }

        public string Bairro
        {
            get { return this.sBairro; }
            set { this.sBairro = value; }
        }

        public string Cidade
        {
            get { return this.sCidade; }
            set { this.sCidade = value; }
        }

        public string Estado
        {
            get { return this.nEstado; }
            set { this.nEstado = value; }
        }

        public int CodPermissao
        {
            get { return this.nCodPermissao; }
            set { this.nCodPermissao = value; }
        }

        public int CodDepartamento
        {
            get { return this.nCodDepartamento; }
            set { this.nCodDepartamento = value; }
        }
    }
}
