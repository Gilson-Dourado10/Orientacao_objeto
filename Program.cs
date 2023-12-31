
namespace Orientacao_objetos
{
class Orientacao_objetos
    {
static void Main()
       {
        // Console.Clear();
        // Carro carro = new Carro();
        // carro.Modelo = "Corsa hatch";
        // carro.Cor = "Prata";
        // carro.Ano = 2008;
        // carro.EmMovimento = false;
        // carro.Ligar(); 
        // Console.WriteLine($"Carro Em Movimento: {carro.EmMovimento}");
        // Console.WriteLine($"Modelo: {carro.Modelo}");
        // Console.WriteLine($"Cor: {carro.Cor}");
        // Console.WriteLine($"Ano: {carro.Ano}");
        // carro.Ligar();
        // carro.EmMovimento = true;
        // Console.WriteLine($"Carro Em Movimento: {carro.EmMovimento}");
        // carro.Desligar();
        // carro.EmMovimento = false;
        // Console.WriteLine($"Carro Em Movimento: {carro.EmMovimento}");
        ContaBancaria contaBancaria = new ContaBancaria();
        contaBancaria.Titular = "Pedro Sampaio";
        contaBancaria.Saldo = 300;
        Console.WriteLine($"Titular: {contaBancaria.Titular}");
        Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
        contaBancaria.Depositar(100);
        contaBancaria.Sacar(450);
        // Console.WriteLine($"Depósito: {depositado}");
        // Console.WriteLine($"Saque: {sacar}");
       }
    }
}