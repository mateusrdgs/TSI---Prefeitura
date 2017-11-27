using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TSI___Prefeitura.Helpers;
using TSI___Prefeitura.Métodos;
using TSI___Prefeitura___Aplicacao;
using TSI___Prefeitura___Dominio;

namespace TSI___Prefeitura.Funcionarios
{
    public partial class frmCadFuncionario : Form
    {
        Funcionario funcionario;
        FuncionarioAplicacao funcionarioAplicacao;
        DepartamentoAplicacao departamentoAplicacao;
        PermissaoAplicacao permissaoAplicacao;

        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool camposPreenchidos = true;
            foreach (GroupBox groupbox in this.Controls.OfType<GroupBox>().OrderBy(c => c.TabIndex))
            {
                string tag = ControlesIteradores.checharCampoVazio(groupbox);
                if(tag != "Departamento" && tag != string.Empty) 
                {
                    MessageBox.Show("Campo '" + tag + "' vazio!", "Aviso");
                    camposPreenchidos = false;
                    break;
                }
            }
            if(camposPreenchidos)
            {
                string nomeCompleto = tbNome.Text,
                       cpf = mtbCpf.Text,
                       telefone = mtbTelefone.Text,
                       email = tbEmail.Text,
                       rua = tbRua.Text,
                       cep = mtbCep.Text,
                       bairro = tbBairro.Text,
                       cidade = tbCidade.Text,
                       estado = (cbEstado.SelectedItem as ComboBoxItem).Value.ToString();
                int numero = Convert.ToInt32(tbNumero.Text),
                    departamento = 0,
                    permissao = Convert.ToInt32((cbPermissao.SelectedItem as ComboBoxItem).Value.ToString());
                bool departamentoEscolhido = cbDepartamento.SelectedIndex > 0 ? (cbDepartamento.SelectedItem as ComboBoxItem).Value.ToString() != "" : false,
                     departamentoValido = int.TryParse((departamentoEscolhido ? (cbDepartamento.SelectedItem as ComboBoxItem).Value.ToString() : ""), out departamento);
                this.funcionario = new Funcionario(
                    nomeCompleto, cpf, email,
                    telefone, rua, numero,
                    cep, bairro, cidade,
                    estado, permissao, departamento
                );
                this.funcionarioAplicacao = new FuncionarioAplicacao();
                try
                {
                    funcionarioAplicacao.salvarFuncionario(this.funcionario);
                    MessageBox.Show("Funcionário salvo com sucesso!", "Aviso");
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
                }
            }
        }

        private void frmCadFuncionario_Shown(object sender, EventArgs e)
        {
            this.departamentoAplicacao = new DepartamentoAplicacao();
            this.permissaoAplicacao = new PermissaoAplicacao();

            this.cbEstado.Items.Add(
                new ComboBoxItem(
                    "Minas Gerais",
                    1
                )
            );
            this.cbEstado.Items.Add(
                new ComboBoxItem(
                    "São Paulo",
                    2
                )
            );
            this.cbEstado.Items.Add(
                new ComboBoxItem(
                    "Rio de Janeiro",
                    3
                )
            );

            try
            {
                List<Departamento> departamentos = this.departamentoAplicacao.buscarDepartamentos();
                foreach (var departamento in departamentos)
                {
                    cbDepartamento.Items.Add(
                        new ComboBoxItem(
                            departamento.NomeDepartamento,
                            departamento.CodDepartamento
                        )
                    );
                }
                List<Permissao> permissoes = this.permissaoAplicacao.buscarPermissoes();
                foreach (var permissao in permissoes)
                {
                    cbPermissao.Items.Add(
                        new ComboBoxItem(
                            permissao.Descricao,
                            permissao.CodPermissao
                        )
                    );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                this.Dispose();
            }
        }
    }
}
