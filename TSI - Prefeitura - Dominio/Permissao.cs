namespace TSI___Prefeitura___Dominio
{
    public class Permissao
    {
        private int nCodPermissao;
        private string sDescricao;

        public Permissao()
        {

        }

        public Permissao(string descricao)
        {
            this.Descricao = descricao;
        }

        public Permissao(int codPermissao, string descricao)
        {
            this.CodPermissao = codPermissao;
            this.Descricao = descricao;
        }

        public int CodPermissao
        {
            get { return this.nCodPermissao; }
            set { this.nCodPermissao = value; }
        }

        public string Descricao
        {
            get { return this.sDescricao; }
            set { this.sDescricao = value; }
        }

    }
}
