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
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void btConfirmarCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancelarCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = cmbCliente.SelectedIndex;

            if (indiceSelecionado >= 0)
            {
                Cliente clienteSelecionado = AppContexto.Clientes[indiceSelecionado];

                txbNome.Text = clienteSelecionado.Nome;
                txbCpf.Text = clienteSelecionado.Cpf;
                txbEmail.Text = clienteSelecionado.Email;
                txbTelefone.Text = clienteSelecionado.Telefone;
            }
        }

        private void CarregarClientes()
        {
            cmbCliente.Items.Clear();
            AppContexto.Clientes.ForEach(c => cmbCliente.Items.Add(c.Nome));
        }
    }
}
