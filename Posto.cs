using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class Posto
    {
        private string Proprietario;
        private int ValorLitro = 2;
        private string Modelo;
        public int Tanque { get; set ; }
        public static int VeiculosAbastecidos{get; private set; }
    }
    public Posto(string proprietario)
    {
        Proprietario = proprietario;
    }
}