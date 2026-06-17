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
    public partial class FormCadastrarProduto : Form
    {
        private string _nomeProduto = "";
        private string _categoria = "";
        private decimal _valorUnitario = 0;
        private int _qtdEstoque = 0;
        public FormCadastrarProduto()
        {
            InitializeComponent();

            this.btCadastrarProd.CausesValidation = false;
            this.btCancelarProd.CausesValidation = false;
        }

        private void btCadastrarProd_Click(object sender, EventArgs e)
        {
            try
            {
                _nomeProduto = txbNomeProd.Text;
                _categoria = txbCategoria.Text;

                if (_nomeProduto == "" || _categoria == "" ||
                    txbValorUnitario.Text == "" || txbQtdEstoque.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos antes de cadastrar.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool produtoJaExiste = AppContexto.Produtos.Any(p => p.Nome.ToLower() == _nomeProduto.ToLower());

                if (produtoJaExiste)
                {
                    MessageBox.Show("Já existe um produto cadastrado com este nome.", "Produto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _valorUnitario = decimal.Parse(txbValorUnitario.Text);
                _qtdEstoque = int.Parse(txbQtdEstoque.Text);

                Produto novoProduto = new Produto(
                    AppContexto.ContadorIdProduto,
                    _nomeProduto,
                    _categoria,
                    _valorUnitario,
                    _qtdEstoque
                );

                AppContexto.Produtos.Add(novoProduto);

                AppContexto.ContadorIdProduto++;

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txbNomeProd.Clear();
            txbCategoria.Clear();
            txbValorUnitario.Clear();
            txbQtdEstoque.Clear();
            _nomeProduto = "";
            _categoria = "";
            _valorUnitario = 0;
            _qtdEstoque = 0;
            txbNomeProd.Focus();
        }

        private void txbValorUnitario_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;
                if (e.KeyCode == Keys.Back) verificarNumero = true;

                int qtdVirgula = txbValorUnitario.Text.Split(',').Length - 1;
                if (qtdVirgula > 1) verificarNumero = false;
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (txbValorUnitario.Text.Length > 0)
                    txbValorUnitario.Text = txbValorUnitario.Text.Remove(txbValorUnitario.Text.Length - 1);
            }
        }

        private void txbQtdEstoque_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Back) verificarNumero = true;
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números inteiros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (txbQtdEstoque.Text.Length > 0)
                    txbQtdEstoque.Text = txbQtdEstoque.Text.Remove(txbQtdEstoque.Text.Length - 1);
            }
        }

        private void txbNomeProd_Leave(object sender, EventArgs e)
        {
            if (txbNomeProd.Text == "")
            {
                MessageBox.Show("O campo Nome do Produto está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNomeProd.Focus();
            }
        }

        private void txbCategoria_Leave(object sender, EventArgs e)
        {
            if (txbCategoria.Text == "")
            {
                MessageBox.Show("O campo Categoria está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCategoria.Focus();
            }
        }

        private void txbQtdEstoque_Leave(object sender, EventArgs e)
        {
            if (txbQtdEstoque.Text == "")
            {
                MessageBox.Show("O campo Quantidade em Estoque está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbQtdEstoque.Focus();
            }
        }

        private void txbValorUnitario_Leave(object sender, EventArgs e)
        {
            if (txbValorUnitario.Text == "")
            {
                MessageBox.Show("O campo Valor Unitário está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValorUnitario.Focus();
            }
        }

        private void btCancelarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
