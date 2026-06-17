namespace AppVendasADS.Forms
{
    partial class FormCadastrarProduto
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
            this.btCancelarProd = new System.Windows.Forms.Button();
            this.btCadastrarProd = new System.Windows.Forms.Button();
            this.txbQtdEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbValorUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelarProd
            // 
            this.btCancelarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btCancelarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarProd.FlatAppearance.BorderSize = 0;
            this.btCancelarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarProd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelarProd.ForeColor = System.Drawing.Color.White;
            this.btCancelarProd.Location = new System.Drawing.Point(410, 402);
            this.btCancelarProd.Name = "btCancelarProd";
            this.btCancelarProd.Size = new System.Drawing.Size(130, 42);
            this.btCancelarProd.TabIndex = 40;
            this.btCancelarProd.Text = "Cancelar";
            this.btCancelarProd.UseVisualStyleBackColor = false;
            this.btCancelarProd.Click += new System.EventHandler(this.btCancelarProd_Click);
            // 
            // btCadastrarProd
            // 
            this.btCadastrarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btCadastrarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrarProd.FlatAppearance.BorderSize = 0;
            this.btCadastrarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarProd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrarProd.ForeColor = System.Drawing.Color.White;
            this.btCadastrarProd.Location = new System.Drawing.Point(260, 402);
            this.btCadastrarProd.Name = "btCadastrarProd";
            this.btCadastrarProd.Size = new System.Drawing.Size(130, 42);
            this.btCadastrarProd.TabIndex = 39;
            this.btCadastrarProd.Text = "Cadastrar";
            this.btCadastrarProd.UseVisualStyleBackColor = false;
            this.btCadastrarProd.Click += new System.EventHandler(this.btCadastrarProd_Click);
            // 
            // txbQtdEstoque
            // 
            this.txbQtdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQtdEstoque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbQtdEstoque.Location = new System.Drawing.Point(190, 347);
            this.txbQtdEstoque.Name = "txbQtdEstoque";
            this.txbQtdEstoque.Size = new System.Drawing.Size(420, 30);
            this.txbQtdEstoque.TabIndex = 38;
            this.txbQtdEstoque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbQtdEstoque_KeyUp);
            this.txbQtdEstoque.Leave += new System.EventHandler(this.txbQtdEstoque_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(190, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Qtd. Estoque:";
            // 
            // txbValorUnitario
            // 
            this.txbValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorUnitario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbValorUnitario.Location = new System.Drawing.Point(190, 279);
            this.txbValorUnitario.Name = "txbValorUnitario";
            this.txbValorUnitario.Size = new System.Drawing.Size(420, 30);
            this.txbValorUnitario.TabIndex = 36;
            this.txbValorUnitario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbValorUnitario_KeyUp);
            this.txbValorUnitario.Leave += new System.EventHandler(this.txbValorUnitario_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(190, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Valor Unitário:";
            // 
            // txbCategoria
            // 
            this.txbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbCategoria.Location = new System.Drawing.Point(190, 211);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(420, 30);
            this.txbCategoria.TabIndex = 34;
            this.txbCategoria.Leave += new System.EventHandler(this.txbCategoria_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(190, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Categoria:";
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbNomeProd.Location = new System.Drawing.Point(190, 143);
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(420, 30);
            this.txbNomeProd.TabIndex = 32;
            this.txbNomeProd.Leave += new System.EventHandler(this.txbNomeProd_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(190, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 70);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cadastrar Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btCancelarProd);
            this.Controls.Add(this.btCadastrarProd);
            this.Controls.Add(this.txbQtdEstoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbValorUnitario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNomeProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelarProd;
        private System.Windows.Forms.Button btCadastrarProd;
        private System.Windows.Forms.TextBox txbQtdEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbValorUnitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}