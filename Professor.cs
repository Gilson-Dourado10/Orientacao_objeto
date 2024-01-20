

namespace Orientacao_objetos;

public class Professor : MembroUniversidade
{
    public string Disciplina { get; set; }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome} e Disciplina: {Disciplina} ");
        base.ExibirInfo();
    }
}