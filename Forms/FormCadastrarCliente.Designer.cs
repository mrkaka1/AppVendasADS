namespace AppVendasADS.Forms
{
    partial class FormCadastrarCliente
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
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.btCancelarCli = new System.Windows.Forms.Button();
            this.btCadastrarCli = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskCPF
            // 
            this.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCPF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mskCPF.Location = new System.Drawing.Point(190, 211);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(200, 30);
            this.mskCPF.TabIndex = 63;
            this.mskCPF.Leave += new System.EventHandler(this.mskCPF_Leave);
            // 
            // btCancelarCli
            // 
            this.btCancelarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btCancelarCli.CausesValidation = false;
            this.btCancelarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarCli.FlatAppearance.BorderSize = 0;
            this.btCancelarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarCli.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelarCli.ForeColor = System.Drawing.Color.White;
            this.btCancelarCli.Location = new System.Drawing.Point(410, 402);
            this.btCancelarCli.Name = "btCancelarCli";
            this.btCancelarCli.Size = new System.Drawing.Size(130, 42);
            this.btCancelarCli.TabIndex = 62;
            this.btCancelarCli.Text = "Cancelar";
            this.btCancelarCli.UseVisualStyleBackColor = false;
            this.btCancelarCli.Click += new System.EventHandler(this.btCancelarCli_Click);
            // 
            // btCadastrarCli
            // 
            this.btCadastrarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btCadastrarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrarCli.FlatAppearance.BorderSize = 0;
            this.btCadastrarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarCli.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrarCli.ForeColor = System.Drawing.Color.White;
            this.btCadastrarCli.Location = new System.Drawing.Point(260, 402);
            this.btCadastrarCli.Name = "btCadastrarCli";
            this.btCadastrarCli.Size = new System.Drawing.Size(130, 42);
            this.btCadastrarCli.TabIndex = 61;
            this.btCadastrarCli.Text = "Cadastrar";
            this.btCadastrarCli.UseVisualStyleBackColor = false;
            this.btCadastrarCli.Click += new System.EventHandler(this.btCadastrarCli_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTelefone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbTelefone.Location = new System.Drawing.Point(190, 347);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(420, 30);
            this.txbTelefone.TabIndex = 60;
            this.txbTelefone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbTelefone_KeyUp);
            this.txbTelefone.Leave += new System.EventHandler(this.txbTelefone_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(190, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Telefone:";
            // 
            // txbEmail
            // 
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbEmail.Location = new System.Drawing.Point(190, 279);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(420, 30);
            this.txbEmail.TabIndex = 58;
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(190, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(190, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "CPF:";
            // 
            // txbNome
            // 
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbNome.Location = new System.Drawing.Point(190, 143);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(420, 30);
            this.txbNome.TabIndex = 55;
            this.txbNome.Leave += new System.EventHandler(this.txbNome_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(190, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 70);
            this.label1.TabIndex = 53;
            this.label1.Text = "Cadastrar Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.btCancelarCli);
            this.Controls.Add(this.btCadastrarCli);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarCliente";
            this.Load += new System.EventHandler(this.FormCadastrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Button btCancelarCli;
        private System.Windows.Forms.Button btCadastrarCli;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}