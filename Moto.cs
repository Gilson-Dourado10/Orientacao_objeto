
namespace Orientacao_objetos;

public class Moto : Posto
{
    public Moto(String proprietario) :base(proprietario){ }
    public int ObterQuantidadeCombustivel()
    {
        return Tanque;
    }

}