using System.Collections.Generic;
using Util.Compartilhado;
using Util.Entidades.Clientes;
using Util.Entidades.Produtos;
using Util.Entidades.Usuarios;

namespace Util.Entidades.Vendas
{
    public class Venda : EntidadeBase
    {
        public Venda(string pedido, Usuario usuario, Cliente cliente, List<Produto> produtos, decimal valorTotal, int quantidadeTotal)
        {
            Pedido = pedido;
            Usuario = usuario;
            Cliente = cliente;
            Produtos = produtos;
            ValorTotal = valorTotal;
            QuantidadeTotal = quantidadeTotal;
        }

        public string Pedido { get; set; }

        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }

        public decimal ValorTotal { get; set; }
        public int QuantidadeTotal { get; set; }

    }
}
