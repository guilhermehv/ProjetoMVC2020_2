namespace ProjetoMVCA20.UI
{
    partial class frmUsuarioDados
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
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMae = new System.Windows.Forms.Label();
            this.txtNomeA20 = new System.Windows.Forms.TextBox();
            this.txtNomeMaeA20 = new System.Windows.Forms.TextBox();
            this.txtCpfA20 = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(156, 63);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(156, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(156, 181);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(62, 13);
            this.lblMae.TabIndex = 2;
            this.lblMae.Text = "Nome Mãe:";
            // 
            // txtNomeA20
            // 
            this.txtNomeA20.Location = new System.Drawing.Point(156, 148);
            this.txtNomeA20.Name = "txtNomeA20";
            this.txtNomeA20.Size = new System.Drawing.Size(206, 20);
            this.txtNomeA20.TabIndex = 3;
            // 
            // txtNomeMaeA20
            // 
            this.txtNomeMaeA20.Location = new System.Drawing.Point(156, 207);
            this.txtNomeMaeA20.Name = "txtNomeMaeA20";
            this.txtNomeMaeA20.Size = new System.Drawing.Size(206, 20);
            this.txtNomeMaeA20.TabIndex = 4;
            // 
            // txtCpfA20
            // 
            this.txtCpfA20.Location = new System.Drawing.Point(156, 89);
            this.txtCpfA20.Name = "txtCpfA20";
            this.txtCpfA20.Size = new System.Drawing.Size(206, 20);
            this.txtCpfA20.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Green;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(156, 240);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(275, 240);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmUsuarioDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(533, 347);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCpfA20);
            this.Controls.Add(this.txtNomeMaeA20);
            this.Controls.Add(this.txtNomeA20);
            this.Controls.Add(this.lblMae);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.TextBox txtNomeA20;
        private System.Windows.Forms.TextBox txtNomeMaeA20;
        private System.Windows.Forms.TextBox txtCpfA20;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSair;
    }
}