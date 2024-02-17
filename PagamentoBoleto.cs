using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos;


public class PagamentoBoleto : Pagamentos
{

    public double NumeroBoleto { get; set; }
    public string NomeRecebedor{get; set; }
    public PagamentoBoleto(DateTime vencimento, double numeroBoleto, string nomeRecebedor) : base(vencimento)
    {   
        NumeroBoleto = numeroBoleto;
        nomeRecebedor = nomeRecebedor;

    }
        public  override void Pagar()
    {
        Console.WriteLine();
    }
}

