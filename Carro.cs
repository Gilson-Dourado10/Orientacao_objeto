using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class Carro
    {
        public string Modelo;
        public string Cor;
        public int Ano;
        public bool EmMovimento;

        public void Ligar()
        {
            Console.WriteLine("Carro Ligado");
        }
        public void Desligar()
        {
            Console.WriteLine("Carro desligado");
        }
    }
}