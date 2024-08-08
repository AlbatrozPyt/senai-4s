// See https://aka.ms/new-console-template for more information

int n = 1;
int somaPar = 0;

while(n <= 100) {
    if (n % 2 == 0) {
        somaPar += n;
    } 

    n++;
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine($"\n\tA soma dos pares de 1 a 100 é igual a {somaPar}\n");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.ForegroundColor = ConsoleColor.White;
