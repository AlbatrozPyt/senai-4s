// See https://aka.ms/new-console-template for more information

static int[] Tabuada(int n) {
    int[] res = new int[10];

    for (int i = 1; i <= 10; i++) {
        res[i-1] = n * i;
    }

    return res;
}

Console.WriteLine("Digite um número:");
int num = int.Parse(Console.ReadLine()!);

int[] tab = Tabuada(num);
int v = 1;

foreach (int item in tab)
{
    Console.WriteLine($"{num} x {v} = {item}");
    v++;
}
