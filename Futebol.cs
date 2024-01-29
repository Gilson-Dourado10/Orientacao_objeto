

namespace Orientacao_objetos;

    public class Futebol
    {
       public string Time {get; private set;  } 
      // construtor da classe
       public Futebol(string timeSerieA)
       {
            Time = timeSerieA;
       }
       // Método para alterar o  time série A
       public string AlterarNomeTime(String novoTimeSerieA)
       {
           return  Time = novoTimeSerieA;
       }
    }
