using Util.Compartilhado;

namespace Util.Entidades.Usuarios
{
    public class Usuario : EntidadeBase
    {
        public Usuario(string nome, bool administrador)
        {
            Nome = nome;
            Administrador = administrador;
        }

        public string Nome { get; set; }
        public bool Administrador { get; set; }
    }
}
