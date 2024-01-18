using Orientacao_objetos;
Console.Clear();
var pagamentoBoleto = new PagamentoBoleto();
pagamentoBoleto.Pagar();
pagamentoBoleto.Vencimento = DateTime.Now;
pagamentoBoleto.NumeroBoleto = "123.555-55-99999";
Console.WriteLine("****Pagamento Boleleo****");
Console.WriteLine(pagamentoBoleto.NumeroBoleto);
Console.WriteLine(pagamentoBoleto.Vencimento);
Console.WriteLine(pagamentoBoleto.Pagar());

//***************************************************************