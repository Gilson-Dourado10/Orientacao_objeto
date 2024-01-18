namespace Orientacao_objetos;
    public class Onibus : Veiculo
    {
        public string NomeEmpresa{get; set; }
        public string Motorista{ get; set ; } 
        public Onibus(string proprietario) : base(proprietario)
        {}
        public int QuantidadePassageiro(int quantidade )
        {
            return quantidade;
        }
        public override double Rodas()
        {
            return base.Rodas() + 2;
        }
    }
