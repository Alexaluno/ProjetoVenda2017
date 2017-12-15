using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Entidades.Usuarios.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioRepositorio()
        {
            Usuarios = new List<Usuario>();
        }

        public List<Usuario> Usuarios { get; set; }
    }
}
