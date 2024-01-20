

namespace Orientacao_objetos;

public class Professor : MembroUniversidades
{
    public string Disciplina { get; set; }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Nome Professor: {Nome} e Disciplina: {Disciplina} ");
    }
}