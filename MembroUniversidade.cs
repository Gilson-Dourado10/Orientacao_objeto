

namespace Orientacao_objetos;

    public class MembroUniversidade
    {
        public string Nome{ get ; set ;}
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"dados do Membro: {Nome}");
        }
    }
    