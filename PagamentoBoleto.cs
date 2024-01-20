

namespace Orientacao_objetos;

    public class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;

    public override void Pagar()
    {
        Console.WriteLine("Iniciando o pagamento Boleto....");
        //implementação da lógica específica do pagmento do boleto
        Console.WriteLine($"Pagamento boleto {NumeroBoleto} realizado com sucesso.");
        base.Pagar(); // // Chama o método Pagar() da classe base
    }
}
 
    
