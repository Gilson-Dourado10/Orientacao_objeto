

namespace Orientacao_objetos;

public class Pagamento
{
    public DateTime Vencimento;
    public void Pagar()
    {
        ConsultarSaldoCartao("5228 4643 3066 3579");
    }

    private void ConsultarSaldoCartao(string numero)        //ABSTRAÇÃO
    {

    }

}
