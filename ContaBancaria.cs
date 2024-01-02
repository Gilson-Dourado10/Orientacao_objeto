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
            Saldo =+ valor;
           Console.WriteLine($"O valor depósito de  {valor} realizado com sucesso."); 
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