using System;
using System.Windows.Forms;
using TSI___Prefeitura.Departamentos;
using TSI___Prefeitura.Funcionarios;

namespace TSI___Prefeitura
{
    public partial class frmPrincipal : Form
    {
        frmCadFuncionario frmCadFuncionario;
        frmCadDepartamento frmCadDepartamento;

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
                this.frmCadDepartamento.Show();
            }
        }
    }
}
