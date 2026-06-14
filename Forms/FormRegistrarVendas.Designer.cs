namespace AppVendasADS.Forms
{
    partial class FormRegistrarVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCancelVenda = new System.Windows.Forms.Button();
            this.btSalvarVenda = new System.Windows.Forms.Button();
            this.dgvListaItemVenda = new System.Windows.Forms.DataGridView();
            this.btLimparItem = new System.Windows.Forms.Button();
            this.btCancelItem = new System.Windows.Forms.Button();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.txbQuant = new System.Windows.Forms.TextBox();
            this.txbValorUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelVenda
            // 
            this.btCancelVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btCancelVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelVenda.FlatAppearance.BorderSize = 0;
            this.btCancelVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelVenda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelVenda.ForeColor = System.Drawing.Color.White;
            this.btCancelVenda.Location = new System.Drawing.Point(604, 418);
            this.btCancelVenda.Name = "btCancelVenda";
            this.btCancelVenda.Size = new System.Drawing.Size(160, 40);
            this.btCancelVenda.TabIndex = 93;
            this.btCancelVenda.Text = "Cancelar Venda";
            this.btCancelVenda.UseVisualStyleBackColor = false;
            // 
            // btSalvarVenda
            // 
            this.btSalvarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btSalvarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvarVenda.FlatAppearance.BorderSize = 0;
            this.btSalvarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarVenda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSalvarVenda.ForeColor = System.Drawing.Color.White;
            this.btSalvarVenda.Location = new System.Drawing.Point(430, 418);
            this.btSalvarVenda.Name = "btSalvarVenda";
            this.btSalvarVenda.Size = new System.Drawing.Size(160, 40);
            this.btSalvarVenda.TabIndex = 92;
            this.btSalvarVenda.Text = "Salvar Venda";
            this.btSalvarVenda.UseVisualStyleBackColor = false;
            // 
            // dgvListaItemVenda
            // 
            this.dgvListaItemVenda.AllowUserToAddRows = false;
            this.dgvListaItemVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaItemVenda.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaItemVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaItemVenda.EnableHeadersVisualStyles = false;
            this.dgvListaItemVenda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvListaItemVenda.Location = new System.Drawing.Point(12, 273);
            this.dgvListaItemVenda.Name = "dgvListaItemVenda";
            this.dgvListaItemVenda.ReadOnly = true;
            this.dgvListaItemVenda.RowHeadersVisible = false;
            this.dgvListaItemVenda.RowHeadersWidth = 51;
            this.dgvListaItemVenda.RowTemplate.Height = 24;
            this.dgvListaItemVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaItemVenda.Size = new System.Drawing.Size(776, 130);
            this.dgvListaItemVenda.TabIndex = 91;
            // 
            // btLimparItem
            // 
            this.btLimparItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btLimparItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimparItem.FlatAppearance.BorderSize = 0;
            this.btLimparItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLimparItem.ForeColor = System.Drawing.Color.White;
            this.btLimparItem.Location = new System.Drawing.Point(462, 223);
            this.btLimparItem.Name = "btLimparItem";
            this.btLimparItem.Size = new System.Drawing.Size(110, 36);
            this.btLimparItem.TabIndex = 90;
            this.btLimparItem.Text = "Limpar";
            this.btLimparItem.UseVisualStyleBackColor = false;
            // 
            // btCancelItem
            // 
            this.btCancelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btCancelItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelItem.FlatAppearance.BorderSize = 0;
            this.btCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelItem.ForeColor = System.Drawing.Color.White;
            this.btCancelItem.Location = new System.Drawing.Point(584, 223);
            this.btCancelItem.Name = "btCancelItem";
            this.btCancelItem.Size = new System.Drawing.Size(120, 36);
            this.btCancelItem.TabIndex = 89;
            this.btCancelItem.Text = "Cancelar Item";
            this.btCancelItem.UseVisualStyleBackColor = false;
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.btAdicionarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdicionarItem.FlatAppearance.BorderSize = 0;
            this.btAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.btAdicionarItem.Location = new System.Drawing.Point(340, 223);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(110, 36);
            this.btAdicionarItem.TabIndex = 88;
            this.btAdicionarItem.Text = "Adicionar";
            this.btAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // txbQuant
            // 
            this.txbQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQuant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbQuant.Location = new System.Drawing.Point(200, 231);
            this.txbQuant.Name = "txbQuant";
            this.txbQuant.Size = new System.Drawing.Size(120, 30);
            this.txbQuant.TabIndex = 87;
            // 
            // txbValorUnit
            // 
            this.txbValorUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txbValorUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbValorUnit.Location = new System.Drawing.Point(12, 231);
            this.txbValorUnit.Name = "txbValorUnit";
            this.txbValorUnit.ReadOnly = true;
            this.txbValorUnit.Size = new System.Drawing.Size(170, 30);
            this.txbValorUnit.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 85;
            this.label8.Text = "Valor Unitário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(200, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 84;
            this.label9.Text = "Quantidade:";
            // 
            // txbCategoria
            // 
            this.txbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbCategoria.Location = new System.Drawing.Point(500, 161);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.ReadOnly = true;
            this.txbCategoria.Size = new System.Drawing.Size(160, 30);
            this.txbCategoria.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(300, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(180, 30);
            this.textBox1.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(300, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 81;
            this.label4.Text = "Nome do produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(500, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 80;
            this.label5.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 79;
            this.label7.Text = "Selec. Produto:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(12, 161);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(270, 31);
            this.cmbProduto.TabIndex = 78;
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbNome.Location = new System.Drawing.Point(300, 91);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(110, 30);
            this.txbNome.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(300, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "Cód. Cliente";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maskedTextBox1.Location = new System.Drawing.Point(430, 91);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 30);
            this.maskedTextBox1.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(430, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "Selec. cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(12, 91);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(270, 31);
            this.cmbCliente.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 60);
            this.label1.TabIndex = 71;
            this.label1.Text = "Registrar Venda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRegistrarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 476);
            this.Controls.Add(this.btCancelVenda);
            this.Controls.Add(this.btSalvarVenda);
            this.Controls.Add(this.dgvListaItemVenda);
            this.Controls.Add(this.btLimparItem);
            this.Controls.Add(this.btCancelItem);
            this.Controls.Add(this.btAdicionarItem);
            this.Controls.Add(this.txbQuant);
            this.Controls.Add(this.txbValorUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRegistrarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelVenda;
        private System.Windows.Forms.Button btSalvarVenda;
        private System.Windows.Forms.DataGridView dgvListaItemVenda;
        private System.Windows.Forms.Button btLimparItem;
        private System.Windows.Forms.Button btCancelItem;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.TextBox txbQuant;
        private System.Windows.Forms.TextBox txbValorUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
    }
}