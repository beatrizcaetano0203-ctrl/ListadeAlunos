List<string> alunos = new List<string>();
alunos.Add("Ana Paula - A que Sumiu");
alunos.Add("Andre - Turbo");
alunos.Add("Luiz - O Turista");
alunos.Add("Alexandre - O Inteligente Misterioso");
alunos.Add("Caua - O Aprendiz Incansavel");
alunos.Add("Rafael - O Genio Silencioso");

IEnumerable<string> listaAlunos = alunos;

foreach (string aluno in listaAlunos)
{
    Console.WriteLine(aluno);
}

alunos.Remove("Ana Paula - A que Sumiu");
Console.WriteLine("\nDepois de remover Ana Paula:");
Console.WriteLine("Quantidade: " + alunos.Count);


alunos.RemoveAt(0);
Console.WriteLine("\nDepois de remover o aluno da posicao 0:");
Console.WriteLine("Quantidade: " + alunos.Count);

alunos.Insert(0, "Novo Aluno");
Console.WriteLine("\nDepois de inserir um novo aluno:");
foreach (string aluno in alunos)
{
    Console.WriteLine(aluno);
}

alunos.Clear();
Console.WriteLine("\nDepois do Clear:");
Console.WriteLine("Quantidade de alunos: " + alunos.Count);

Console.WriteLine("\nAndre esta na lista? " +
    alunos.Contains("Andre - Turbo"));


Console.WriteLine("Posicao do Luiz: " +
    alunos.IndexOf("Luiz - O Turista"));

alunos.Sort();
Console.WriteLine("\nLista em ordem alfabetica:");
foreach (string aluno in alunos)
{
    Console.WriteLine(aluno);
}

alunos.Reverse();
Console.WriteLine("\nLista em ordem inversa:");
foreach (string aluno in alunos)
{
    Console.WriteLine(aluno);
}

Console.WriteLine("Primeiro aluno: " + alunos[0]);
Console.WriteLine("Quantidade de alunos: " + alunos.Count);

