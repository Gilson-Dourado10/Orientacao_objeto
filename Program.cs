 using Orientacao_objetos;
 Console.Clear();
Futebol jogo = new Futebol("Palmeiras");
Console.WriteLine($"Time de futebol: {jogo.Time}");
// tentando alterar o nome do time fora da clase, vai dar erro de compilaçao. 
//jogo.Time = "Corithians";
jogo.AlterarNomeTime("São Paulo");
Console .WriteLine($"Novo time de futebol : {jogo.Time}");









