using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Ordens_de_servico
{
    public partial class FrmGerenciarOrdem : Form
    {
        FrmCadTarefa frmCadTarefa;
        OrdemAplicacao ordemAplicacao;
        TarefaAplicacao tarefaAplicacao;
        Ordem ordem;
        List<Tarefa> tarefas;
        int codOrdem;

        public FrmGerenciarOrdem(int CodOrdem)
        {
            InitializeComponent();
            this.codOrdem = CodOrdem;
        }

        private void FrmGerenciarOrdem_Load(object sender, EventArgs e)
        {
            this.ordemAplicacao = new OrdemAplicacao();
            this.tarefaAplicacao = new TarefaAplicacao();
            try
            {
                this.ordem = this.ordemAplicacao.buscarOrdem(this.codOrdem);
                this.tarefas = this.tarefaAplicacao.buscarTarefasOrdem(this.codOrdem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
            
            this.dgvTarefas.Columns[0].Visible = false;
            this.dgvTarefas.Columns[2].Visible = false;
            this.dgvTarefas.Columns[3].Visible = false;
        }

        private void FrmGerenciarOrdem_Shown(object sender, EventArgs e)
        {
            this.lblInfoCodigoOrdem.Text = this.ordem.CodOrdem.ToString();
            this.tbDescricao.Text = this.ordem.Descricao;
            this.lblInfoDataAbertura.Text = this.ordem.DataAbertura.ToString();
            this.lblInfoDataFechamento.Text = this.ordem.DataFechamento.ToString();
            this.lblInfoStatus.Text = this.ordem.Status.ToString();
            this.lblInfoResponsavel.Text = this.ordem.CodFuncionario.ToString();

            for (int index = 0; index < this.tarefas.Count; index++)
            {
                if (index == 0)
                {   
                    dgvTarefas.Rows[index].Cells[0].Value = tarefas[index].CodTarefa;
                    dgvTarefas.Rows[index].Cells[1].Value = tarefas[index].Descricao;
                    dgvTarefas.Rows[index].Cells[2].Value = tarefas[index].CodOrdem;
                    dgvTarefas.Rows[index].Cells[3].Value = tarefas[index].CodDepartamento;
                    dgvTarefas.Rows[index].Cells[4].Value = tarefas[index].Status;
                }
                else
                {
                    dgvTarefas.Rows.Add();
                    dgvTarefas.Rows[index].Cells[0].Value = tarefas[index].CodTarefa;
                    dgvTarefas.Rows[index].Cells[1].Value = tarefas[index].Descricao;
                    dgvTarefas.Rows[index].Cells[2].Value = tarefas[index].CodOrdem;
                    dgvTarefas.Rows[index].Cells[3].Value = tarefas[index].CodDepartamento;
                    dgvTarefas.Rows[index].Cells[4].Value = tarefas[index].Status;
                }
            }
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
