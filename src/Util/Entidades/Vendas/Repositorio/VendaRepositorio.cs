using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Entidades.Vendas.Repositorio
{
    public  class VendaRepositorio
    {
        public VendaRepositorio()
        {
            Vendas = new List<Venda>();
        }

        public  List<Venda>  Vendas { get; set; }
    }

    
}
