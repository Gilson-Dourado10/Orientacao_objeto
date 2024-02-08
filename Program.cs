using Orientacao_objetos;
Console.Clear();
var cachorro = new Cachorro();
string mensagemCachorro1 = cachorro.Andar("Mell");
Console.WriteLine($"(1°)  {mensagemCachorro1}");

Console.WriteLine();

DateTime dataNascimentoCachorro = new DateTime(2019,3,25);
string mensagemCachorro2 = cachorro.Andar("Rex", dataNascimentoCachorro);
Console.WriteLine($"(2°)  {mensagemCachorro2}");

Console.WriteLine();

DateTime dataNascimentoCachorro3 = new DateTime(2015,05,05);
