// using Orientacao_objetos;

// Console.Clear();
// var minhaPropriedade = new MinhaPropriedade();
// minhaPropriedade.MyProperty = 40;
// Console.WriteLine($" O valor da propriedade : {minhaPropriedade.MyProperty}");

//******************************************************************************************

using Orientacao_objetos;

Console.Clear();
var minhaPropriedade = new MinhaPropriedade(45);
var primeiroValor = minhaPropriedade.MyProperty;
Console.WriteLine($"Primeiro valor da propriedade: {primeiroValor}");
Console.WriteLine();
minhaPropriedade.AlterarValorDaPropriedade(50);
var segundoValor = minhaPropriedade.MyProperty;
Console.WriteLine($"Segundo valor da propriedade: {segundoValor}");


//************************************************************************************************











// MinhaPropriedad minhaPropriedad = new MinhaPropriedad();
// minhaPropriedad.ValorCestaBasica = 300;
// int precoCestaBasica = minhaPropriedad.ValorCestaBasica;
// Console.WriteLine($"Preço Cesta básica R$: {precoCestaBasica} reais ");
// Console.WriteLine();
//***********************************************************************************