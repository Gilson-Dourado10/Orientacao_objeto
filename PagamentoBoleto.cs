using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos;


public class PagamentoBoleto : Pagamentos
{

    public double NumeroBoleto { get; set; }
    public string NomeRecebedor{get; set; }
    public string DataVencimento{get: set; }
    public PagamentoBoleto(DateTime vencimento, double numeroBoleto, string nomeRecebedor) : base(vencimento)
    {   
        NumeroBoleto = numeroBoleto;
        NomeRecebedor = nomeRecebedor;

    }
        public  override void Pagar()
    {
        Console.WriteLine($"pagamento do boleto número {NumeroBoleto} efetuado para {NomeRecebedor}");
    }
}

