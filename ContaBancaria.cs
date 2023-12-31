using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;
        public double Depositar(double valor)
        {
           Console.WriteLine($"O valor depositado foi: {valor}"); 
            return valor;
        }
        public double Sacar(double valor)
        {
            if (Saldo < valor)
            {
             Console.WriteLine($"Saldo insuficiente para saque de valor: {valor}");   
            }
            return valor;  
        }
    }
}