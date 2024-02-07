


namespace Orientacao_objetos;

    public class Cachorro : Animal
    {
        public string DonoDoAnimal { get; set; }
    public override string Andar(string nomeAnimal)
    {
        return base.Andar(nomeAnimal) + " Cachorro";
    }
    public override string Andar(string nomeAnimal, DateTime diaDoNascimento)
    {
        return base.Andar(nomeAnimal, diaDoNascimento) + " Cachorro";
    }

    public override string Andar(string nomeAnimal, DateTime diaDoNascimento, string raca = "viralata")
    {
        return base.Andar(nomeAnimal, diaDoNascimento, raca) + " Cachorro";
    }
}
