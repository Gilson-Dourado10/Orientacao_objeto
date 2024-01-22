// // // using Orientacao_objetos;
// // // Console.Clear();

// // // List<MembroUniversidades> membroUniversidades = new List<MembroUniversidades>();
// // // membroUniversidades.Add(new Professor {Nome = "Marco Castro" , Disciplina = "Orientação Objetos" , DataProvaFinalDisciplina = new DateTime(2024,1, 25, 19, 30, 0)}); 
// // // membroUniversidades.Add(new Aluno {Nome = "Felipe Ricardo" , Curso = "Análise e Desenvolvimento de sistemas", InicioCurso = new DateTime(2023,05,3)});
// // // membroUniversidades.Add(new Professor {Nome = "Adão Santos" , Disciplina = "Power BI"});
// // // membroUniversidades.Add(new Aluno {Nome = "João Pedro" , Curso = "Sistema para Internet"});

// // // foreach (var membro in membroUniversidades )
// // // {
// // //  membro.ExibirInfo();   
// // // }

// // // using System;

// // // public class Exemplo
// // // {
// // //     // Membro público
// // //     public string MensagemPublica = "Isso é público.";

// // //     // Método público
// // //     public void ExibirMensagem()
// // //     {
// // //         Console.WriteLine(MensagemPublica);
// // //     }
// // // }

// // // class Program
// // // {
// // //     static void Main()
// // //     {
// // //         // Instanciando a classe
// // //         Exemplo meuExemplo = new Exemplo();

// // //         // Acessando e exibindo o membro público
// // //         Console.WriteLine($"Mensagem: {meuExemplo.MensagemPublica}");

// // //         // Chamando o método público
// // //         meuExemplo.ExibirMensagem();

// // //         Console.ReadLine();
// // //     }
// // // }


// //                         // MODFICADOR DE ACESSO PRIVATE

// // using System;

// // public class Exemplo
// // {
// //     // Membro privado
// //     private string mensagemPrivada = "Isso é privado.";

// //     // Método privado
// //     private void ExibirMensagemPrivada()
// //     {
// //         Console.WriteLine(mensagemPrivada);
// //     }

// //     // Método público que chama o método privado
// //     public void ExibirMensagem()
// //     {
// //         // Podemos acessar o membro privado dentro da própria classe
// //         ExibirMensagemPrivada();
// //     }
// // }



// // class Program
// // {
// //     static void Main()
// //     {
// //         // Instanciando a classe
// //         Exemplo meuExemplo = new Exemplo();

// //         // Tentando acessar diretamente o membro privado (isso causaria um erro)
// //         // Console.WriteLine(meuExemplo.mensagemPrivada); // Isso geraria um erro de compilação

// //         // Chamando o método público que, por sua vez, acessa o membro privado
// //         meuExemplo.ExibirMensagem();

// //         Console.ReadLine();
// //     }
// // }

//                      // MODFICADOR DE ACESSO PROTECTED

//                      using System;

// // Classe base com membro protegido
// public class Base
// {
//     // Membro protegido
//     protected string mensagemProtegida = "Isso é protegido.";
// }

// // Classe derivada que herda da classe base
// public class Derivada : Base
// {
//     // Método público que acessa o membro protegido
//     public void ExibirMensagemProtegida()
//     {
//         Console.WriteLine(mensagemProtegida);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Instanciando a classe derivada
//         Derivada minhaDerivada = new Derivada();

//         // Tentando acessar diretamente o membro protegido (isso causaria um erro)
//         // Console.WriteLine(minhaDerivada.mensagemProtegida); // Isso geraria um erro de compilação

//         // Chamando o método público que, por sua vez, acessa o membro protegido
//         minhaDerivada.ExibirMensagemProtegida();

//         Console.ReadLine();
//     }
// }

// MODFICADOR DE ACESSO INTERNAL

// ProjetoA (Assembly 1)
using System;

// Classe com membros internos
// public class Exemplo
// {
//     // Membro interno
//     internal string mensagemInterna = "Isso é interno.";

//     // Método interno
//     internal void ExibirMensagemInterna()
//     {
//         Console.WriteLine(mensagemInterna);
//     }
// }


// // ProjetoB (Assembly 2)
// using System;

// class Program
// {
//     static void Main()
//     {
//         // Tentativa de acessar diretamente o membro interno do ProjetoA
//         // Isso resultará em um erro de compilação
//          Exemplo exemploDoOutroProjeto = new Exemplo();
//          Console.WriteLine(exemploDoOutroProjeto.mensagemInterna);

//         // Tentativa de chamar o método interno do ProjetoA
//         // Isso resultará em um erro de compilação
//          exemploDoOutroProjeto.ExibirMensagemInterna();

//         Console.ReadLine();
//     }
// }

using System;

// Classe com membros internos
public class Exemplo
{
    // Membro interno
    internal string mensagemInterna = "Isso é interno.";

    // Método interno
    internal void ExibirMensagemInterna()
    {
        Console.WriteLine(mensagemInterna);
    }
}

class Program
{
    static void Main()
    {
        // Instanciando a classe
        Exemplo meuExemplo = new Exemplo();

        // Acessando diretamente o membro interno
        Console.WriteLine($"Mensagem Interna: {meuExemplo.mensagemInterna}");

        // Chamando o método interno
        meuExemplo.ExibirMensagemInterna();

        Console.ReadLine();
    }
}
