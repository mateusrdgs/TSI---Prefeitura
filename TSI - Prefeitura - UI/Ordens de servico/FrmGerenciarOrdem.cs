using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Ordens_de_servico
{
    public partial class FrmGerenciarOrdem : Form
    {
        FrmCadTarefa frmCadTarefa;
        OrdemAplicacao ordemAplicacao;
        Ordem ordem;
        int codOrdem;

        public FrmGerenciarOrdem(int CodOrdem)
        {
            InitializeComponent();
            this.codOrdem = CodOrdem;
        }

        private void FrmGerenciarOrdem_Load(object sender, EventArgs e)
        {
            this.ordemAplicacao = new OrdemAplicacao();
            this.ordem = this.ordemAplicacao.buscarOrdem(this.codOrdem);
            this.dgvTarefas.Columns[0].Visible = false;
            this.dgvTarefas.Columns[2].Visible = false;
        }

        private void FrmGerenciarOrdem_Shown(object sender, EventArgs e)
        {
            this.lblInfoCodigoOrdem.Text = this.ordem.CodOrdem.ToString();
            this.tbDescricao.Text = this.ordem.Descricao;
            this.lblInfoDataAbertura.Text = this.ordem.DataAbertura.ToString();
            this.lblInfoDataFechamento.Text = this.ordem.DataFechamento.ToString();
            this.lblInfoStatus.Text = this.ordem.Status.ToString();
            this.lblInfoResponsavel.Text = this.ordem.CodFuncionario.ToString();
        }

        private void btnNovaTarefa_Click(object sender, EventArgs e)
        {
            if (this.frmCadTarefa == null || this.frmCadTarefa.IsDisposed)
            {
                this.frmCadTarefa = new FrmCadTarefa(this.codOrdem);
            }
            this.frmCadTarefa.BringToFront();
            this.frmCadTarefa.Show();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
