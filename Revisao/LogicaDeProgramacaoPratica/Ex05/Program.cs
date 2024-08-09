// See https://aka.ms/new-console-template for more information

static int ContaLetras(string texto, string letra)
{
    string remove = texto.Replace(letra, "");
    int qtdFinal = texto.Count() - remove.Count();

    return qtdFinal;
}

string[] letras = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];

Console.WriteLine("Escreve um texto:");
string txt = Console.ReadLine()!;


foreach (string l in letras)
{
    Console.WriteLine($"{l} - {ContaLetras(txt, l)}");
}

