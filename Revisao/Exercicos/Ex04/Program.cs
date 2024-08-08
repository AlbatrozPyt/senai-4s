// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

int user = 0;
int IA = RandomNumberGenerator.GetInt32(1, 100);
int tentativas = 0;

do
{
    tentativas++;

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine("Escolha um número: ");
    user = int.Parse(Console.ReadLine()!);
    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.ResetColor();

    if (user != IA)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nErrou!!!");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(user > IA ? "O número é menor" : "O número é maior");
        Console.ResetColor();
    }

} while (user != IA);

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"\nAcertou!!!, total de tentativas {tentativas}\n");
Console.ResetColor();

