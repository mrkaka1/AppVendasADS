using AppVendasADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVendasADS.Contexto
{
    public static class AppContexto
    {
        public static List<Cliente> Clientes = new List<Cliente>();

        public static List<(int Id, string Nome, string Categoria, decimal ValorUnitario, int Estoque)> Produtos
            = new List<(int, string, string, decimal, int)>();

        public static List<(int CodVenda, string CpfCliente, string NomeProduto, string Categoria, decimal ValorUnitario, int Quantidade, decimal Total)> Vendas
            = new List<(int, string, string, string, decimal, int, decimal)>();

        public static int ContadorIdCliente = 1;
        public static int ContadorIdProduto = 1;
        public static int ContadorCodVenda = 1000;
    }
}
