using AppVendasADS.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVendasADS.Forms
{
    public partial class FormListarProdutos : Form
    {
        public FormListarProdutos()
        {
            InitializeComponent();
            CarregarProdutos();
        }
        private void CarregarProdutos()
        {
            dgvListaProdutos.Rows.Clear();
            dgvListaProdutos.Columns.Clear();

            dgvListaProdutos.Columns.Add("Id", "ID");
            dgvListaProdutos.Columns.Add("Nome", "Produto");
            dgvListaProdutos.Columns.Add("Categoria", "Categoria");
            dgvListaProdutos.Columns.Add("ValorUnitario", "Valor Unitário");
            dgvListaProdutos.Columns.Add("Estoque", "Qtd. Estoque");

            AppContexto.Produtos.ForEach(produto => dgvListaProdutos.Rows.Add(
                produto.Id,
                produto.Nome,
                produto.Categoria,
                produto.ValorUnitario.ToString("C2"),
                produto.Estoque
            ));
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            dgvListaProdutos.Rows.Clear();

            var resultado = AppContexto.Produtos.Where(p =>
                (txbNomeProd.Text == "" || p.Nome.ToLower().Contains(txbNomeProd.Text.ToLower())) &&
                (txbCategoria.Text == "" || p.Categoria.ToLower().Contains(txbCategoria.Text.ToLower()))
            ).ToList();

            resultado.ForEach(produto => dgvListaProdutos.Rows.Add(
                produto.Id,
                produto.Nome,
                produto.Categoria,
                produto.ValorUnitario.ToString("C2"),
                produto.Estoque
            ));
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txbNomeProd.Clear();
            txbCategoria.Clear();
            CarregarProdutos();
        }
    }

}
