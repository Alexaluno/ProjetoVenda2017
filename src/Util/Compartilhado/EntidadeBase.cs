using System;

namespace Util.Compartilhado
{
    public class EntidadeBase
    {
        public EntidadeBase()
        {
            Id = Guid.NewGuid(); ;
        }

        public Guid Id { get; set; }
    }
}
