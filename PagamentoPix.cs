

namespace Orientacao_objetos;
    public class PagamentoPix : Pagamento
    {
       public  string ChavePix;
        public override void Pagar()
        {
        Console.WriteLine("Iniciando o pagamento com Pix....");
        Console.WriteLine($"Pagamento com a chave pix  {ChavePix} realizado com sucesso.");
            base.Pagar();
        }
    }
