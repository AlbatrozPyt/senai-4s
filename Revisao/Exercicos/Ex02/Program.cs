// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n\nDigite um número:");

int num = int.Parse(Console.ReadLine()!);

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\t--TABUADA--");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\t{num} x {i} = {num * i}");
    Thread.Sleep(350); 
}

Thread.Sleep(3000); 
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;