using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public virtual Usuario Cliente { get; set; }
        public int ClienteId { get; set; }

        public IList<ProdutoVenda> ProdutoVenda { get; set; }

        public Venda()
        {
            ProdutoVenda = new List<ProdutoVenda>();
        }
    }
}
