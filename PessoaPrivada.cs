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
            get => profissao;
            set => profissao = value;
        }
        public int Idade
        {
            get => idade;
            set => idade = value;
            
        }
        private string ObterNomeCompleto()
        {
            return$" {nome}  {sobrenome}";
            
        }
        private void ExibirMensagemPrivada()
        {
            Console.WriteLine("Essa é uma mensagem privada");
            
        }
        public void ExibirInformacoes()
        {
            string nomeCompleto = ObterNomeCompleto();
            ExibirMensagemPrivada();
            Console.WriteLine($"Nome completo: {nomeCompleto}");
            Console.WriteLine($"Profissão: {Profissao}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }

}