
namespace Orientacao_objetos
{
    public class Estudante
    {
        private string nome;
      private int idade;
        private double notaMedia;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public int Idade
        {
            get { return idade; }
            set
            {
                if (idade >= 0)
                {
                    idade = value;
                }
                else
                {
                    Console.WriteLine("o valor da idade não deve ter valor negativo");
                }
            }
        }
        public double NotaMedia
        {
            get => notaMedia;
            set
            {
            if (notaMedia <= 0 && notaMedia >=10)
            {
               notaMedia = value;  
            }
            else
            {
                Console.WriteLine("a nota média deve estar no intervalo 0 a 10");
            }
            }
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Nota média: {notaMedia} ");
        }
    }
}