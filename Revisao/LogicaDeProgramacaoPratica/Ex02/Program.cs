// See https://aka.ms/new-console-template for more information

String[] nomes = new string[5];

Console.WriteLine("");
for(int i = 0; i <= 4; i++)
{
    Console.WriteLine($"Digite o {i+1}º nome:");
    string nome = Console.ReadLine()!;

    nomes[i] = nome;
}

Array.Sort(nomes);

Console.WriteLine("");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}