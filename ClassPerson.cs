

// namespace Orientacao_objetos;

// public class ClassPerson
// {
//     public string  Nome { get; private set; }
//     public ClassPerson()
//     {
//         Nome = " Samuel Daniel ";
//     }
//     public void  AlterarNomePessoa() // método sem retorno para alterar o nome da pessoa
//     {
//       Nome = "Pedro Santos";
//     }
// }
//*********************************************************************



namespace Orientacao_objetos;
public class ClassPerson
{
    public string Nome { get; private set; }

    public ClassPerson(string nome)
    {
        Nome = nome;
    }
    public string AlterarNomePessoa(string nome)
    {
        return nome;
    }
}