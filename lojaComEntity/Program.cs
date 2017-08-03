using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionandoUsuarios();
        }

        private static void VendasComVariosProdutos()
        {
            EntidadesContext ctx = new EntidadesContext();
            var usuarioDao = new UsuarioDao(ctx);
            var produtoDao = new ProdutoDao(ctx);

            var gilmar = usuarioDao.BuscaPorId(1);
            var venda = new Venda()
            {
                Cliente = gilmar
            };

            ctx.Vendas.Add(venda);

            var primeiroProduto = produtoDao.BuscaPorId(1);
            var segundoProduto = produtoDao.BuscaPorId(2);

            var produtoVenda1 = new ProdutoVenda()
            {
                Venda = venda,
                Produto = primeiroProduto
            };

            ctx.ProdutoVenda.Add(produtoVenda1);

            var produtoVenda2 = new ProdutoVenda()
            {
                Venda = venda,
                Produto = segundoProduto
            };

            ctx.ProdutoVenda.Add(produtoVenda2);
            ctx.SaveChanges();
            ctx.Dispose();
        }

        private static void ExibirVendas()
        {
            var contexto = new EntidadesContext();

            var venda = contexto.Vendas
                .Include(v => v.ProdutoVenda).ThenInclude(pv => pv.Produto)
                .FirstOrDefault(v => v.Id == 1);

            foreach (var pv in venda.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }

            Console.ReadLine();
        }

        private static void AdicionandoUsuarios()
        {
            var contexto = new EntidadesContext();

            var pf = new PessoaFisica()
            {
                Nome = "Guilherme",
                Cpf = "123456",
                Senha = "171"
            };

            contexto.PessoasFisicas.Add(pf);

            var pj = new PessoaJuridica()
            {
                Nome = "Alura",
                Cnpj = "1234651000102",
                Senha = "499"
            };

            contexto.PessoasJuridicas.Add(pj);
            contexto.SaveChanges();
        }




    }
}
