using Util.Compartilhado;

namespace Util.Entidades.Produtos
{
    public class Produto : EntidadeBase
    {
        public Produto(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
