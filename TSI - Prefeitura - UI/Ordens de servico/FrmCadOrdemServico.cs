using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSI___Prefeitura.Métodos;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Ordens_de_servico
{
    public partial class FrmCadOrdemServico : Form
    {
        Ordem ordem;
        OrdemAplicacao ordemAplicacao;

        public FrmCadOrdemServico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool camposPreenchidos = true;
            foreach (GroupBox groupbox in this.Controls.OfType<GroupBox>().OrderBy(c => c.TabIndex))
            {
                string tag = ControlesIteradores.checharCampoVazio(groupbox);
                if (tag != string.Empty)
                {
                    MessageBox.Show("Campo '" + tag + "' vazio!", "Aviso");
                    camposPreenchidos = false;
                    break;
                }
            }
            if(camposPreenchidos)
            {
                string descricao = tbDescricao.Text;
                this.ordem = new Ordem(
                    descricao, DateTime.Now,
                    (DateTime?)null,
                    1, 5
                );
                this.ordemAplicacao = new OrdemAplicacao();
                try
                {
                    this.ordemAplicacao.salvarOrdem(this.ordem);
                    MessageBox.Show("Ordem de serviço salva com sucesso!", "Aviso");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
                finally
                {
                    foreach (GroupBox groupbox in this.Controls.OfType<GroupBox>().OrderBy(c => c.TabIndex))
                    {
                        ControlesIteradores.limparControles(groupbox);
                    }
                }
            }
        }
    }
}
