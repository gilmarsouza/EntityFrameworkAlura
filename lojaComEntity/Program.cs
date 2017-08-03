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

            var precoMinimo = 40;

            //Busca por ordem alfabética
            var busca1 = from p in contexto.Produtos
                         orderby p.Nome
                         select p;

            //Busca por produtos com preço maior que 100 em ordem alfabética
            var busca2 = from p in contexto.Produtos
                         where p.Preco > 100
                         orderby p.Nome
                         select p;

            //Busca por produtos com preço maior que 100 e que façam parte da categoria "Roupas"
            var busca3 = from p in contexto.Produtos
                         where p.Preco > 100 
                            && p.Categoria.Nome == "Roupas"
                         select p;

            var resultado = busca3.ToList();

            foreach (var produto in resultado)
            {
                Console.WriteLine(string.Format("{0} - {1}", produto.Nome, produto.Preco));
            }

            Console.ReadLine();
        }
    }
}
