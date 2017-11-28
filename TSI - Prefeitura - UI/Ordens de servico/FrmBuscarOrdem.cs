using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TSI___Prefeitura.Helpers;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Ordens_de_servico
{
    public partial class FrmBuscarOrdem : Form
    {
        FrmGerenciarOrdem frmGerenciarOrdem;
        Debouncer debouncer;
        OrdemAplicacao ordemAplicacao;
        List<Ordem> ordens;
        public FrmBuscarOrdem()
        {
            InitializeComponent();
            this.debouncer = new Debouncer();
            debouncer.debounceHandler += this.debounceHandler;
        }

        private void FrmBuscarOrdem_Load(object sender, EventArgs e)
        {
            this.ordemAplicacao = new OrdemAplicacao();
            try
            {
                this.ordens = this.ordemAplicacao.buscarOrdens();
                //this.dgvOrdens.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                this.Dispose();
            }
        }

        private void FrmBuscarOrdem_Shown(object sender, EventArgs e)
        {
            this.anexarAoDataGridView(this.ordens);
            this.dgvOrdens.Columns[0].Visible = false;
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            this.debouncer.TextChanged();
        }

        private void dgvOrdens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex,
                columnIndex = e.ColumnIndex,
                CodOrdem = Convert.ToInt32(this.dgvOrdens.Rows[rowIndex].Cells[0].Value.ToString());
                this.frmGerenciarOrdem = new FrmGerenciarOrdem(CodOrdem);
                this.frmGerenciarOrdem.Show();
            }
        }

        private void debounceHandler(object sender, EventArgs e)
        {
            this.Invoke(
                new MethodInvoker(() =>
                {
                    if (this.tbBuscar.Text == "")
                    {
                        this.anexarAoDataGridView(this.ordens);
                    }
                    else
                    {   
                        this.anexarAoDataGridView(
                            this.ordens.Where(x => x.Descricao.ToLowerInvariant().Contains(this.tbBuscar.Text.ToLowerInvariant())).ToList()
                        );
                    }
                })
            );
        }

        private void anexarAoDataGridView(List<Ordem> ordens)
        {   
            dgvOrdens.Rows.Clear();

            for (int index = 0; index < ordens.Count; index++)
            {
                dgvOrdens.Rows.Add();
                dgvOrdens.Rows[index].Cells[0].Value = ordens[index].CodOrdem;
                dgvOrdens.Rows[index].Cells[1].Value = ordens[index].Descricao;
                dgvOrdens.Rows[index].Cells[2].Value = ordens[index].DataAbertura;
                dgvOrdens.Rows[index].Cells[3].Value = ordens[index].DataFechamento;
                dgvOrdens.Rows[index].Cells[4].Value = ordens[index].Status;
                dgvOrdens.Rows[index].Cells[5].Value = ordens[index].CodFuncionario;
            }
        }        
    }
}
