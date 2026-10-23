using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa la posicion: ");

        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0 && n <= 40)
        {
            long resultado = Fibonacci(n);
            Console.WriteLine($"El término {n} de la secuencia de Fibonacci es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número entero válido entre 0 y 40.");
        }
    }

    // Función recursiva para calcular el n-ésimo término de Fibonacci
    static long Fibonacci(int n)
    {

        if (n == 0) return 0;
        if (n == 1) return 1;


        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}