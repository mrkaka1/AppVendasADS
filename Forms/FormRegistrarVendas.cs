using AppVendasADS.Contexto;
using AppVendasADS.Models;
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
    public partial class FormRegistrarVendas : Form
    {
        private int _codVenda = 0;
        public FormRegistrarVendas()
        {
            InitializeComponent();
            _codVenda = AppContexto.ContadorCodVenda;
            AppContexto.ContadorCodVenda++;

            CarregarClientes();
            CarregarProdutos();
        }

        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProduto.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione um produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txbQuant.Text == "")
                {
                    MessageBox.Show("Informe a quantidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var produtoSelecionado = AppContexto.Produtos[cmbProduto.SelectedIndex];

                Cliente clienteSelecionado = AppContexto.Clientes[cmbCliente.SelectedIndex];

                int quantidade = int.Parse(txbQuant.Text);

                if (produtoSelecionado.Estoque == 0)
                {
                    MessageBox.Show("Produto sem estoque disponível!", "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (quantidade > produtoSelecionado.Estoque)
                {
                    MessageBox.Show($"Quantidade solicitada maior que o estoque disponível!\nEstoque atual: {produtoSelecionado.Estoque }", "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal total = produtoSelecionado.ValorUnitario * quantidade;

                AppContexto.Vendas.Add((
                    _codVenda,
                    clienteSelecionado.Cpf,
                    produtoSelecionado.Nome,
                    produtoSelecionado.Categoria,
                    produtoSelecionado.ValorUnitario,
                    quantidade,
                    total
                ));

                produtoSelecionado.Estoque -= quantidade;

                CarregarGrid();
                LimparCamposProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar item: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex >= 0)
            {
                Cliente clienteSelecionado = AppContexto.Clientes[cmbCliente.SelectedIndex];
                txbNome.Text = clienteSelecionado.Id.ToString();
                maskedTextBox1.Text = clienteSelecionado.Cpf;
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex >= 0)
            {
                Produto produtoSelecionado = AppContexto.Produtos[cmbProduto.SelectedIndex];
                textBox1.Text = produtoSelecionado.Nome;
                txbCategoria.Text = produtoSelecionado.Categoria;
                txbValorUnit.Text = produtoSelecionado.ValorUnitario.ToString("C2");
            }
        }

        private void btCancelItem_Click(object sender, EventArgs e)
        {
            var ultimoItem = AppContexto.Vendas.LastOrDefault(v => v.CodVenda == _codVenda);

            if (ultimoItem.NomeProduto != null)
            {
                Produto produto = AppContexto.Produtos.FirstOrDefault(p => p.Nome == ultimoItem.NomeProduto);
                produto.Estoque += ultimoItem.Quantidade;

                AppContexto.Vendas.Remove(ultimoItem);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Nenhum item para cancelar!", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSalvarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                bool temItens = AppContexto.Vendas.Any(v => v.CodVenda == _codVenda);

                if (!temItens)
                {
                    MessageBox.Show("Adicione ao menos um produto antes de salvar!","Venda vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Venda Nº " + _codVenda + " salva com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar venda: " + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelVenda_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja cancelar a venda? Todos os itens serão removidos.", "Cancelar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                AppContexto.Vendas
                    .Where(v => v.CodVenda == _codVenda)
                    .ToList()
                    .ForEach(v =>
                    {
                        Produto produto = AppContexto.Produtos.FirstOrDefault(p => p.Nome == v.NomeProduto);
                        produto.Estoque += v.Quantidade;
                    });

                AppContexto.Vendas.RemoveAll(v => v.CodVenda == _codVenda);
                AppContexto.ContadorCodVenda--;

                this.Close();
            }
        }
        private void LimparCamposProduto()
        {
            cmbProduto.SelectedIndex = -1;
            textBox1.Clear();
            txbCategoria.Clear();
            txbValorUnit.Clear();
            txbQuant.Clear();
        }

        private void CarregarGrid()
        {
            dgvListaItemVenda.Rows.Clear();
            dgvListaItemVenda.Columns.Clear();

            dgvListaItemVenda.Columns.Add("CodVenda", "Cód. Venda");
            dgvListaItemVenda.Columns.Add("CpfCliente", "CPF Cliente");
            dgvListaItemVenda.Columns.Add("NomeProduto", "Produto");
            dgvListaItemVenda.Columns.Add("Categoria", "Categoria");
            dgvListaItemVenda.Columns.Add("ValorUnitario", "Valor Unitário");
            dgvListaItemVenda.Columns.Add("Quantidade", "Quantidade");
            dgvListaItemVenda.Columns.Add("Total", "Total");

            AppContexto.Vendas
                .Where(v => v.CodVenda == _codVenda)
                .ToList()
                .ForEach(v => dgvListaItemVenda.Rows.Add(
                    v.CodVenda,
                    v.CpfCliente,
                    v.NomeProduto,
                    v.Categoria,
                    v.ValorUnitario.ToString("C2"),
                    v.Quantidade,
                    v.Total.ToString("C2")
                ));
        }
        private void CarregarClientes()
        {
            cmbCliente.Items.Clear();
            AppContexto.Clientes.ForEach(c => cmbCliente.Items.Add(c.Nome));
        }

        private void CarregarProdutos()
        {
            cmbProduto.Items.Clear();
            AppContexto.Produtos.ForEach(p => cmbProduto.Items.Add(p.Nome));
        }
    }
}
