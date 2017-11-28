using System;
using System.Windows.Forms;
using TSI___Prefeitura.Departamentos;
using TSI___Prefeitura.Funcionarios;
using TSI___Prefeitura.Ordens_de_servico;

namespace TSI___Prefeitura
{
    public partial class frmPrincipal : Form
    {
        frmCadFuncionario frmCadFuncionario;
        FrmBuscarFuncionario frmBuscarFuncionario;
        frmCadDepartamento frmCadDepartamento;
        FrmBuscarDepartamento frmBuscarDepartamento;
        FrmCadOrdemServico frmCadOrdemServico;
        FrmBuscarOrdem frmBuscarOrdem;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.frmCadFuncionario == null || this.frmCadFuncionario.IsDisposed)
            {
                this.frmCadFuncionario = new frmCadFuncionario();
                this.frmCadFuncionario.MdiParent = this;
                this.frmCadFuncionario.MaximizeBox = false;
                this.frmCadFuncionario.MinimizeBox = false;
                this.frmCadFuncionario.WindowState = FormWindowState.Maximized;
                this.frmCadFuncionario.Show();
            }
            else
            {
                this.frmCadFuncionario.WindowState = FormWindowState.Maximized;
                this.frmCadFuncionario.Show();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmCadDepartamento == null || this.frmCadDepartamento.IsDisposed)
            {
                this.frmCadDepartamento = new frmCadDepartamento();
                this.frmCadDepartamento.MdiParent = this;
                this.frmCadDepartamento.MaximizeBox = false;
                this.frmCadDepartamento.MinimizeBox = false;
                this.frmCadDepartamento.WindowState = FormWindowState.Maximized;
                this.frmCadDepartamento.Show();
            }
            else
            {
                this.frmCadDepartamento.WindowState = FormWindowState.Maximized;
                this.frmCadDepartamento.Show();
            }
        }

        private void cadastrarOrdemServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmCadOrdemServico == null || this.frmCadOrdemServico.IsDisposed)
            {
                this.frmCadOrdemServico = new FrmCadOrdemServico();
                this.frmCadOrdemServico.MdiParent = this;
                this.frmCadOrdemServico.MaximizeBox = false;
                this.frmCadOrdemServico.MinimizeBox = false;
                this.frmCadOrdemServico.WindowState = FormWindowState.Maximized;
                this.frmCadOrdemServico.Show();
            }
            else
            {
                this.frmCadOrdemServico.WindowState = FormWindowState.Maximized;
                this.frmCadOrdemServico.Show();
            }
        }

        private void buscarOrdemServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmBuscarOrdem == null || this.frmBuscarOrdem.IsDisposed)
            {
                this.frmBuscarOrdem = new FrmBuscarOrdem();
                this.frmBuscarOrdem.MdiParent = this;
                this.frmBuscarOrdem.MaximizeBox = false;
                this.frmBuscarOrdem.MinimizeBox = false;
                this.frmBuscarOrdem.WindowState = FormWindowState.Maximized;
                this.frmBuscarOrdem.Show();
            }
            else
            {
                this.frmBuscarOrdem.WindowState = FormWindowState.Maximized;
                this.frmBuscarOrdem.Show();
            }
        }

        private void buscarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmBuscarFuncionario == null || this.frmBuscarFuncionario.IsDisposed)
            {
                this.frmBuscarFuncionario = new FrmBuscarFuncionario();
                this.frmBuscarFuncionario.MdiParent = this;
                this.frmBuscarFuncionario.MaximizeBox = false;
                this.frmBuscarFuncionario.MinimizeBox = false;
                this.frmBuscarFuncionario.WindowState = FormWindowState.Maximized;
                this.frmBuscarFuncionario.Show();
            }
            else
            {
                this.frmBuscarFuncionario.WindowState = FormWindowState.Maximized;
                this.frmBuscarFuncionario.Show();
            }
        }

        private void buscarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmBuscarDepartamento == null || this.frmBuscarDepartamento.IsDisposed)
            {
                this.frmBuscarDepartamento = new FrmBuscarDepartamento();
                this.frmBuscarDepartamento.MdiParent = this;
                this.frmBuscarDepartamento.MaximizeBox = false;
                this.frmBuscarDepartamento.MinimizeBox = false;
                this.frmBuscarDepartamento.WindowState = FormWindowState.Maximized;
                this.frmBuscarDepartamento.Show();
            }
            else
            {
                this.frmBuscarDepartamento.WindowState = FormWindowState.Maximized;
                this.frmBuscarDepartamento.Show();
            }
        }
    }
}
