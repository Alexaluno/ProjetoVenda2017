using System.Collections.Generic;
using Util.Compartilhado;
using Util.Entidades.Clientes;
using Util.Entidades.Produtos;
using Util.Entidades.Usuarios;

namespace Util.Entidades.Vendas
{
    public class Venda : EntidadeBase
    {
        public string Pedido { get; set; }

        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }

        public decimal ValorTotal { get; set; }
        public int QuantidadeTotal { get; set; }

    }
}
