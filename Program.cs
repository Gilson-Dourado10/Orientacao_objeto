
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
using Orientacao_objetos;
Console.Clear();
ContaPoupanca cp = new ContaPoupanca();
Console.WriteLine($"Saldo inicial da conta poupança: {cp.Saldo}");
cp.Depositar(300);
Console.WriteLine($"Saldo após deposito: {cp.Saldo}");
cp.Sacar(300);
Console.WriteLine($"Saldo após o saque: {cp.Saldo}");

