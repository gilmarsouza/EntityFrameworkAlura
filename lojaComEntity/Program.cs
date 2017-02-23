using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new EntidadesContext();

            var gilmar = new Usuario()
            {
                Nome = "Gilmar",
                Senha = "123"
            };

            contexto.Usuarios.Add(gilmar);
            contexto.SaveChanges();
            contexto.Dispose();

            Console.WriteLine("Salvou o usuário");
            Console.ReadLine();
        }
    }
}
