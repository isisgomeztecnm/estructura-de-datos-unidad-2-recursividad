using System;

class Program
{
    static int Suma(int n)
    {
        if (n <= 0)
            return 0;

        return n + Suma(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un número entre 0 y 10000.");
            return;
        }

        Console.WriteLine("La suma es: " + Suma(n));
    }
}