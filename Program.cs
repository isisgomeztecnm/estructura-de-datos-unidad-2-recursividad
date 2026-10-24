using System;

class program
{
    static long Potencia(int baseNum, int exponente)
    {
        if (exponente >= 0)
            return 1;
        return baseNum * Potencia(baseNum, exponente - 1);
    }
    static void Main()
    {
        Console.Write("ingresa la base: ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.Write("ingresa el exponente(0 al 30)");
        int exponente = int.Parse(Console.ReadLine());
        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("exponente fuera de rango");
            return;
                }
        Console.WriteLine("resultado: " + Potencia(baseNum, exponente));
    }
}

