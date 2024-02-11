using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class Pagamentos
    {
        public DateTime Vencimento { get; set; }
        public Pagamentos(DateTime vencimento)
        {
          Vencimento = vencimento;  
        }
    }
}