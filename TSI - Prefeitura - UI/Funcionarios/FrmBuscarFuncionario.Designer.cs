namespace TSI___Prefeitura.Funcionarios
{
    partial class FrmBuscarFuncionario
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
            this.gbBuscarFuncionario = new System.Windows.Forms.GroupBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.nCodFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCodDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCodPermissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.gbBuscarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarFuncionario
            // 
            this.gbBuscarFuncionario.Controls.Add(this.dgvFuncionarios);
            this.gbBuscarFuncionario.Controls.Add(this.tbBuscar);
            this.gbBuscarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarFuncionario.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarFuncionario.Name = "gbBuscarFuncionario";
            this.gbBuscarFuncionario.Size = new System.Drawing.Size(756, 513);
            this.gbBuscarFuncionario.TabIndex = 0;
            this.gbBuscarFuncionario.TabStop = false;
            this.gbBuscarFuncionario.Text = "Buscar funcionário";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCodFuncionario,
            this.sNomeCompleto,
            this.nCodDepartamento,
            this.nCodPermissão});
            this.dgvFuncionarios.Location = new System.Drawing.Point(6, 57);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(744, 450);
            this.dgvFuncionarios.TabIndex = 1;
            // 
            // nCodFuncionario
            // 
            this.nCodFuncionario.HeaderText = "Código";
            this.nCodFuncionario.Name = "nCodFuncionario";
            this.nCodFuncionario.ReadOnly = true;
            // 
            // sNomeCompleto
            // 
            this.sNomeCompleto.HeaderText = "Nome";
            this.sNomeCompleto.Name = "sNomeCompleto";
            this.sNomeCompleto.ReadOnly = true;
            // 
            // nCodDepartamento
            // 
            this.nCodDepartamento.HeaderText = "Departamento";
            this.nCodDepartamento.Name = "nCodDepartamento";
            this.nCodDepartamento.ReadOnly = true;
            // 
            // nCodPermissão
            // 
            this.nCodPermissão.HeaderText = "Permissão";
            this.nCodPermissão.Name = "nCodPermissão";
            this.nCodPermissão.ReadOnly = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(6, 25);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(744, 26);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // FrmBuscarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.gbBuscarFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmBuscarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarFuncionario";
            this.Load += new System.EventHandler(this.FrmBuscarFuncionario_Load);
            this.gbBuscarFuncionario.ResumeLayout(false);
            this.gbBuscarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarFuncionario;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNomeCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodPermissão;
    }
}