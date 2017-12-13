using Util.Compartilhado;

namespace Util.Entidades.Usuarios
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public bool Administrador { get; set; }
    }
}
