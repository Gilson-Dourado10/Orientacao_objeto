using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class PagarCartao : Pagamentos
    {
        public PagarCartao(DateTime dataPagamento) :base(dataPagamento)
        {
            DataPagamento = dataPagamento;
        }
        public DateTime DataPagamento(get; set; ){}
        public override void Pagar()
        {
            Console.WriteLine($"pagamento com cartão efetuado em {DataPagamento}");
        }
    }
}