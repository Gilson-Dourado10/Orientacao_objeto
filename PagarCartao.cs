using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class PagarCartao : Pagamentos
    {
        public PagarCartao(DateTime dataPagamento) :base(dataPagamento)
        {
            dataPagamento = dataPagamento;
        }
        public PagarCartao()
        {
            
        }
    }
}