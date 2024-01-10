using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class Veiculo
    {
        public string modelo { get; set; }
        public string cor { get; set; }
        public void Ligar()
        {
            Console.WriteLine("carro ligado");
        }

    }
}