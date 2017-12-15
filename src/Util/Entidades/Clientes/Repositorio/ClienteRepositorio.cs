using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Entidades.Clientes.Repositorio
{
    public  class ClienteRepositorio
    {
        public ClienteRepositorio()
        {
            Clientes = new List<Cliente>();
        }

        public  List<Cliente> Clientes { get; set; }
    }
}
