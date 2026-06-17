namespace AppVendasADS.Forms
{
    partial class FormConsultarCliente
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
            this.btCancelarCli = new System.Windows.Forms.Button();
            this.btConfirmarCli = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelarCli
            // 
            this.btCancelarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btCancelarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarCli.FlatAppearance.BorderSize = 0;
            this.btCancelarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarCli.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelarCli.ForeColor = System.Drawing.Color.White;
            this.btCancelarCli.Location = new System.Drawing.Point(410, 422);
            this.btCancelarCli.Name = "btCancelarCli";
            this.btCancelarCli.Size = new System.Drawing.Size(130, 42);
            this.btCancelarCli.TabIndex = 65;
            this.btCancelarCli.Text = "Cancelar";
            this.btCancelarCli.UseVisualStyleBackColor = false;
            this.btCancelarCli.Click += new System.EventHandler(this.btCancelarCli_Click);
            // 
            // btConfirmarCli
            // 
            this.btConfirmarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btConfirmarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirmarCli.FlatAppearance.BorderSize = 0;
            this.btConfirmarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmarCli.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btConfirmarCli.ForeColor = System.Drawing.Color.White;
            this.btConfirmarCli.Location = new System.Drawing.Point(260, 422);
            this.btConfirmarCli.Name = "btConfirmarCli";
            this.btConfirmarCli.Size = new System.Drawing.Size(130, 42);
            this.btConfirmarCli.TabIndex = 64;
            this.btConfirmarCli.Text = "Confirmar";
            this.btConfirmarCli.UseVisualStyleBackColor = false;
            this.btConfirmarCli.Click += new System.EventHandler(this.btConfirmarCli_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTelefone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbTelefone.Location = new System.Drawing.Point(190, 377);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.ReadOnly = true;
            this.txbTelefone.Size = new System.Drawing.Size(420, 30);
            this.txbTelefone.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(190, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "Telefone:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbEmail.Location = new System.Drawing.Point(190, 309);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(420, 30);
            this.txbEmail.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(190, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "E-mail:";
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCpf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbCpf.Location = new System.Drawing.Point(190, 241);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.ReadOnly = true;
            this.txbCpf.Size = new System.Drawing.Size(420, 30);
            this.txbCpf.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(190, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "CPF:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbNome.Location = new System.Drawing.Point(190, 173);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(420, 30);
            this.txbNome.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(190, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(190, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Selec. cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(190, 103);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(420, 31);
            this.cmbCliente.TabIndex = 54;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 70);
            this.label1.TabIndex = 53;
            this.label1.Text = "Consultar Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 483);
            this.Controls.Add(this.btCancelarCli);
            this.Controls.Add(this.btConfirmarCli);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelarCli;
        private System.Windows.Forms.Button btConfirmarCli;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
    }
}