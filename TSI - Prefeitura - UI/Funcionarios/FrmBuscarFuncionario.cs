using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSI___Prefeitura.Helpers;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Funcionarios
{
    public partial class FrmBuscarFuncionario : Form
    {
        Debouncer debouncer;
        FuncionarioAplicacao funcionarioAplicacao;
        List<Funcionario> funcionarios;

        public FrmBuscarFuncionario()
        {   
            InitializeComponent();
            this.debouncer = new Debouncer();
            this.debouncer.debounceHandler += this.debounceHandler;
        }

        private void FrmBuscarFuncionario_Load(object sender, EventArgs e)
        {
            this.funcionarioAplicacao = new FuncionarioAplicacao();            
            try
            {
                this.funcionarios = this.funcionarioAplicacao.buscarFuncionarios();                
                this.anexarAoDataGridView(this.funcionarios);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                this.Dispose();
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.debouncer.TextChanged();
        }

        private void debounceHandler(object sender, EventArgs e)
        {
            this.Invoke(
                new MethodInvoker(() =>
                {
                    if (this.tbBuscar.Text == "")
                    {
                        this.anexarAoDataGridView(this.funcionarios);
                    }
                    else
                    {
                        this.anexarAoDataGridView(
                            this.funcionarios.Where(x => x.NomeCompleto.ToLowerInvariant().Contains(this.tbBuscar.Text.ToLowerInvariant())).ToList()
                        );
                    }
                })
            );
        }

        private void anexarAoDataGridView(List<Funcionario> funcionarios)
        {
            this.dgvFuncionarios.Rows.Clear();

            for (int index = 0; index < funcionarios.Count; index++)
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios.Rows[index].Cells[0].Value = funcionarios[index].CodFuncionario;
                dgvFuncionarios.Rows[index].Cells[1].Value = funcionarios[index].NomeCompleto;
                dgvFuncionarios.Rows[index].Cells[2].Value = funcionarios[index].CodDepartamento;
                dgvFuncionarios.Rows[index].Cells[3].Value = funcionarios[index].CodPermissao;
            }
        }
    }
}
