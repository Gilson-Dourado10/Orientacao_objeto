// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Orientacao_objetos
// {
//     public class ContaPoupanca
//     {
//         private double saldo;
//         public double Saldo
//         {
//             get => saldo;
//             private set  => saldo = value;
        
//         // get { return saldo; }
//         // private set { saldo = value; } 
//         }
//         public void Depositar(double valor)
//         {
//             Saldo += valor;
//         }
//         public void Sacar(double valor)
//         {
//             if (valor <= Saldo)
//             {
//                 Saldo -= valor;
//             }
//             else
//             {
//                 Console.WriteLine($"Saldo insuficiente para o saque de valor {valor}");
//             }
//         }
//     }

// }

//**********************************************************************************************************
//     using System;

//     public class ContaBancaria
//     {
//         private double saldo;  // Atributo privado

//         public double Saldo   // Propriedade pública com encapsulamento
//         {
//             get { return saldo; }
//             private set { saldo = value; }
//         }

//         public void Depositar(double valor)
//         {
//             // Lógica de depósito com encapsulamento
//             Saldo += valor;
//         }

//         public void Sacar(double valor)
//         {
//             // Lógica de saque com encapsulamento
//             if (valor <= Saldo)
//                 Saldo -= valor;
//             else
//                 Console.WriteLine("Saldo insuficiente para saque.");
//         }
//     }

// }
//**********************************************************************************************************************************************