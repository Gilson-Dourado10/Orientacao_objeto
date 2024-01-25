

// namespace Orientacao_objetos;

//     public class MinhaPropriedade
//     {
//         public int MyProperty { get; set; }
//     }


// namespace Orientacao_objetos;
//     public class MyProperty
//     {
//     private int myProperty;

//     public int MyProperty { get => myProperty; set => myProperty = value; }
// }


//*******************************************************************

namespace Orientacao_objetos;
public class MinhaPropriedade
{
    public int MyProperty { get; private set; }
    public MinhaPropriedade(int valorInicial)
    {
        MyProperty = valorInicial;
    }
    public void AlterarValorDaPropriedade(int NovoValor)
    {
        MyProperty = NovoValor;
    }
}