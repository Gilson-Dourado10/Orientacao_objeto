using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    public class PessoaPrivada
    {
        private string nome;
        private string sobrenome;
        private string profissao;
        private int idade;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Sobrenome
        {
            get => sobrenome;
            set => sobrenome = value;
        }
        public string Profissao
        {
            get => sobrenome;
            set => sobrenome = value;
        }
        public int Idade
        {
            get => idade;
            set => idade = value;
        }
    
    }
}