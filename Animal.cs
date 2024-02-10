
namespace Orientacao_objetos;

    public class Animal
    {
      public Animal()
      {
        Console.WriteLine("Construtor da classe animal");
      }
        public virtual string Andar(string nomeAnimal)
        {
            return $"O animal {nomeAnimal} está andando";
        }
        public virtual  string Andar(string nomeAnimal , DateTime diaDoNascimento)
        {
          int idade = (int)((DateTime.Now - diaDoNascimento).TotalDays / 365);  
          return $"O animal {nomeAnimal} está andando. Idade: {idade} anos.";
        }
        public virtual string  Andar(string nomeAnimal, DateTime diaDoNascimento, string raca = "viralata")
        {
            int idade = (int)((DateTime.Now - diaDoNascimento).TotalDays / 365);  
          return $"O animal {nomeAnimal} está andando. Idade: {idade} anos. Raça: {raca}";
        } 
    }
