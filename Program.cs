using Orientacao_objetos;

PagarCartao pagarCartao = new PagarCartao(new DateTime(2024,2,13));
pagarCartao.Pagar();

PagamentoBoleto pagamentoBoleto = new PagamentoBoleto(new DateTime(2023,02,02),1265498742552,"Manoel pereira");
pagamentoBoleto.NumeroBoleto = 123156465;
Console.WriteLine();

PagamentoBoleto pagamentoBoleto1 = new PagamentoBoleto(new DateTime(2024,06,01), 12654987422,"Manoel pereira");

pagamentoBoleto1.Pagar();
Console.WriteLine();
PagamentoDebito pagamentoDebito = new PagamentoDebito(new DateTime(2024,06,01), 89856487422,"pedro pereira");
var nomeCliente = pagamentoDebito.NomeCliente = "João";
var valorPago=  pagamentoDebito.ValorPago = 300;
Console.WriteLine($"nome cliente {nomeCliente }");
Console.WriteLine($"valor pago débito {valorPago}");
pagamentoDebito.Pagar();
Console.WriteLine();
PagamentoCheque pagamentoCheque = new PagamentoCheque();
var remetente = pagamentoCheque.Remetente = "Pedro Gonçalves";
Console.WriteLine($"remetente: {remetente}");
var valorMinimoCheque = pagamentoCheque.ValorMinimoCheque = 100.00m;
Console.WriteLine($"o valor mínimo de cheque a receber: {valorMinimoCheque}");




