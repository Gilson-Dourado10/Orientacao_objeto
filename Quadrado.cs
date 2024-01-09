
namespace Orientacao_objetos
{
    public class Quadrado : FormaGeometrica
    {
        public double Lado {get;set;}
        public override double CalcularArea()
        {
            return Lado * Lado;
        }

    }
}