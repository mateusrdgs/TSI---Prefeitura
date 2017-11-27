namespace TSI___Prefeitura.Ordens_de_servico
{
    partial class FrmGerenciarOrdem
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
            this.gbDadosOrdem = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblInfoCodigoOrdem = new System.Windows.Forms.Label();
            this.lblCodigoOrdem = new System.Windows.Forms.Label();
            this.lblInfoResponsavel = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblInfoStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInfoDataFechamento = new System.Windows.Forms.Label();
            this.lblDataFechamento = new System.Windows.Forms.Label();
            this.lblInfoDataAbertura = new System.Windows.Forms.Label();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.gbTarefasOrdem = new System.Windows.Forms.GroupBox();
            this.btnNovaTarefa = new System.Windows.Forms.Button();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.nCodTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCodOrdem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCodDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDadosOrdem.SuspendLayout();
            this.gbTarefasOrdem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosOrdem
            // 
            this.gbDadosOrdem.Controls.Add(this.btnSalvar);
            this.gbDadosOrdem.Controls.Add(this.lblInfoCodigoOrdem);
            this.gbDadosOrdem.Controls.Add(this.lblCodigoOrdem);
            this.gbDadosOrdem.Controls.Add(this.lblInfoResponsavel);
            this.gbDadosOrdem.Controls.Add(this.lblResponsavel);
            this.gbDadosOrdem.Controls.Add(this.lblInfoStatus);
            this.gbDadosOrdem.Controls.Add(this.lblStatus);
            this.gbDadosOrdem.Controls.Add(this.lblInfoDataFechamento);
            this.gbDadosOrdem.Controls.Add(this.lblDataFechamento);
            this.gbDadosOrdem.Controls.Add(this.lblInfoDataAbertura);
            this.gbDadosOrdem.Controls.Add(this.lblDataAbertura);
            this.gbDadosOrdem.Controls.Add(this.tbDescricao);
            this.gbDadosOrdem.Controls.Add(this.lblDescrição);
            this.gbDadosOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosOrdem.Location = new System.Drawing.Point(402, 12);
            this.gbDadosOrdem.Name = "gbDadosOrdem";
            this.gbDadosOrdem.Size = new System.Drawing.Size(366, 513);
            this.gbDadosOrdem.TabIndex = 0;
            this.gbDadosOrdem.TabStop = false;
            this.gbDadosOrdem.Text = "Dados da ordem";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(285, 479);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblInfoCodigoOrdem
            // 
            this.lblInfoCodigoOrdem.AutoSize = true;
            this.lblInfoCodigoOrdem.Location = new System.Drawing.Point(6, 305);
            this.lblInfoCodigoOrdem.Name = "lblInfoCodigoOrdem";
            this.lblInfoCodigoOrdem.Size = new System.Drawing.Size(14, 20);
            this.lblInfoCodigoOrdem.TabIndex = 11;
            this.lblInfoCodigoOrdem.Text = "-";
            // 
            // lblCodigoOrdem
            // 
            this.lblCodigoOrdem.AutoSize = true;
            this.lblCodigoOrdem.Location = new System.Drawing.Point(6, 274);
            this.lblCodigoOrdem.Name = "lblCodigoOrdem";
            this.lblCodigoOrdem.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoOrdem.TabIndex = 10;
            this.lblCodigoOrdem.Text = "Código";
            // 
            // lblInfoResponsavel
            // 
            this.lblInfoResponsavel.AutoSize = true;
            this.lblInfoResponsavel.Location = new System.Drawing.Point(6, 456);
            this.lblInfoResponsavel.Name = "lblInfoResponsavel";
            this.lblInfoResponsavel.Size = new System.Drawing.Size(14, 20);
            this.lblInfoResponsavel.TabIndex = 9;
            this.lblInfoResponsavel.Text = "-";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(6, 422);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(199, 20);
            this.lblResponsavel.TabIndex = 8;
            this.lblResponsavel.Text = "Responsável pela abertura";
            // 
            // lblInfoStatus
            // 
            this.lblInfoStatus.AutoSize = true;
            this.lblInfoStatus.Location = new System.Drawing.Point(205, 305);
            this.lblInfoStatus.Name = "lblInfoStatus";
            this.lblInfoStatus.Size = new System.Drawing.Size(14, 20);
            this.lblInfoStatus.TabIndex = 7;
            this.lblInfoStatus.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(205, 274);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblInfoDataFechamento
            // 
            this.lblInfoDataFechamento.AutoSize = true;
            this.lblInfoDataFechamento.Location = new System.Drawing.Point(205, 373);
            this.lblInfoDataFechamento.Name = "lblInfoDataFechamento";
            this.lblInfoDataFechamento.Size = new System.Drawing.Size(14, 20);
            this.lblInfoDataFechamento.TabIndex = 5;
            this.lblInfoDataFechamento.Text = "-";
            // 
            // lblDataFechamento
            // 
            this.lblDataFechamento.AutoSize = true;
            this.lblDataFechamento.Location = new System.Drawing.Point(205, 342);
            this.lblDataFechamento.Name = "lblDataFechamento";
            this.lblDataFechamento.Size = new System.Drawing.Size(155, 20);
            this.lblDataFechamento.TabIndex = 4;
            this.lblDataFechamento.Text = "Data de fechamento";
            // 
            // lblInfoDataAbertura
            // 
            this.lblInfoDataAbertura.AutoSize = true;
            this.lblInfoDataAbertura.Location = new System.Drawing.Point(6, 373);
            this.lblInfoDataAbertura.Name = "lblInfoDataAbertura";
            this.lblInfoDataAbertura.Size = new System.Drawing.Size(14, 20);
            this.lblInfoDataAbertura.TabIndex = 3;
            this.lblInfoDataAbertura.Text = "-";
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Location = new System.Drawing.Point(6, 342);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(130, 20);
            this.lblDataAbertura.TabIndex = 2;
            this.lblDataAbertura.Text = "Data de abertura";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(10, 56);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(350, 199);
            this.tbDescricao.TabIndex = 1;
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Location = new System.Drawing.Point(6, 33);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(80, 20);
            this.lblDescrição.TabIndex = 0;
            this.lblDescrição.Text = "Descrição";
            // 
            // gbTarefasOrdem
            // 
            this.gbTarefasOrdem.Controls.Add(this.btnNovaTarefa);
            this.gbTarefasOrdem.Controls.Add(this.dgvTarefas);
            this.gbTarefasOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTarefasOrdem.Location = new System.Drawing.Point(12, 12);
            this.gbTarefasOrdem.Name = "gbTarefasOrdem";
            this.gbTarefasOrdem.Size = new System.Drawing.Size(384, 513);
            this.gbTarefasOrdem.TabIndex = 1;
            this.gbTarefasOrdem.TabStop = false;
            this.gbTarefasOrdem.Text = "Tarefas";
            // 
            // btnNovaTarefa
            // 
            this.btnNovaTarefa.Location = new System.Drawing.Point(278, 479);
            this.btnNovaTarefa.Name = "btnNovaTarefa";
            this.btnNovaTarefa.Size = new System.Drawing.Size(100, 28);
            this.btnNovaTarefa.TabIndex = 1;
            this.btnNovaTarefa.Text = "Nova tarefa";
            this.btnNovaTarefa.UseVisualStyleBackColor = true;
            this.btnNovaTarefa.Click += new System.EventHandler(this.btnNovaTarefa_Click);
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCodTarefa,
            this.sDescricao,
            this.nCodOrdem,
            this.nCodDepartamento,
            this.nStatus});
            this.dgvTarefas.Location = new System.Drawing.Point(6, 33);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.Size = new System.Drawing.Size(372, 409);
            this.dgvTarefas.TabIndex = 0;
            // 
            // nCodTarefa
            // 
            this.nCodTarefa.HeaderText = "Código";
            this.nCodTarefa.Name = "nCodTarefa";
            this.nCodTarefa.ReadOnly = true;
            // 
            // sDescricao
            // 
            this.sDescricao.HeaderText = "Descrição";
            this.sDescricao.Name = "sDescricao";
            this.sDescricao.ReadOnly = true;
            this.sDescricao.Width = 129;
            // 
            // nCodOrdem
            // 
            this.nCodOrdem.HeaderText = "Ordem";
            this.nCodOrdem.Name = "nCodOrdem";
            this.nCodOrdem.ReadOnly = true;
            // 
            // nCodDepartamento
            // 
            this.nCodDepartamento.HeaderText = "Dept";
            this.nCodDepartamento.Name = "nCodDepartamento";
            this.nCodDepartamento.ReadOnly = true;
            // 
            // nStatus
            // 
            this.nStatus.HeaderText = "Status";
            this.nStatus.Name = "nStatus";
            this.nStatus.ReadOnly = true;
            // 
            // FrmGerenciarOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.gbTarefasOrdem);
            this.Controls.Add(this.gbDadosOrdem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGerenciarOrdem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerenciarOrdem";
            this.Load += new System.EventHandler(this.FrmGerenciarOrdem_Load);
            this.Shown += new System.EventHandler(this.FrmGerenciarOrdem_Shown);
            this.gbDadosOrdem.ResumeLayout(false);
            this.gbDadosOrdem.PerformLayout();
            this.gbTarefasOrdem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosOrdem;
        private System.Windows.Forms.GroupBox gbTarefasOrdem;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lblInfoDataFechamento;
        private System.Windows.Forms.Label lblDataFechamento;
        private System.Windows.Forms.Label lblInfoDataAbertura;
        private System.Windows.Forms.Label lblDataAbertura;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInfoStatus;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblInfoResponsavel;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblInfoCodigoOrdem;
        private System.Windows.Forms.Label lblCodigoOrdem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodTarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodOrdem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nStatus;
        private System.Windows.Forms.Button btnNovaTarefa;
    }
}