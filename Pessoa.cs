namespace Orientacao_objetos
{
    class Pessoa
    {
        private string nomeCompleto;
        public string NomeCompleto
        {
            get => nomeCompleto;
            set=> nomeCompleto = value;
        }
        public string Profissão {get;set;}
        public int Idade {get;set;}
        

    }
}