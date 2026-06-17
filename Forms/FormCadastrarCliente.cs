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
            this.btCadastrarCli.CausesValidation = false;
            this.btCancelarCli.CausesValidation = false;
        }
        private void btCancelarCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrarCli_Click(object sender, EventArgs e)
        {
            try
            {
                _nome = txbNome.Text;
                _cpf = mskCPF.Text.Trim();
                _email = txbEmail.Text;
                _telefone = txbTelefone.Text;

                if (_nome == "" || _cpf.Replace(".", "").Replace("-", "").Trim() == "" || _email == "" || _telefone == "")
                {
                    MessageBox.Show("Preencha todos os campos antes de cadastrar.","Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool cpfJaExiste = AppContexto.Clientes.Any(c => c.Cpf == _cpf);

                if (cpfJaExiste)
                {
                    MessageBox.Show("Já existe um cliente cadastrado com este CPF.", "CPF duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MessageBox.Show("Cliente cadastrado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       
        private void txbTelefone_KeyUp(object sender, KeyEventArgs e)
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
                MessageBox.Show("Somente números no telefone!", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (txbTelefone.Text.Length > 0)
                {
                    txbTelefone.Text = txbTelefone.Text.Remove(txbTelefone.Text.Length - 1);
                }
            }
            else
            {
                _telefone = txbTelefone.Text;
            }
        }
        private void txbNome_Leave(object sender, EventArgs e)
        {
            if (txbNome.Text == "")
            {
                MessageBox.Show("O campo Nome está vazio!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Select();
            }
        }
        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                MessageBox.Show("O campo E-mail está vazio!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Select();
            }

        }
        private void txbTelefone_Leave(object sender, EventArgs e)
        {
            if (txbTelefone.Text == "")
            {
                MessageBox.Show("O campo Telefone está vazio!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTelefone.Select();
            }
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

        private void mskCPF_Leave(object sender, EventArgs e)
        {
            if (mskCPF.Text.Contains("_") || mskCPF.Text.Replace(".", "").Replace("-", "").Trim() == "")
            {
                MessageBox.Show("Preencha o CPF corretamente!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCPF.Select();
            }
        }

    }
}
