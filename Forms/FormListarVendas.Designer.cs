namespace AppVendasADS.Forms
{
    partial class FormListarVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaVendas = new System.Windows.Forms.DataGridView();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.txbCpfCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCodVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVendas
            // 
            this.dgvListaVendas.AllowUserToAddRows = false;
            this.dgvListaVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaVendas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVendas.EnableHeadersVisualStyles = false;
            this.dgvListaVendas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvListaVendas.Location = new System.Drawing.Point(12, 171);
            this.dgvListaVendas.Name = "dgvListaVendas";
            this.dgvListaVendas.ReadOnly = true;
            this.dgvListaVendas.RowHeadersVisible = false;
            this.dgvListaVendas.RowHeadersWidth = 51;
            this.dgvListaVendas.RowTemplate.Height = 24;
            this.dgvListaVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVendas.Size = new System.Drawing.Size(776, 271);
            this.dgvListaVendas.TabIndex = 54;
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
            this.btLimpar.TabIndex = 53;
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
            this.btFiltrar.TabIndex = 52;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = false;
            // 
            // txbCpfCli
            // 
            this.txbCpfCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCpfCli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbCpfCli.Location = new System.Drawing.Point(265, 123);
            this.txbCpfCli.Name = "txbCpfCli";
            this.txbCpfCli.Size = new System.Drawing.Size(180, 30);
            this.txbCpfCli.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(265, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "CPF do Cliente:";
            // 
            // txbCodVenda
            // 
            this.txbCodVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodVenda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbCodVenda.Location = new System.Drawing.Point(30, 123);
            this.txbCodVenda.Name = "txbCodVenda";
            this.txbCodVenda.Size = new System.Drawing.Size(210, 30);
            this.txbCodVenda.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cód. da Venda:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 70);
            this.label1.TabIndex = 47;
            this.label1.Text = "Listar Vendas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormListarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaVendas);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.txbCpfCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCodVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormListarVendas";
            this.Text = "FormListarVendas";
            this.Load += new System.EventHandler(this.FormListarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVendas;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.TextBox txbCpfCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCodVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}