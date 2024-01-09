          
// HERANÇA

namespace Orientacao_objetos
{
    class Program
    {
        static void Main()
        {
            Gato gato = new Gato();
            gato.Nome = "Xanuca";
            Console.WriteLine($"Nome do gato: {gato.Nome}");
            gato.EmitirSom();
            gato.Miar();
        }
    }
}