// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nDigite um número inteiro:");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("");
Console.ForegroundColor = num % 2 == 0 ? ConsoleColor.DarkRed : ConsoleColor.DarkBlue;
Console.WriteLine(num % 2 == 0 ? "O número é PAR" : "O número é IMPAR");
Console.WriteLine("");
Console.ResetColor();