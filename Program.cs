using Orientacao_objetos;
var pagamentoBoleto = new PagamentoBoleto();
pagamentoBoleto.Pagar();
pagamentoBoleto.Vencimento = DateTime.Now;
pagamentoBoleto.NumeroBoleto = "123";
//***************************************************************