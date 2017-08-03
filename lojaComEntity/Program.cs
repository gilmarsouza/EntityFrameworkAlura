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

            var dao = new ProdutoDao(contexto);

            var resultado = dao.BuscaPorNomePrecoNomeCategoria(null, 25, null);

            foreach (var produto in resultado)
            {
                Console.WriteLine(produto.Nome);
            }

            Console.WriteLine("---------------------");

           resultado = dao.BuscaPorNomePrecoNomeCategoria("Mouse", 0, null);

            foreach (var produto in resultado)
            {
                Console.WriteLine(produto.Nome);
            }

            Console.WriteLine("---------------------");

            resultado = dao.BuscaPorNomePrecoNomeCategoria(null, 0, "Informática");

            foreach (var produto in resultado)
            {
                Console.WriteLine(produto.Nome);
            }




            Console.ReadLine();
        }
    }
}
