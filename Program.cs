//                      set private    

//  using Orientacao_objetos;
//  Console.Clear();
// Futebol jogo = new Futebol("Palmeiras");
// Console.WriteLine($"Time de futebol: {jogo.Time}");
// // tentando alterar o nome do time fora da clase, vai dar erro de compilaçao. 
// //jogo.Time = "Corithians";
// jogo.AlterarNomeTime("São Paulo");
// Console .WriteLine($"Novo time de futebol : {jogo.Time}");

//*****************************************************************************************************
//get private

// using Orientacao_objetos;
// Console.Clear();
// Futeboll futeboll = new Futeboll();
// futeboll.DefinirTime("Coritiba");
// Console.WriteLine($"Time de futebol: {futeboll.ObterTime()}");  
// var novoTime = futeboll.Time = "Santos";                 
// Console.WriteLine($"Time novo: {novoTime}");
// Console.WriteLine();
//*******************************************************************************************

//             //get private
// using Orientacao_objetos;
// Console.Clear();
// var football = new Football("Real Madrid");
// var timeInicioPartida = football.PegarTime();
// Console.WriteLine($"Time que inicia a partida: {timeInicioPartida}");
// var timeInicioPartida2 = football.Time = "Barcelona";
// Console.WriteLine($"Novo time que inicia a partida: {timeInicioPartida2}");
// Console.WriteLine();

//*****************************************************************************************
            // GET PRIVATE E  SET PRIVATE 

using Orientacao_objetos;
Console.Clear();
var minhaConta = new MinhaConta(2000);
minhaConta.ExtratoSaldo();
Console.WriteLine();
minhaConta.DepositMoney(100);
Console.WriteLine();
minhaConta.sacar(2100);
Console.WriteLine();
minhaConta.ExtratoSaldo();







