


namespace Orientacao_objetos;

    public class Carreta : Veiculo
    {
      public Carreta(string proprietario) : base(proprietario){}
      
       public bool Carroceria = true;
       public override double Rodas()
       {
            return base.Rodas() + 4;
       }
    }
