namespace TSI___Prefeitura.Departamentos
{
    partial class FrmBuscarDepartamento
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
            this.gbBuscarDepartamento = new System.Windows.Forms.GroupBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.nCodDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNomeDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCodGerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarDepartamento
            // 
            this.gbBuscarDepartamento.Controls.Add(this.dgvDepartamentos);
            this.gbBuscarDepartamento.Controls.Add(this.tbBuscar);
            this.gbBuscarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarDepartamento.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarDepartamento.Name = "gbBuscarDepartamento";
            this.gbBuscarDepartamento.Size = new System.Drawing.Size(756, 513);
            this.gbBuscarDepartamento.TabIndex = 0;
            this.gbBuscarDepartamento.TabStop = false;
            this.gbBuscarDepartamento.Text = "Buscar departamento";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(7, 26);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(743, 26);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCodDepartamento,
            this.sNomeDepartamento,
            this.nCodGerente});
            this.dgvDepartamentos.Location = new System.Drawing.Point(6, 58);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(744, 449);
            this.dgvDepartamentos.TabIndex = 1;
            // 
            // nCodDepartamento
            // 
            this.nCodDepartamento.HeaderText = "Código";
            this.nCodDepartamento.Name = "nCodDepartamento";
            this.nCodDepartamento.ReadOnly = true;
            // 
            // sNomeDepartamento
            // 
            this.sNomeDepartamento.HeaderText = "Departamento";
            this.sNomeDepartamento.Name = "sNomeDepartamento";
            this.sNomeDepartamento.ReadOnly = true;
            // 
            // nCodGerente
            // 
            this.nCodGerente.HeaderText = "Gerente";
            this.nCodGerente.Name = "nCodGerente";
            this.nCodGerente.ReadOnly = true;
            // 
            // FrmBuscarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.gbBuscarDepartamento);
            this.Name = "FrmBuscarDepartamento";
            this.Text = "FrmBuscarDepartamento";
            this.Load += new System.EventHandler(this.FrmBuscarDepartamento_Load);
            this.Shown += new System.EventHandler(this.FrmBuscarDepartamento_Shown);
            this.gbBuscarDepartamento.ResumeLayout(false);
            this.gbBuscarDepartamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarDepartamento;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNomeDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCodGerente;
    }
}