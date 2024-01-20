using Orientacao_objetos;
Console.Clear();
var pagamentoBoleto = new PagamentoBoleto();
pagamentoBoleto.Vencimento = DateTime.Now;
pagamentoBoleto.NumeroBoleto = "123.555-55-99999";

Console.WriteLine("****Pagamento Boleto****");
Console.WriteLine($"Número do Boleto: {pagamentoBoleto.NumeroBoleto}");
Console.WriteLine($"Vencimento Boleto: {pagamentoBoleto.Vencimento}");
pagamentoBoleto.Pagar();
//***************************************************************
var pagamentoCartaoCredito = new PagamentoCartaoCredito();
pagamentoCartaoCredito.NumeroCartao = "123.4566.589";
pagamentoCartaoCredito.Vencimento = DateTime.Now;
Console.WriteLine();
Console.WriteLine("***********pagamento Cartão crédito*********");
Console.WriteLine($"Número do Cartão crédito: {pagamentoCartaoCredito.NumeroCartao}");
Console.WriteLine($"Vencimento fatura cartão: {pagamentoBoleto.Vencimento}");
pagamentoCartaoCredito.Pagar();
//**************************************************
// var pagamentoPix = new PagamentoPix();
// pagamentoPix.ChavePix = "12335466fgrtyuuuu";
// pagamentoPix.Vencimento = DateTime.Now;
// Console.WriteLine();
// Console.WriteLine("***********Pagamento com Pix*********");
// Console.WriteLine($"Chave Pix: {pagamentoPix.ChavePix}");
// pagamentoPix.Pagar();
//*******************************************************
 Console.WriteLine();

var pagamentoPix = new PagamentoPix();
pagamentoPix.ChavePix = "12335466fgrtyuuuu";
pagamentoPix.Vencimento = DateTime.Now.AddDays(1);
Console.WriteLine("***********Pagamento com Pix*********");
Console.WriteLine($"Chave Pix: {pagamentoPix.ChavePix}");
Console.WriteLine($"Vencimento da chave pix:   {pagamentoPix}");
pagamentoPix.Pagar();





