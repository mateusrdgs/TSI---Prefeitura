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
using TSI___Prefeitura.Métodos;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Ordens_de_servico
{
    public partial class FrmCadTarefa : Form
    {
        DepartamentoAplicacao departamentoAplicacao;
        TarefaAplicacao tarefaAplicacao;
        List<Departamento> departamentos;
        Tarefa tarefa;
        int codOrdem;

        public FrmCadTarefa(int CodOrdem)
        {
            this.codOrdem = CodOrdem;
            InitializeComponent();
        }

        private void FrmCadTarefa_Load(object sender, EventArgs e)
        {   
            this.departamentoAplicacao = new DepartamentoAplicacao();
            this.tarefaAplicacao = new TarefaAplicacao();
            this.departamentos = this.departamentoAplicacao.buscarDepartamentos();
        }

        private void FrmCadTarefa_Shown(object sender, EventArgs e)
        {
            foreach (Departamento departamento in this.departamentos)
            {
                this.cbDepartamento.Items.Add(
                    new ComboBoxItem(
                        departamento.NomeDepartamento,
                        departamento.CodDepartamento
                    )
                );
            }
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
                string descricao = this.tbDescricao.Text.ToString();
                int codDepartamento = Convert.ToInt32(this.cbDepartamento.SelectedValue.ToString());
                this.tarefa = new Tarefa(descricao, this.codOrdem, codDepartamento, 1);
                this.tarefaAplicacao.salvarTarefa(this.tarefa);
            }
        }
    }
}
