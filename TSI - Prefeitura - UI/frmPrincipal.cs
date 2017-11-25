using System;
using System.Windows.Forms;
using TSI___Prefeitura.Funcionarios;

namespace TSI___Prefeitura
{
    public partial class frmPrincipal : Form
    {
        frmCadFuncionario frmCadFuncionario;

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
                MessageBox.Show(this.frmCadFuncionario.Size.Width.ToString());
                MessageBox.Show(this.frmCadFuncionario.Size.Height.ToString());
            }
            else
            {
                //this.frmCadFuncionario.WindowState = FormWindowState.Maximized;
                this.frmCadFuncionario.Show();
            }
        }
    }
}
