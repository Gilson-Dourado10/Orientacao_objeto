


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

    public override string Andar(string nomeAnimal, DateTime diaDoNascimento, string raca = "viralata")
    {
        return base.Andar(nomeAnimal, diaDoNascimento, raca) + " é um  Cachorro";
    }
}
