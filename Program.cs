
namespace Orientacao_objetos
{
class Orientacao_objetos
    {
static void Main()
       {
        Console.Clear();
        Carro carro = new Carro();
        carro.Modelo = "Corsa hatch";
        carro.Cor = "Prata";
        carro.Ano = 2008;
        carro.Ligar(); 
        Console.WriteLine($"Modelo: {carro.Modelo}");
        Console.WriteLine($"Cor: {carro.Cor}");
        Console.WriteLine($"Ano: {carro.Ano}");
       }
    }
}