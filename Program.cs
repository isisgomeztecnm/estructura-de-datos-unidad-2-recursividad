using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número entero no negativo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            long resultado = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número entero mayor o igual a 0.");
        }
    }

    // Función recursiva para calcular el factorial
    static long Factorial(int n)
    {
        
        if (n == 0 || n == 1)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}