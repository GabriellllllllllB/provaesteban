using System;

class data
{
    static void Main()
    {
        Console.WriteLine("Digite a sua primeira data:");
        DateTime d1 = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a sua segunda data:");
        DateTime d2 = DateTime.Parse(Console.ReadLine());
        
        int diferenca = (d1 - d2).Days;

        Console.WriteLine(diferenca);
    }
}
