
// namespace Orientacao_objetos
// {
// class Orientacao_objetos
//     {
// static void Main()
//        {
//          Console.Clear();
//         // Carro carro = new Carro();
//         // carro.Modelo = "Corsa hatch";
//         // carro.Cor = "Prata";
//         // carro.Ano = 2008;
//         // carro.EmMovimento = false;
//         // carro.Ligar(); 
//         // Console.WriteLine($"Carro Em Movimento: {carro.EmMovimento}");
//         // Console.WriteLine($"Modelo: {carro.Modelo}");
//         // Console.WriteLine($"Cor: {carro.Cor}");
//         // Console.WriteLine($"Ano: {carro.Ano}");
//         // carro.Ligar();
//         // carro.EmMovimento = true;
//         // Console.WriteLine($"Carro Em Movimento: {carro.EmMovimento}");
//         // carro.Desligar();
//         // carro.EmMovimento = false;
//         // Console.WriteLine($"Carro Em Movimento: {carro.EmMovimento}");
//         ContaBancaria contaBancaria = new ContaBancaria();
//         contaBancaria.Titular = "Pedro Sampaio";
//         contaBancaria.Saldo = 300;
//         Console.WriteLine($"Titular: {contaBancaria.Titular}");
//         Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
//         contaBancaria.Depositar(100);
//       // Console.WriteLine($"Novo saldo após depósito: {contaBancaria.Depositar}");
//         contaBancaria.Sacar(300);
//        // Console.WriteLine($"Novo saldo após saque: {contaBancaria.Sacar}");
        
//        }


// MAIN COM MÉTODO COM RETORNO DE VALOR
// namespace Orientacao_objetos
// {
// class Orientacao_objetos
//     {
// class Program
//     {
//         static void Main()
//         {
//             Console.Clear();
//             ContaBancaria contaBancaria = new ContaBancaria();
//             contaBancaria.NomeTitular = "Pedro Sampaio";
//             contaBancaria.SaldoTitular = 200;

//             Console.WriteLine($"Titular: {contaBancaria.NomeTitular}");
//             Console.WriteLine($"Saldo: {contaBancaria.SaldoTitular}");

//             double valorDepositado = contaBancaria.DepositarValor(100);
//             Console.WriteLine($"Novo Saldo após depósito: {valorDepositado}");

//             double novoSaldo = contaBancaria.SacarValor(290);
//             Console.WriteLine($"Novo Saldo após saque: {contaBancaria.SaldoTitular}");
            
//         }
//     }
//    }
// }

namespace Orientacao_objetos
{
class Orientacao_objetos
    {
class Program
    {
        static void Main()
        {
            Console.Clear();
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Titular = "Moisés Lucas";
            contaBancaria.Saldo = 200;

            Console.WriteLine($"Titular: {contaBancaria.Titular}");
            Console.WriteLine($"Saldo: {contaBancaria.Saldo}");

            contaBancaria.Depositar(100);
            Console.WriteLine($"Novo Saldo após depósito: {contaBancaria.Saldo}");

             contaBancaria.Sacar(290);
            Console.WriteLine($"Novo Saldo após saque: {contaBancaria.Saldo}");
            
        }
    }
   }
}