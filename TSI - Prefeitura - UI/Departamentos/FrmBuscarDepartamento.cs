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

namespace TSI___Prefeitura.Departamentos
{
    public partial class FrmBuscarDepartamento : Form
    {
        Debouncer debouncer;
        DepartamentoAplicacao departamentoAplicacao;
        List<Departamento> departamentos;

        public FrmBuscarDepartamento()
        {
            InitializeComponent();
            this.debouncer = new Debouncer();
            this.debouncer.debounceHandler += debounceHandler;
        }

        private void FrmBuscarDepartamento_Load(object sender, EventArgs e)
        {
            this.departamentoAplicacao = new DepartamentoAplicacao();
            try
            {
                this.departamentos = this.departamentoAplicacao.buscarDepartamentos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
                this.Dispose();
            }
        }

        private void FrmBuscarDepartamento_Shown(object sender, EventArgs e)
        {
            this.anexarAoDataGridView(this.departamentos);
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
                        this.anexarAoDataGridView(this.departamentos);
                    }
                    else
                    {
                        this.anexarAoDataGridView(
                            this.departamentos.Where(x => x.NomeDepartamento.ToLowerInvariant().Contains(this.tbBuscar.Text.ToLowerInvariant())).ToList()
                        );
                    }
                })
            );
        }

        private void anexarAoDataGridView(List<Departamento> departamentos)
        {
            dgvDepartamentos.Rows.Clear();

            for (int index = 0; index < departamentos.Count; index++)
            {
                dgvDepartamentos.Rows.Add();
                dgvDepartamentos.Rows[index].Cells[0].Value = departamentos[index].CodDepartamento;
                dgvDepartamentos.Rows[index].Cells[1].Value = departamentos[index].NomeDepartamento;
                dgvDepartamentos.Rows[index].Cells[2].Value = departamentos[index].CodGerente;
            }
        }
    }
}
