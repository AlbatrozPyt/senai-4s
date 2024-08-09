// See https://aka.ms/new-console-template for more information

int somarPar = 0;

Console.WriteLine("\nDigite 10 números, na mesma linha");
string nums = Console.ReadLine()!;

string[] array = nums.Split(' ');

for (int i = 0; i < array.Count(); i++)
{
    if (int.Parse(array[i]) % 2 == 0) {
        somarPar += int.Parse(array[i]);
    }
}

Console.WriteLine("");
Console.WriteLine($"A soma de todos os números pares é {somarPar}");