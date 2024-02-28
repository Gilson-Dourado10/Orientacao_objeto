using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos;

public class PagamentoDebito : Pagamentos

{
    public PagamentoDebito(DateTime vencimento, decimal valorPago, string nomeCliiente) : base(vencimento)
    {
    }

    public decimal ValorPago { get; set; }
    public string NomeCliente { get; set; }

    public override void Pagar()
    {
        Console.WriteLine($"O cliente {NomeCliente} pagou o valor de {ValorPago }");
    }

}


