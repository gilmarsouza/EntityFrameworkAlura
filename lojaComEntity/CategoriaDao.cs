using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lojaComEntity.Entidades;
using Microsoft.Data.Entity;

namespace lojaComEntity
{
    public class CategoriaDao
    {
        private EntidadesContext contexto;

        public CategoriaDao(EntidadesContext ctx)
        {
            contexto = ctx;
        }

        public void Adiciona(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public void Remove(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
            contexto.SaveChanges();
        }

        public Categoria BuscaPorId(int id)
        {
            return contexto.Categorias.FirstOrDefault(x => x.Id == id);
        }
    }
}
