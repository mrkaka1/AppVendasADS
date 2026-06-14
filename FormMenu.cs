using AppVendasADS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVendasADS
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btCadCliente_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente newCliente = new FormCadastrarCliente();
            this.Hide();
            newCliente.ShowDialog();
            this.Show();
        }

        private void btCadProduto_Click(object sender, EventArgs e)
        {
            FormCadastrarProduto newProduto = new FormCadastrarProduto();
            this.Hide();
            newProduto.ShowDialog();
            this.Show();
        }

        private void btListarProdutos_Click(object sender, EventArgs e)
        {
            FormListarProdutos newListaProd = new FormListarProdutos();
            this.Hide();
            newListaProd.ShowDialog();
            this.Show();
        }

        private void btListarVendas_Click(object sender, EventArgs e)
        {
            FormListarVendas newListaVenda = new FormListarVendas();
            this.Hide();
            newListaVenda.ShowDialog();
            this.Show();
        }

        private void btRegistrarVenda_Click(object sender, EventArgs e)
        {
            FormRegistrarVendas newVenda = new FormRegistrarVendas();
            this.Hide();
            newVenda.ShowDialog();
            this.Show();
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            FormConsultarCliente newCliente = new FormConsultarCliente();
            this.Hide();
            newCliente.ShowDialog();
            this.Show();
        }
    }
}
