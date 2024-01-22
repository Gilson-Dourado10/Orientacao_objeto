// using Orientacao_objetos;
// Console.Clear();

// List<MembroUniversidades> membroUniversidades = new List<MembroUniversidades>();
// membroUniversidades.Add(new Professor {Nome = "Marco Castro" , Disciplina = "Orientação Objetos" , DataProvaFinalDisciplina = new DateTime(2024,1, 25, 19, 30, 0)}); 
// membroUniversidades.Add(new Aluno {Nome = "Felipe Ricardo" , Curso = "Análise e Desenvolvimento de sistemas", InicioCurso = new DateTime(2023,05,3)});
// membroUniversidades.Add(new Professor {Nome = "Adão Santos" , Disciplina = "Power BI"});
// membroUniversidades.Add(new Aluno {Nome = "João Pedro" , Curso = "Sistema para Internet"});

// foreach (var membro in membroUniversidades )
// {
//  membro.ExibirInfo();   
// }

// using System;

// public class Exemplo
// {
//     // Membro público
//     public string MensagemPublica = "Isso é público.";

//     // Método público
//     public void ExibirMensagem()
//     {
//         Console.WriteLine(MensagemPublica);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Instanciando a classe
//         Exemplo meuExemplo = new Exemplo();

//         // Acessando e exibindo o membro público
//         Console.WriteLine($"Mensagem: {meuExemplo.MensagemPublica}");

//         // Chamando o método público
//         meuExemplo.ExibirMensagem();

//         Console.ReadLine();
//     }
// }


                        // MODFICADOR DE ACESSO PRIVATE

using System;

public class Exemplo
{
    // Membro privado
    private string mensagemPrivada = "Isso é privado.";

    // Método privado
    private void ExibirMensagemPrivada()
    {
        Console.WriteLine(mensagemPrivada);
    }

    // Método público que chama o método privado
    public void ExibirMensagem()
    {
        // Podemos acessar o membro privado dentro da própria classe
        ExibirMensagemPrivada();
    }
}



class Program
{
    static void Main()
    {
        // Instanciando a classe
        Exemplo meuExemplo = new Exemplo();

        // Tentando acessar diretamente o membro privado (isso causaria um erro)
        // Console.WriteLine(meuExemplo.mensagemPrivada); // Isso geraria um erro de compilação

        // Chamando o método público que, por sua vez, acessa o membro privado
        meuExemplo.ExibirMensagem();

        Console.ReadLine();
    }
}
