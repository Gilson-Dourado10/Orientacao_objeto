
//using Orientacao_objetos;
// Pessoa p1 = new Pessoa();
// p1.NomeCompleto = "Apóstolo Paulo de tarso";
// p1.Idade = 38;
// p1.Profissao = "Programador jr C#";
// Console.WriteLine($"Nome completo: {p1.NomeCompleto}");
// Console.WriteLine($"Idade: {p1.Idade}");
// Console.WriteLine($"Profissão : {p1.Profissao}");

//************************************************************************
// using Orientacao_objetos;
// Console.Clear();
// PessoaPrivada pessoaPrivada = new PessoaPrivada();
// pessoaPrivada.Nome= "Geraldo";
// pessoaPrivada.Sobrenome= "Dos Santos";
// pessoaPrivada.Profissao = "Gerente de software";
// pessoaPrivada.Idade = 38;
// pessoaPrivada.ExibirInformacoes();
//****************************************************************************************
// using Orientacao_objetos;
//  class Program
// {
//     static void Main()
//     {
//         Console.Clear();
//         // Criando uma instância da classe ContaBancaria
//         ContaBancaria conta = new ContaBancaria();

//         // Exibindo saldo inicial
//         Console.WriteLine($"Saldo Inicial: {conta.Saldo}");

//         // Realizando depósito
//         conta.Depositar(1000);

//         // Exibindo saldo após depósito
//         Console.WriteLine($"Saldo após Depósito: {conta.Saldo}");

//         // Realizando saque
//         conta.Sacar(500);

//         // Exibindo saldo após saque
//         Console.WriteLine($"Saldo após Saque: {conta.Saldo}");

//         // Aguarda a entrada do usuário antes de fechar a aplicação
//         Console.ReadLine();
//     }
// }

//*******************************************************************************************************************************************
// using Orientacao_objetos;
// Console.Clear();
// ContaPoupanca cp = new ContaPoupanca();
// Console.WriteLine($"Saldo inicial da conta poupança: {cp.Saldo}");
// cp.Depositar(300);
// Console.WriteLine($"Saldo após deposito: {cp.Saldo}");
// cp.Sacar(310);
// Console.WriteLine($"Saldo após o saque: {cp.Saldo}");

//*************************************************************************************
/*
Suponha que você esteja desenvolvendo um sistema para gerenciar 
informações sobre estudantes em uma escola. Crie uma 
classe Estudante com os seguintes requisitos:

A classe deve ter atributos privados para o nome do estudante, a idade e a nota média.
Utilize métodos get e set para encapsular o acesso a esses atributos.
Crie um método público chamado ExibirInformacoes que exibe o nome, 
a idade e a nota média do estudante.
Implemente validações nos métodos set para garantir que a idade seja um valor
 não negativo e que a nota média esteja no intervalo de 0 a 10.
*/
using Orientacao_objetos;
Console.Clear();
Estudante estudante = new Estudante();
estudante.Nome = "João pedro";
estudante.Idade = 38;
estudante.NotaMedia = 7;
estudante.ExibirInformacoes();