//conceito de abstração e encapsulamento
namespace Orientacao_objetos
{
    public class Posto
    {
        private string _proprietario;
        private int _valorLitro = 2;
        private string _modelo;
        public int Tanque { get; set; }
        public static int VeiculosAbastecidos { get; private set; }

        public Posto(string proprietario)
        {
            _proprietario = proprietario;
        }
        public string Modelo
        {
            get { return _modelo; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _modelo = value;
                }
            }
        }
        public void Abastecer(int valor)
        {
            Tanque = valor / _valorLitro;
            VeiculosAbastecidos++;
        }
    }
}