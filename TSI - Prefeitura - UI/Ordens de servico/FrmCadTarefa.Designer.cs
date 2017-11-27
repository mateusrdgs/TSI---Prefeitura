namespace TSI___Prefeitura.Ordens_de_servico
{
    partial class FrmCadTarefa
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
            this.gbDadosTarefa = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbDadosTarefa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosTarefa
            // 
            this.gbDadosTarefa.Controls.Add(this.btnSalvar);
            this.gbDadosTarefa.Controls.Add(this.cbDepartamento);
            this.gbDadosTarefa.Controls.Add(this.lblDepartamento);
            this.gbDadosTarefa.Controls.Add(this.tbDescricao);
            this.gbDadosTarefa.Controls.Add(this.lblDescricao);
            this.gbDadosTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosTarefa.Location = new System.Drawing.Point(12, 12);
            this.gbDadosTarefa.Name = "gbDadosTarefa";
            this.gbDadosTarefa.Size = new System.Drawing.Size(752, 488);
            this.gbDadosTarefa.TabIndex = 0;
            this.gbDadosTarefa.TabStop = false;
            this.gbDadosTarefa.Text = "Dados da tarefa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(671, 452);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(10, 145);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(333, 28);
            this.cbDepartamento.TabIndex = 2;
            this.cbDepartamento.Tag = "Departamento";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(6, 122);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(112, 20);
            this.lblDepartamento.TabIndex = 0;
            this.lblDepartamento.Text = "Departamento";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(10, 54);
            this.tbDescricao.MaxLength = 100;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(736, 52);
            this.tbDescricao.TabIndex = 1;
            this.tbDescricao.Tag = "Descrição";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 31);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // FrmCadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 512);
            this.Controls.Add(this.gbDadosTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadTarefa";
            this.Load += new System.EventHandler(this.FrmCadTarefa_Load);
            this.Shown += new System.EventHandler(this.FrmCadTarefa_Shown);
            this.gbDadosTarefa.ResumeLayout(false);
            this.gbDadosTarefa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosTarefa;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Button btnSalvar;
    }
}