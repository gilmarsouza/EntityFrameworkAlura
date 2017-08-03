using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new EntidadesContext();

            var categoria = contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.Id == 1);

            foreach (var p in categoria.Produtos)
            {
                Console.WriteLine(p.Nome);
            }

            Console.ReadLine();
        }
    }
}
