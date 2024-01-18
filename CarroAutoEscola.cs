
namespace Orientacao_objetos;


    public class CarroAutoEscola : Veiculo
    {
        public string Aluno{ get; private  set; }
        public CarroAutoEscola(string proprietario, string aluno) : base(proprietario)
        {
            Aluno = aluno;
        }
    }
