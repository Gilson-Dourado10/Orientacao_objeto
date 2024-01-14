
namespace Orientacao_objetos;

    public class Veiculo
    {
       private string _proprietario;
       public bool Motor = true;
       public bool Airbag = true; 
       public Veiculo(string proprietario)
      {
         _proprietario = proprietario;
      }
      public string Proprietario
    {
      // get { return _proprietario; }
      // set { _proprietario = value; }
      get => _proprietario;
      set => _proprietario = value;
    }
      public double Rodas()
      {
         return 4;
      }
    }
