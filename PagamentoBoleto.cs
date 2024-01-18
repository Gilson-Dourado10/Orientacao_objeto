

namespace Orientacao_objetos;

    public class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;

    public override void Pagar()
    {
        

        base.Pagar(); // chamando a herança do método
    }
}
 
    
