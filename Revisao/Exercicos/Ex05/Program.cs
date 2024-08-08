// See https://aka.ms/new-console-template for more information

List<List<float>> listaNotas = [];

int numAlunos =  int.Parse(Console.ReadLine()!);

for (int i = 0; i < numAlunos; i++)
{
    Console.WriteLine("Disciplina 1");
    float disciplina1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Disciplina 2");
    float disciplina2 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Disciplina 3");
    float disciplina3 = float.Parse(Console.ReadLine()!);

    listaNotas.Add([disciplina1, disciplina2, disciplina3]);
}

foreach (var item in listaNotas)
{
    float media = 0;

    foreach (var a in item)
    {
        media += a;
    }

    Console.WriteLine($"A média do aluno é: {media / 3}");
    Console.WriteLine(media / 3 > 7 ? "Status: Aprovado" : "Status: Reprovado");
}
