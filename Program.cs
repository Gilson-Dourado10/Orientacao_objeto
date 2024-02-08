using Orientacao_objetos;
Console.Clear();
var cachorro = new Cachorro();
string mensagemCachorro1 = cachorro.Andar("Mell");
Console.WriteLine($"(1°)  {mensagemCachorro1}");

Console.WriteLine();

DateTime dataNascimentoCachorro2 = new DateTime(2011,3,25);
string mensagemCachorro2 = cachorro.Andar("Rex", dataNascimentoCachorro2);
Console.WriteLine($"(2°)  {mensagemCachorro2}");

Console.WriteLine();

DateTime dataNascimentoCachorro3 = new DateTime(2015,05,05);
string mensagemCachorro3 = cachorro.Andar("Sonolento" ,dataNascimentoCachorro3, raca:"Viralata");
Console.WriteLine($"(3°)  {mensagemCachorro3}");
