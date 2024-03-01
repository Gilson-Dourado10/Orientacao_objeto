

namespace Orientacao_objetos;

    public class PagamentoCheque
    {
       public string Remetente { get; set; } 
       public bool ChequeValido{get ; set; }

       public void LimitePagamentoCheque()
       {
         Console.WriteLine($"pagamento cheque é válido {ChequeValido}");
       }
    }

