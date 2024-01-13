
using Orientacao_objetos;
Console.Clear();
Posto carro1 = new Posto("Geraldo");
carro1.Modelo = "Corsa hatch";
carro1.Tanque = 45;
carro1.Abastecer(90); 
Console.WriteLine("Litros de combustível: "+ carro1.Tanque);

Posto carro2 = new Posto("Antônio");
carro2.Modelo = "Celta";
carro2.Tanque = 40;
carro2.Abastecer(20);
Console.WriteLine("Litros combustível: "+ carro2.Tanque);

Console.Write("quantidades veículos abastecidos: ");
Console.WriteLine(Posto.VeiculosAbastecidos);