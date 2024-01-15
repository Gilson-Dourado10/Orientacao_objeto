using System;


namespace Orientacao_objetos;

    public class Carreta : Veiculo
    {
       public bool Carroceria = true;
       public override double Rodas()
       {
            return base.Rodas() + 4;
       }
    }
