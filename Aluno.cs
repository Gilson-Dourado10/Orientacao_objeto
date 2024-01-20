

namespace Orientacao_objetos;

    public class Aluno : MembroUniversidades
    {
     public string Curso{get ; set ;}
    public override void ExibirInfo()
    {
        Console.WriteLine($"Nome Aluno: {Nome} Curso: {Curso}");
    }


}
