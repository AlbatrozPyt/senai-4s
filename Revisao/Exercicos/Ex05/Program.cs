// See https://aka.ms/new-console-template for more information

List<List<float>> listaNotas = [];
List<string> nomes = [];
int alunoAtual = 0;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nQuantos alunos você irá calcular a média ?");
int numAlunos = int.Parse(Console.ReadLine()!);

for (int i = 0; i < numAlunos; i++)
{
    try
    {
        Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("\nNome do aluno:");
        string nomeAluno = Console.ReadLine()!;
        Console.WriteLine("\nDisciplina 1:");
        float disciplina1 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("\nDisciplina 2:");
        float disciplina2 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("\nDisciplina 3:");
        float disciplina3 = float.Parse(Console.ReadLine()!);
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        nomes.Add(nomeAluno);
        listaNotas.Add([disciplina1, disciplina2, disciplina3]);
    }
    catch (System.Exception)
    {
        Console.WriteLine("Chapou");
    }

}

Console.ResetColor();
Console.Clear();

foreach (var item in listaNotas)
{
    float media = 0;
    float n = 1;

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine($"Nome do Aluno: {nomes[alunoAtual]}");

    foreach (var a in item)
    {
        Console.WriteLine($"{n}º Nota: {a}");
        media += a;
        n++;
    }

    Console.WriteLine($"A média do aluno é: {Math.Round(media / 3)}");
    Console.ForegroundColor = media / 3 > 7 ? ConsoleColor.Green : ConsoleColor.DarkRed;
    Console.WriteLine(media / 3 > 7 ? "Status: Aprovado" : "Status: Reprovado");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    alunoAtual++;
    Thread.Sleep(1000);
}
Console.ResetColor();
