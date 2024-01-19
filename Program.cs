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
Console.WriteLine($"Número do Cartão crédito: {pagamentoCartaoCredito.NumeroCartao }");
Console.WriteLine($"Vencimento fatura cartão: {pagamentoBoleto.Vencimento}");
pagamentoCartaoCredito.Pagar();


**************************************************




   
   