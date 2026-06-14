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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.txbQuant = new System.Windows.Forms.TextBox();
            this.txbValorUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.btCancelItem = new System.Windows.Forms.Button();
            this.btLimparItem = new System.Windows.Forms.Button();
            this.dgvListaItemVenda = new System.Windows.Forms.DataGridView();
            this.btCancelVenda = new System.Windows.Forms.Button();
            this.btSalvarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 59);
            this.label1.TabIndex = 46;
            this.label1.Text = "Registrar Venda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Selec. cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(12, 104);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(300, 24);
            this.cmbCliente.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "CPF:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(629, 104);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(159, 22);
            this.maskedTextBox1.TabIndex = 51;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(420, 106);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(99, 22);
            this.txbNome.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cód. Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Nome do produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "Selec. Produto:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(12, 171);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(300, 24);
            this.cmbProduto.TabIndex = 54;
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(629, 173);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(159, 22);
            this.txbCategoria.TabIndex = 60;
            // 
            // txbQuant
            // 
            this.txbQuant.Location = new System.Drawing.Point(262, 237);
            this.txbQuant.Name = "txbQuant";
            this.txbQuant.Size = new System.Drawing.Size(159, 22);
            this.txbQuant.TabIndex = 64;
            // 
            // txbValorUnit
            // 
            this.txbValorUnit.Location = new System.Drawing.Point(12, 237);
            this.txbValorUnit.Name = "txbValorUnit";
            this.txbValorUnit.Size = new System.Drawing.Size(179, 22);
            this.txbValorUnit.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 62;
            this.label8.Text = "Valor Unitário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 61;
            this.label9.Text = "Quantidade:";
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAdicionarItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarItem.Location = new System.Drawing.Point(455, 223);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(103, 36);
            this.btAdicionarItem.TabIndex = 65;
            this.btAdicionarItem.Text = "Adicionar";
            this.btAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // btCancelItem
            // 
            this.btCancelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCancelItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelItem.Location = new System.Drawing.Point(681, 223);
            this.btCancelItem.Name = "btCancelItem";
            this.btCancelItem.Size = new System.Drawing.Size(107, 36);
            this.btCancelItem.TabIndex = 66;
            this.btCancelItem.Text = "Cancelar Item";
            this.btCancelItem.UseVisualStyleBackColor = false;
            // 
            // btLimparItem
            // 
            this.btLimparItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btLimparItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparItem.Location = new System.Drawing.Point(568, 223);
            this.btLimparItem.Name = "btLimparItem";
            this.btLimparItem.Size = new System.Drawing.Size(107, 36);
            this.btLimparItem.TabIndex = 67;
            this.btLimparItem.Text = "Limpar";
            this.btLimparItem.UseVisualStyleBackColor = false;
            // 
            // dgvListaItemVenda
            // 
            this.dgvListaItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaItemVenda.Location = new System.Drawing.Point(12, 274);
            this.dgvListaItemVenda.Name = "dgvListaItemVenda";
            this.dgvListaItemVenda.RowHeadersWidth = 51;
            this.dgvListaItemVenda.RowTemplate.Height = 24;
            this.dgvListaItemVenda.Size = new System.Drawing.Size(776, 130);
            this.dgvListaItemVenda.TabIndex = 68;
            // 
            // btCancelVenda
            // 
            this.btCancelVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelVenda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelVenda.Location = new System.Drawing.Point(629, 410);
            this.btCancelVenda.Name = "btCancelVenda";
            this.btCancelVenda.Size = new System.Drawing.Size(159, 36);
            this.btCancelVenda.TabIndex = 70;
            this.btCancelVenda.Text = "Cancelar Venda";
            this.btCancelVenda.UseVisualStyleBackColor = false;
            // 
            // btSalvarVenda
            // 
            this.btSalvarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSalvarVenda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarVenda.Location = new System.Drawing.Point(455, 410);
            this.btSalvarVenda.Name = "btSalvarVenda";
            this.btSalvarVenda.Size = new System.Drawing.Size(149, 36);
            this.btSalvarVenda.TabIndex = 69;
            this.btSalvarVenda.Text = "Salvar Venda";
            this.btSalvarVenda.UseVisualStyleBackColor = false;
            // 
            // FormRegistrarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormRegistrarVendas";
            this.Text = "FormRegistrarVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox txbQuant;
        private System.Windows.Forms.TextBox txbValorUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.Button btCancelItem;
        private System.Windows.Forms.Button btLimparItem;
        private System.Windows.Forms.DataGridView dgvListaItemVenda;
        private System.Windows.Forms.Button btCancelVenda;
        private System.Windows.Forms.Button btSalvarVenda;
    }
}