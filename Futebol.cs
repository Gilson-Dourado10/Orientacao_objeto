
            // set private 
// namespace Orientacao_objetos;

//     public class Futebol
//     {
//        public string Time {get; private set;  } 
//       // construtor da classe
//        public Futebol(string timeSerieA)
//        {
//             Time = timeSerieA;
//        }
//        // Método para alterar o  time série A
//        public string AlterarNomeTime(String novoTimeSerieA)
//        {
//            return  Time = novoTimeSerieA;
//        }
//     }
//************************************************************************************
namespace Orientacao_objetos;
public class Futeboll
{
    public string Time {private get ; set; }
    public void DefinirTime(string novoTime)
    {
        Time = novoTime;
    }
    public String ObterTime()
    {
        return Time;
    }
}