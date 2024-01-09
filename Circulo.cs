

namespace Orientacao_objetos
{
    public class Circulo : FormaGeometrica
    {
       public double Raio {get;set;}
        public override double CalcularArea()
        {
            return Math.PI*Raio*Raio;
        }

    }
}