using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Entidades.Produtos.Repositorio
{
    public class ProdutoRepositorio
    {
        public ProdutoRepositorio()
        {
            Produtos = new List<Produto>();
        }

        public  List<Produto> Produtos { get; set; }
    }
}
