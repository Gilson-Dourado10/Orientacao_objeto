
namespace Orientacao_objetos;

    public class Animal
    {
        public virtual string Andar(string nomeAnimal)
        {
            return $"O animal {nomeAnimal} está andando";
        }
        public virtual  void Andar(string nomeAnimal , DateTime diaDoNascimento){}
        public virtual void Andar(string nomeAnimal, DateTime diaDoNascimento, string raca = "viralata"){} 
    }
