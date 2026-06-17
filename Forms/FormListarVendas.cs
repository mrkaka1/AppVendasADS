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
    public partial class FormListarVendas : Form
    {
        public FormListarVendas()
        {
            InitializeComponent();
            CarregarVendas();
        }
        private void CarregarVendas()
        {
            dgvListaVendas.Rows.Clear();
            dgvListaVendas.Columns.Clear();

            dgvListaVendas.Columns.Add("CodVenda", "Cód. Venda");
            dgvListaVendas.Columns.Add("CpfCliente", "CPF Cliente");
            dgvListaVendas.Columns.Add("NomeProduto", "Produto");
            dgvListaVendas.Columns.Add("Categoria", "Categoria");
            dgvListaVendas.Columns.Add("ValorUnitario", "Valor Unitário");
            dgvListaVendas.Columns.Add("Quantidade", "Quantidade");
            dgvListaVendas.Columns.Add("Total", "Total");

            AppContexto.Vendas.ForEach(v => dgvListaVendas.Rows.Add(
                v.CodVenda,
                v.CpfCliente,
                v.NomeProduto,
                v.Categoria,
                v.ValorUnitario.ToString("C2"),
                v.Quantidade,
                v.Total.ToString("C2")
            ));
        }
        private void btFiltrar_Click_1(object sender, EventArgs e)
        {
            dgvListaVendas.Rows.Clear();

            var resultado = AppContexto.Vendas.Where(v =>
                (txbCodVenda.Text == "" || v.CodVenda.ToString().Contains(txbCodVenda.Text)) &&
                (txbCpfCli.Text == "" || v.CpfCliente.Contains(txbCpfCli.Text))
            ).ToList();

            resultado.ForEach(v => dgvListaVendas.Rows.Add(
                v.CodVenda,
                v.CpfCliente,
                v.NomeProduto,
                v.Categoria,
                v.ValorUnitario.ToString("C2"),
                v.Quantidade,
                v.Total.ToString("C2")
            ));
        }

        private void btLimpar_Click_1(object sender, EventArgs e)
        {
            txbCodVenda.Clear();
            txbCpfCli.Clear();
            CarregarVendas();
        }

        private void FormListarVendas_Load(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {

        }

    }
}
