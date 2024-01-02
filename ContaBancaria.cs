using System;
namespace Orientacao_objetos
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;
        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"saque realizado sucesso no valor: {valor}");
            }
            else
            {
                Console.WriteLine($"saldo insuficiente para o saque no valor: {valor}");
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor depósitado é: {valor} ");
        }
    }   
}    



// using System;

// namespace Orientacao_objetos
// {
//     public class ContaBancaria
//     {
//         public string Titular;
//         public double Saldo;

//         public double Depositar(double valor)
//         {
//             Saldo += valor;
//             Console.WriteLine($"Depósito de {valor} realizado com sucesso.");
//             return Saldo; // Retorna o novo saldo após o depósito
//         }

//         public void Sacar(double valor)
//         {
//             if (Saldo >= valor)
//             {
//                 Saldo -= valor;
//                 Console.WriteLine($"Saque de {valor} realizado com sucesso.");
//             }
//             else
//             {
//                 Console.WriteLine($"Saldo insuficiente para saque de {valor}.");
//             }
//         }
//     }

    
// }
