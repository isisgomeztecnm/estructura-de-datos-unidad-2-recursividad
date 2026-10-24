using System;
class program
{
    static void BinarioA(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }

        BinarioB(n / 2);
        Console.Write(n % 2);
    }
    static void BinarioB(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }
        BinarioA(n / 2);
        Console.Write(n % 2);
    }
    static void Main()
    {
        Console.Write("ingresa un numero entero");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("ingresa un numero negativo:");
            return;
        }
        Console.Write("binario: ");
        if (n == 0)
            Console.Write("0");
        else
            BinarioA(n);
        Console.WriteLine();
    }
}