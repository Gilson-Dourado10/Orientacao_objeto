
using Orientacao_objetos;
    public class Veiculo
    {
       private string _proprietario;
       public bool Motor = true;
       public bool Airbag = true; 
       public Veiculo(string proprietario)
      {
         _proprietario = proprietario;
      }
      public double Rodas()
      {
         return 4;
      }
    }
