// using Orientacao_objetos;

// Console.Clear();
// var minhaPropriedade = new MinhaPropriedade();
// minhaPropriedade.MyProperty = 40;
// Console.WriteLine($" O valor da propriedade : {minhaPropriedade.MyProperty}");

//******************************************************************************************

using Orientacao_objetos;

Console.Clear();
MinhaPropriedade minhaPropriedade = new MinhaPropriedade(45);
Console.WriteLine($"Primeiro valor da propriedade: {minhaPropriedade.MyProperty}");
Console.WriteLine();
//************************************************************************************************
MinhaPropriedad minhaPropriedad = new MinhaPropriedad();
minhaPropriedad.ValorCestaBasica = 300;
int precoCestaBasica = minhaPropriedad.ValorCestaBasica;
Console.WriteLine($"Preço Cesta básica R$: {precoCestaBasica} reais ");
Console.WriteLine();
//***********************************************************************************