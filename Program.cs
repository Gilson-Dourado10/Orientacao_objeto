using Orientacao_objetos;

PagarCartao pagarCartao = new PagarCartao(new DateTime(2024,2,13));
pagarCartao.Pagar();

PagamentoBoleto pagamentoBoleto = new PagamentoBoleto(new DateTime(2023,02,02));
pagamentoBoleto.NumeroBoleto = 123156465;
Console.WriteLine();