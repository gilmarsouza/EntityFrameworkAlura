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
            var manipulador = new UsuarioDao();

            var usuario = manipulador.BuscaPorId(1);

            usuario.Nome = "Gilmar Souza";

            manipulador.SaveChages();
           
            Console.ReadLine();
        }
    }
}
