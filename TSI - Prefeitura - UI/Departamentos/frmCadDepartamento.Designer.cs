namespace TSI___Prefeitura.Departamentos
{
    partial class frmCadDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoGerenteEscolhido = new System.Windows.Forms.Label();
            this.lblNomeGerenteEscolhido = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNomeGerente = new System.Windows.Forms.Label();
            this.tbNomeDepartamento = new System.Windows.Forms.TextBox();
            this.lblNomeDepartamento = new System.Windows.Forms.Label();
            this.lblTabelaGerentes = new System.Windows.Forms.Label();
            this.dgvGerentes = new System.Windows.Forms.DataGridView();
            this.nCodFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerentes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigoGerenteEscolhido);
            this.groupBox1.Controls.Add(this.lblNomeGerenteEscolhido);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblNomeGerente);
            this.groupBox1.Controls.Add(this.tbNomeDepartamento);
            this.groupBox1.Controls.Add(this.lblNomeDepartamento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(451, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do departamento";
            // 
            // lblCodigoGerenteEscolhido
            // 
            this.lblCodigoGerenteEscolhido.AutoSize = true;
            this.lblCodigoGerenteEscolhido.Location = new System.Drawing.Point(10, 153);
            this.lblCodigoGerenteEscolhido.Name = "lblCodigoGerenteEscolhido";
            this.lblCodigoGerenteEscolhido.Size = new System.Drawing.Size(0, 20);
            this.lblCodigoGerenteEscolhido.TabIndex = 5;
            // 
            // lblNomeGerenteEscolhido
            // 
            this.lblNomeGerenteEscolhido.AutoSize = true;
            this.lblNomeGerenteEscolhido.Location = new System.Drawing.Point(6, 129);
            this.lblNomeGerenteEscolhido.Name = "lblNomeGerenteEscolhido";
            this.lblNomeGerenteEscolhido.Size = new System.Drawing.Size(290, 20);
            this.lblNomeGerenteEscolhido.TabIndex = 4;
            this.lblNomeGerenteEscolhido.Text = "Selecione um gerente na tabela ao lado";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(236, 473);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 34);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNomeGerente
            // 
            this.lblNomeGerente.AutoSize = true;
            this.lblNomeGerente.Location = new System.Drawing.Point(6, 100);
            this.lblNomeGerente.Name = "lblNomeGerente";
            this.lblNomeGerente.Size = new System.Drawing.Size(68, 20);
            this.lblNomeGerente.TabIndex = 2;
            this.lblNomeGerente.Text = "Gerente";
            // 
            // tbNomeDepartamento
            // 
            this.tbNomeDepartamento.Location = new System.Drawing.Point(10, 58);
            this.tbNomeDepartamento.Name = "tbNomeDepartamento";
            this.tbNomeDepartamento.Size = new System.Drawing.Size(301, 26);
            this.tbNomeDepartamento.TabIndex = 1;
            this.tbNomeDepartamento.Tag = "Nome do departamento";
            // 
            // lblNomeDepartamento
            // 
            this.lblNomeDepartamento.AutoSize = true;
            this.lblNomeDepartamento.Location = new System.Drawing.Point(6, 35);
            this.lblNomeDepartamento.Name = "lblNomeDepartamento";
            this.lblNomeDepartamento.Size = new System.Drawing.Size(180, 20);
            this.lblNomeDepartamento.TabIndex = 0;
            this.lblNomeDepartamento.Text = "Nome do Departamento";
            // 
            // lblTabelaGerentes
            // 
            this.lblTabelaGerentes.AutoSize = true;
            this.lblTabelaGerentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelaGerentes.Location = new System.Drawing.Point(12, 12);
            this.lblTabelaGerentes.Name = "lblTabelaGerentes";
            this.lblTabelaGerentes.Size = new System.Drawing.Size(157, 20);
            this.lblTabelaGerentes.TabIndex = 4;
            this.lblTabelaGerentes.Text = "Gerentes disponíveis";
            // 
            // dgvGerentes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGerentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGerentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGerentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCodFuncionario,
            this.sNomeCompleto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGerentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGerentes.Location = new System.Drawing.Point(12, 47);
            this.dgvGerentes.Name = "dgvGerentes";
            this.dgvGerentes.Size = new System.Drawing.Size(419, 472);
            this.dgvGerentes.TabIndex = 3;
            this.dgvGerentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGerentes_CellDoubleClick);
            // 
            // nCodFuncionario
            // 
            this.nCodFuncionario.HeaderText = "Código";
            this.nCodFuncionario.Name = "nCodFuncionario";
            this.nCodFuncionario.ReadOnly = true;
            this.nCodFuncionario.Width = 70;
            // 
            // sNomeCompleto
            // 
            this.sNomeCompleto.HeaderText = "Nome completo";
            this.sNomeCompleto.Name = "sNomeCompleto";
            this.sNomeCompleto.ReadOnly = true;
            this.sNomeCompleto.Width = 306;
            // 
            // frmCadDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.lblTabelaGerentes);
            this.Controls.Add(this.dgvGerentes);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadDepartamento";
            this.Text = "Cadastrar departamento";
            this.Shown += new System.EventHandler(this.frmCadDepartamento_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomeDepartamento;
        private System.Windows.Forms.TextBox tbNomeDepartamento;
        private System.Windows.Forms.Label lblNomeGerente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTabelaGerentes;
        private System.Windows.Forms.DataGridView dgvGerentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNomeCompleto;
        private System.Windows.Forms.Label lblNomeGerenteEscolhido;
        private System.Windows.Forms.Label lblCodigoGerenteEscolhido;
    }
}