namespace TSI___Prefeitura.Ordens_de_servico
{
    partial class FrmBuscarOrdem
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
            this.gbBuscarOrdem = new System.Windows.Forms.GroupBox();
            this.dgvOrdens = new System.Windows.Forms.DataGridView();
            this.nCodOrdem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCodFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.gbBuscarOrdem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarOrdem
            // 
            this.gbBuscarOrdem.Controls.Add(this.dgvOrdens);
            this.gbBuscarOrdem.Controls.Add(this.tbBuscar);
            this.gbBuscarOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarOrdem.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarOrdem.Name = "gbBuscarOrdem";
            this.gbBuscarOrdem.Size = new System.Drawing.Size(756, 513);
            this.gbBuscarOrdem.TabIndex = 0;
            this.gbBuscarOrdem.TabStop = false;
            this.gbBuscarOrdem.Text = "Buscar ordem";
            // 
            // dgvOrdens
            // 
            this.dgvOrdens.AllowUserToAddRows = false;
            this.dgvOrdens.AllowUserToDeleteRows = false;
            this.dgvOrdens.AllowUserToResizeColumns = false;
            this.dgvOrdens.AllowUserToResizeRows = false;
            this.dgvOrdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCodOrdem,
            this.sDescricao,
            this.dDataAbertura,
            this.dDataFechamento,
            this.sStatus,
            this.nCodFuncionario});
            this.dgvOrdens.Location = new System.Drawing.Point(6, 57);
            this.dgvOrdens.Name = "dgvOrdens";
            this.dgvOrdens.Size = new System.Drawing.Size(744, 450);
            this.dgvOrdens.TabIndex = 1;
            this.dgvOrdens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdens_CellDoubleClick);
            // 
            // nCodOrdem
            // 
            this.nCodOrdem.HeaderText = "Código";
            this.nCodOrdem.Name = "nCodOrdem";
            this.nCodOrdem.ReadOnly = true;
            this.nCodOrdem.Width = 75;
            // 
            // sDescricao
            // 
            this.sDescricao.HeaderText = "Descrição";
            this.sDescricao.Name = "sDescricao";
            this.sDescricao.ReadOnly = true;
            this.sDescricao.Width = 300;
            // 
            // dDataAbertura
            // 
            this.dDataAbertura.HeaderText = "Data de abertura";
            this.dDataAbertura.Name = "dDataAbertura";
            this.dDataAbertura.ReadOnly = true;
            // 
            // dDataFechamento
            // 
            this.dDataFechamento.HeaderText = "Data de fechamento";
            this.dDataFechamento.Name = "dDataFechamento";
            this.dDataFechamento.ReadOnly = true;
            // 
            // sStatus
            // 
            this.sStatus.HeaderText = "Status";
            this.sStatus.Name = "sStatus";
            this.sStatus.ReadOnly = true;
            // 
            // nCodFuncionario
            // 
            this.nCodFuncionario.HeaderText = "Funcionário";
            this.nCodFuncionario.Name = "nCodFuncionario";
            this.nCodFuncionario.ReadOnly = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(6, 25);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(744, 26);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // FrmBuscarOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.gbBuscarOrdem);
            this.Name = "FrmBuscarOrdem";
            this.Text = "FrmBuscarOrdem";
            this.Load += new System.EventHandler(this.FrmBuscarOrdem_Load);
            this.Shown += new System.EventHandler(this.FrmBuscarOrdem_Shown);
            this.gbBuscarOrdem.ResumeLayout(false);
            this.gbBuscarOrdem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarOrdem;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dgvOrdens;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodOrdem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodFuncionario;
    }
}