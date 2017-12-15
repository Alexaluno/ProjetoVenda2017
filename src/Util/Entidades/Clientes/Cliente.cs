using Util.Compartilhado;

namespace Util.Entidades.Clientes
{
    public class Cliente : EntidadeBase
    {
        public Cliente(string nome, string cpf, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
    }
}
