using System;
class program
{
    static long invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;
        return invertir(n / 10, resultado * 10 + n % 10);
    }
    static void Main()
    {
        Console.Write("ingresa un numero positivo: ");
        long n = long.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("el numero debe ser positivo");
            return;
        }
        Console.WriteLine("numero invertido: " + invertir(n));
    }
}