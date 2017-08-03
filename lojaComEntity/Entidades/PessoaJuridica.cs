using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entidades
{
    public class PessoaJuridica: Usuario
    {
        public string Cnpj { get; set; }
    }
}
