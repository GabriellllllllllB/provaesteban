using System;

class notas
{
    static void Main()
    {
        Console.WriteLine("Digite um valor INTEIRO:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num);
        
        int n100 = num/100;
        num = num % 100;
        int n50 = num/50;
        num = num % 50;
        int n20 = num/20;
        num = num % 20;
        int n10 = num/10;
        num = num % 10;
        int n5 = num/5;
        num = num % 5;
        int n2 = num/2;
        num = num % 2;
        int n1 = num/1;
        num = num % 1;
        
        Console.WriteLine(n100 + "notas de 100");
        Console.WriteLine(n50 + "notas de 50");
        Console.WriteLine(n20 + "notas de 20");
        Console.WriteLine(n10 + "notas de 10");
        Console.WriteLine(n5 + "notas de 5");
        Console.WriteLine(n2 + "notas de 2");
        Console.WriteLine(n1 + "notas de 1");
    }
}
