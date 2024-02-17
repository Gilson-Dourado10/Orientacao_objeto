using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos;


public class PagamentoBoleto : Pagamentos
{

    public int NumeroBoleto { get; set; }
        public string NomeRecebedor{get; set; }
    public PagamentoBoleto(DateTime vencimento) : base(vencimento)
    {   
        

    }
        public  override void Pagar()
    {
        Console.WriteLine();
    }
}

