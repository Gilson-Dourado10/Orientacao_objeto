using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos;

public class PagamentoBoleto : Pagamentos
{
    public PagamentoBoleto(DateTime vencimento) : base(vencimento)
    {
        public int NumeroBoleto { get; set; }
    }
}
