using System;
public class programa1
{
    internal class program;
    static void Main(string[] args)
    {
        int contador = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("ingrese el numero " + i + ": ");
            int num = int .Parse(Console.ReadLine());
            if (num > 0) contador++;
            Console.WriteLine("cantidad de numeros positivos es: " + contador);

        }

    }
}
