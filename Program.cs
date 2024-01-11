
/*
Exercício Médio - Herança:

Considere uma hierarquia de classes para representar veículos. 
A classe base é Veiculo,
 e as subclasses incluem Carro e Moto. 
 Cada veículo tem propriedades como modelo, cor e método para ligar.
*/
using System;
using Orientacao_objetos;

Carro carro = new Carro { modelo = "BMW", cor = "PRETO", numeroPortas = 4 } ;
Moto moto = new Moto {modelo = " KAVASAKIN" , cor= " AZUL", TempartidaEletrica = true };
moto.Ligar();
Console.WriteLine("Modelo: "+moto.modelo);
Console.WriteLine("Cor: "+moto.cor);
Console.WriteLine("tem partida elétrica: "+moto.TempartidaEletrica);
carro.Ligar();
Console.WriteLine("Modelo: " + carro.modelo);
Console.WriteLine(" Cor: "+carro.cor);
Console.WriteLine("número portas: "+carro.numeroPortas);
