using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVendasADS.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Estoque { get; set; }

        public Produto(int id, string nome, string categoria, decimal valorUnitario, int estoque)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            ValorUnitario = valorUnitario;
            Estoque = estoque;
        }
    }
}
