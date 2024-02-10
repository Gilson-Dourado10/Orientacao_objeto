using Orientacao_objetos;
Console.Clear();
var cachorro = new Cachorro();
var donoAnimal = cachorro.DonoDoAnimal = "PetShop";
string mensagemCachorro1 = cachorro.Andar("Mell");
Console.WriteLine($" o dono do animal: {donoAnimal}");
Console.WriteLine($"(1°) {mensagemCachorro1}");

Console.WriteLine();

DateTime dataNascimentoCachorro2 = new DateTime(2011,3,25);
string mensagemCachorro2 = cachorro.Andar("Rex", dataNascimentoCachorro2);
Console.WriteLine($"(2°)  {mensagemCachorro2}");

Console.WriteLine();

// DateTime dataNascimentoCachorro3 = new DateTime(2015,05,05);
// string mensagemCachorro3 = cachorro.Andar("Soneca" ,dataNascimentoCachorro3, raca:"Poodle");
// Console.WriteLine($"(3°)  {mensagemCachorro3}");
// Console.WriteLine();

// Instanciando um objeto Cachorro
            // var cachorroo = new Cachorro();

            // Data de nascimento do cachorro
            DateTime dataNascimentoCachorro = new DateTime(2015, 5, 5);

            // Chamando o método Andar do cachorro
            string mensagemCachorro3 = cachorro.Andar("Soneca", dataNascimentoCachorro, raca: "Poodle");

            // Exibindo a mensagem no console
            Console.WriteLine($"(3°)  {mensagemCachorro3}");