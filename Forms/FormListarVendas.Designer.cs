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
            this.dgvListaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVendas.Location = new System.Drawing.Point(12, 164);
            this.dgvListaVendas.Name = "dgvListaVendas";
            this.dgvListaVendas.RowHeadersWidth = 51;
            this.dgvListaVendas.RowTemplate.Height = 24;
            this.dgvListaVendas.Size = new System.Drawing.Size(776, 271);
            this.dgvListaVendas.TabIndex = 46;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(604, 107);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(80, 32);
            this.btLimpar.TabIndex = 45;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltrar.Location = new System.Drawing.Point(510, 107);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(80, 32);
            this.btFiltrar.TabIndex = 44;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // txbCpfCli
            // 
            this.txbCpfCli.Location = new System.Drawing.Point(326, 117);
            this.txbCpfCli.Name = "txbCpfCli";
            this.txbCpfCli.Size = new System.Drawing.Size(160, 22);
            this.txbCpfCli.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "CPF do Cliente:";
            // 
            // txbCodVenda
            // 
            this.txbCodVenda.Location = new System.Drawing.Point(107, 117);
            this.txbCodVenda.Name = "txbCodVenda";
            this.txbCodVenda.Size = new System.Drawing.Size(188, 22);
            this.txbCodVenda.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cód. da Venda:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 59);
            this.label1.TabIndex = 39;
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