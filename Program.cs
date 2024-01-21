using Orientacao_objetos;
Console.Clear();

List<MembroUniversidades> membroUniversidades = new List<MembroUniversidades>();
membroUniversidades.Add(new Professor {Nome = "Marco Castro" , Disciplina = "Orientação Objetos" , DataProvaFinalDisciplina = new DateTime(2024,1, 25, 19, 30, 0)}); 
membroUniversidades.Add(new Aluno {Nome = "Felipe Ricardo" , Curso = "Análise e Desenvolvimento de sistemas"});
membroUniversidades.Add(new Professor {Nome = "Adão Santos" , Disciplina = "Power BI"});
membroUniversidades.Add(new Aluno {Nome = "João Pedro" , Curso = "Sistema para Internet"});

foreach (var membro in membroUniversidades )
{
 membro.ExibirInfo();   
}

