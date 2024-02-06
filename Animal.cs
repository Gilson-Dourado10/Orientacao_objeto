
namespace Orientacao_objetos;

    public class Animal
    {
        public virtual void Andar(string nomeAnimal){}
        public virtual  void Andar(string nomeAnimal , DateTime diaDoNascimento){}
        public virtual void Andar(string nomeAnimal, DateTime diaDoNascimento, string raca = "viralata"){} 
    }
