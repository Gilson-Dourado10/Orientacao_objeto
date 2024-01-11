using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class Carro :  Veiculo
    {
        public int numeroPortas{ get; set; }  
        public override void Ligar()
        {
            Console.WriteLine("Carro ligado");
        }
    }
}