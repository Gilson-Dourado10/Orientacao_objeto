          
// HERANÇA

// namespace Orientacao_objetos
// {
//     class Program
//     {
//         static void Main()
//         {
//             Gato gato = new Gato();
//             gato.Nome = "Xanuca";
//             Console.WriteLine($"Nome do gato: {gato.Nome}");
//             gato.EmitirSom();
//             gato.Miar();
//         }
//     }
// }
//****************************************************************************
/*
Exercício
Exercício Fácil - Herança:

Considere uma hierarquia de classes para representar formas geométricas.
 A classe base é Forma, e as subclasses incluem Circulo e Quadrado.
 Cada forma tem uma propriedade de área.
*/
namespace Orientacao_objetos
{
    class FormasGeometricas
    {
        static void Main()
        {
            Console.Clear();
            Circulo circulo = new Circulo();
            circulo.Raio = 5;
            Quadrado quadrado = new Quadrado{Lado = 5};
            //quadrado.Lado = 4;
            Console.WriteLine($"Area do circulo: {quadrado.CalcularArea()}");
            Console.WriteLine($"Area do quadrado: {circulo.CalcularArea()}");
        }
    }
}