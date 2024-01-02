// using System;
// namespace Orientacao_objetos
// {
//     public class ContaBancaria
//     {
//         public string Titular;
//         public double Saldo;
//         public void Sacar(double valor)
//         {
//             if (Saldo >= valor)
//             {
//                 Saldo -= valor;
//                 Console.WriteLine($"saque realizado sucesso no valor: {valor}");
//             }
//             else
//             {
//                 Console.WriteLine($"saldo insuficiente para o saque no valor: {valor}");
//             }
//         }
//         public void Depositar(double valor)
//         {
//             Saldo += valor;
//             Console.WriteLine($"O valor depósitado é: {valor} ");
//         }
//     }
// }



// using System;

// namespace Orientacao_objetos
// {
//     public class ContaBancaria
//     {
//         public string Titular;
//         public double Saldo;

using System;
namespace Orientacao_objetos
{
    class ContaBancaria
    {
        public string NomeTitular;
        public double SaldoTitular;

        public double DepositarValor(double valor)
        {
            SaldoTitular += valor;
            Console.WriteLine($"Depósito na conta de {NomeTitular} no valor de: {valor}");
            return SaldoTitular;
        }
    }
}