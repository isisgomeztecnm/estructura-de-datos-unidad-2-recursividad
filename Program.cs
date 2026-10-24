using System;
class program
{
    static void CuentaA(int n)
    {
        if (n < 0)
            return;
        Console.WriteLine("A:" + n);
        CuentaB(n - 1);
    }
    static void CuentaB(int n)
    {
        if (n < 0)
            return;
        Console.WriteLine("B:" + n);
        CuentaA(n - 1);
    }
    static void Main()
    {
        Console.Write("ingresa el numero inicial:");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingresa un numero entre 0 y 1000");
            return;
        }
        CuentaA(n);
    }
}
