

namespace Orientacao_objetos;

    public class MembroUniversidades
    {
        public string Nome{ get ; set ;}
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }
    