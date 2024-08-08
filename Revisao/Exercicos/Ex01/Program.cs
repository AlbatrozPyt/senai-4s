// See https://aka.ms/new-console-template for more information


Console.WriteLine("Insira uma nota:");
float nota = float.Parse(Console.ReadLine()!);

Console.WriteLine(nota < 5 ? "Reprovado" : "Aprovado");
