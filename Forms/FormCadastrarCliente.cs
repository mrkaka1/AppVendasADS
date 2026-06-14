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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppVendasADS.Forms
{
    public partial class FormCadastrarCliente : Form
    {
        private string _nome = "";
        private string _cpf = "";
        private string _email = "";
        private string _telefone = "";
        public FormCadastrarCliente()
        {
            InitializeComponent();
        }
        private void btCancelarCli_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrarCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (_nome == "" || _cpf.Replace(".", "").Replace("-", "").Trim() == "" || _email == "" || _telefone == "")
                {
                    MessageBox.Show("Preencha todos os campos antes de cadastrar.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool cpfJaExiste = false;

                foreach (Cliente c in AppContexto.Clientes)
                {
                    if (c.Cpf == _cpf)
                    {
                        cpfJaExiste = true;
                        break;
                    }
                }

                if (cpfJaExiste)
                {
                    MessageBox.Show("Já existe um cliente cadastrado com este CPF.",
                        "CPF duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cliente novoCliente = new Cliente(
                    AppContexto.ContadorIdCliente,
                    _nome,
                    _cpf,
                    _email,
                    _telefone
                );

                AppContexto.Clientes.Add(novoCliente);

                AppContexto.ContadorIdCliente++;

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();

            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txbNome.Clear();
            mskCPF.Clear();
            txbEmail.Clear();
            txbTelefone.Clear();
            _nome = "";
            _cpf = "";
            _email = "";
            _telefone = "";
            txbNome.Focus();
        }
        private void FormCadastrarCliente_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void txbNome_KeyUp(object sender, KeyEventArgs e)
        {
            _nome = txbNome.Text;
        }
        private void txbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            _email = txbEmail.Text;
        }
        private void txbTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            _telefone = txbTelefone.Text;
        }
        private void txbNome_Leave(object sender, EventArgs e)
        {
            _nome = txbNome.Text;
        }
        private void txbEmail_Leave(object sender, EventArgs e)
        {
            _email = txbEmail.Text;
        }
        private void txbTelefone_Leave(object sender, EventArgs e)
        {
            _telefone = txbTelefone.Text;
        }

        private void FormCadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrarCli_Click_1(object sender, EventArgs e)
        {

        }

    }
}
