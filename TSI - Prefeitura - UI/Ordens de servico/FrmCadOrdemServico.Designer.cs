namespace TSI___Prefeitura.Ordens_de_servico
{
    partial class FrmCadOrdemServico
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
            this.gbOrdem = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.gbOrdem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrdem
            // 
            this.gbOrdem.Controls.Add(this.btnSalvar);
            this.gbOrdem.Controls.Add(this.lblDescricao);
            this.gbOrdem.Controls.Add(this.tbDescricao);
            this.gbOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrdem.Location = new System.Drawing.Point(12, 12);
            this.gbOrdem.Name = "gbOrdem";
            this.gbOrdem.Size = new System.Drawing.Size(756, 513);
            this.gbOrdem.TabIndex = 0;
            this.gbOrdem.TabStop = false;
            this.gbOrdem.Text = "Dados da ordem";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(675, 472);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 31);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(6, 54);
            this.tbDescricao.MaxLength = 300;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(744, 93);
            this.tbDescricao.TabIndex = 1;
            this.tbDescricao.Tag = "Descrição";
            // 
            // FrmCadOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.gbOrdem);
            this.Name = "FrmCadOrdemServico";
            this.Text = "frmCadOrdemServico";
            this.gbOrdem.ResumeLayout(false);
            this.gbOrdem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrdem;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btnSalvar;
    }
}