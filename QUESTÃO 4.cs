using System;

class numero_palavras
{
    static void Main()
    {
        Console.WriteLine("Digite sua frase:");
        string a = Console.ReadLine();

        string[] palavras = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int num = palavras.Length;

        Console.WriteLine("Sua frase contém" + num + "palavras.");
    }
}
