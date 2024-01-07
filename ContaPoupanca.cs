using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class ContaPoupanca
    {
        private double saldo;
        public double Saldo
        {
            get => saldo;
            private set  => saldo = value;
        }
        // get { return saldo; }
        // private set { saldo = value; } 
    }
    public void Depositar(double valor)
    {
        Saldo += valor;
    }
    public void Sacar(double valor)
    {
        if (valor <= Saldo )
        {
            Saldo -= valor;
            Console.WriteLine($"O saque de de valor: R$ {valor} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente para o saque de valor R${valor}");
        }
    }
}