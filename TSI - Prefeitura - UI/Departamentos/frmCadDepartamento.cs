using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TSI___Prefeitura.Métodos;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Departamentos
{
    public partial class frmCadDepartamento : Form
    {   
        Departamento departamento;
        DepartamentoAplicacao departamentoAplicacao;
        FuncionarioAplicacao funcionarioAplicacao;

        public frmCadDepartamento()
        {
            InitializeComponent();
        }

        private void frmCadDepartamento_Shown(object sender, EventArgs e)
        {
            this.funcionarioAplicacao = new FuncionarioAplicacao();
            try
            {
                List<Funcionario> funcionarios = this.funcionarioAplicacao.buscarGerentesDisponiveis();
                for (int index = 0; index < funcionarios.Count; index++)
                {
                    if (index == 0)
                    {
                        dgvGerentes.Rows[index].Cells[0].Value = funcionarios[index].CodFuncionario;
                        dgvGerentes.Rows[index].Cells[1].Value = funcionarios[index].NomeCompleto;
                    }
                    else
                    {
                        dgvGerentes.Rows.Add();
                        dgvGerentes.Rows[index - 1].Cells[0].Value = funcionarios[index].CodFuncionario;
                        dgvGerentes.Rows[index - 1].Cells[1].Value = funcionarios[index].NomeCompleto;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                this.Dispose();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.departamentoAplicacao = new DepartamentoAplicacao();
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
            /*if(this.lblCodigoGerenteEscolhido.Text == "")
            {
                MessageBox.Show("Você deve escolher um gerente para o departamento", "Aviso");
                camposPreenchidos = false;
            }*/
            if (camposPreenchidos)
            {
                int codigoGerente;
                string nomeDepartamento = this.tbNomeDepartamento.Text;
                bool codigoGerenteValido = int.TryParse(this.lblCodigoGerenteEscolhido.Text.ToString(), out codigoGerente);
                this.departamento = new Departamento(nomeDepartamento, codigoGerente);
                try
                {
                    this.departamentoAplicacao.salvarDepartamento(this.departamento);
                    MessageBox.Show("Departamento salvo com sucesso!", "Aviso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
                finally
                {
                    foreach (GroupBox groupbox in this.Controls.OfType<GroupBox>().OrderBy(c => c.TabIndex))
                    {
                        ControlesIteradores.limparControles(groupbox);
                    }
                    lblNomeGerenteEscolhido.Text = "Selecione um gerente na tabela ao lado";
                    lblCodigoGerenteEscolhido.Text = "";
                }
            }
        }

        private void dgvGerentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex,
                columnIndex = e.ColumnIndex;
            if(columnIndex == 1 && rowIndex >= 0)
            {
                DataGridViewCell cell = dgvGerentes.Rows[rowIndex].Cells[columnIndex];
                lblNomeGerenteEscolhido.Text = cell.Value.ToString();
                lblCodigoGerenteEscolhido.Text = dgvGerentes.Rows[rowIndex].Cells[columnIndex - 1].Value.ToString();
            }
        }

        private void frmCadDepartamento_Load(object sender, EventArgs e)
        {

        }
    }
}
