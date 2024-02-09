


using System.Reflection.Metadata.Ecma335;

namespace Orientacao_objetos;

    public class Cachorro : Animal
    {
        public string DonoDoAnimal { get; set; }
    public override string Andar(string nomeAnimal)
    {
        return base.Andar(nomeAnimal) + " é um  Cachorro";
    }
    public override string Andar(string nomeAnimal, DateTime diaDoNascimento)
    {
        return base.Andar(nomeAnimal, diaDoNascimento) + " é um  Cachorro";
    }

    public override string Andar(string nomeAnimal, DateTime diaDoNascimento, string raca = "poodle")
    {
        // if (raca != "viralata")
        // {
        //     return base.Andar(nomeAnimal, diaDoNascimento, raca) + " é um  Cachorro  ";
        // }
        // else
        // {
        //     return base.Andar(nomeAnimal, diaDoNascimento, raca);
        // }

        // condição ? expressão1_se_true : expressão2_se_false
        return raca != "viralata" ?  base.Andar(nomeAnimal, diaDoNascimento, raca) + ($"{raca}") : base.Andar(nomeAnimal, diaDoNascimento, raca);
    }
}
