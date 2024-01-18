using Orientacao_objetos;
Console.Clear();
var pagamentoBoleto = new PagamentoBoleto();
pagamentoBoleto.Vencimento = DateTime.Now;
pagamentoBoleto.NumeroBoleto = "123.555-55-99999";

Console.WriteLine($"Número do Boleto: {pagamentoBoleto.NumeroBoleto}");
Console.WriteLine($"Vencimento Boleto: {pagamentoBoleto.Vencimento}");
Console.WriteLine("****Pagamento Boleto****");
pagamentoBoleto.Pagar();
//***************************************************************
Console.WriteLine();
