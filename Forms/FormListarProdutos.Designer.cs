namespace AppVendasADS.Forms
{
    partial class FormListarProdutos
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
            this.dgvListaProdutos = new System.Windows.Forms.DataGridView();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.AllowUserToAddRows = false;
            this.dgvListaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutos.EnableHeadersVisualStyles = false;
            this.dgvListaProdutos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvListaProdutos.Location = new System.Drawing.Point(12, 171);
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.ReadOnly = true;
            this.dgvListaProdutos.RowHeadersVisible = false;
            this.dgvListaProdutos.RowHeadersWidth = 51;
            this.dgvListaProdutos.RowTemplate.Height = 24;
            this.dgvListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProdutos.Size = new System.Drawing.Size(776, 271);
            this.dgvListaProdutos.TabIndex = 46;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(575, 118);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(100, 34);
            this.btLimpar.TabIndex = 45;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // btFiltrar
            // 
            this.btFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFiltrar.FlatAppearance.BorderSize = 0;
            this.btFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btFiltrar.ForeColor = System.Drawing.Color.White;
            this.btFiltrar.Location = new System.Drawing.Point(465, 118);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(100, 34);
            this.btFiltrar.TabIndex = 44;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = false;
            // 
            // txbCategoria
            // 
            this.txbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbCategoria.Location = new System.Drawing.Point(265, 123);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(180, 30);
            this.txbCategoria.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(265, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Categoria:";
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbNomeProd.Location = new System.Drawing.Point(30, 123);
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(210, 30);
            this.txbNomeProd.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 70);
            this.label1.TabIndex = 39;
            this.label1.Text = "Listar Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaProdutos);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNomeProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListarProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProdutos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}