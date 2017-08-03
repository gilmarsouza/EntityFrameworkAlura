using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lojaComEntity.Entidades;
using Microsoft.Data.Entity;

namespace lojaComEntity
{
    public class ProdutoDao
    {
        private EntidadesContext contexto;

        public ProdutoDao(EntidadesContext ctx)
        {
            contexto = ctx;
        }

        public void Adiciona(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }
        public void Remove(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
        }

        public Produto BuscaPorId(int id)
        {
            return contexto.Produtos.FirstOrDefault(x => x.Id == id);
        }

    }
}
