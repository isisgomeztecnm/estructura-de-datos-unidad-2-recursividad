using System;
class program
{
    static int SumarDigitos(int n)
    {
        if (n == 0)
            return 0;
        return n % 10 + SumarDigitos(n / 10);
    }
    static void Main()
    {
        Console.Write("ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("ingresa un numero positivo");
            return;
        }
        Console.WriteLine("suma de digitos: " + SumarDigitos(n));
    }
}