using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU DE FIGURAS =====");
            Console.WriteLine("1. Cuadrado hueco");
            Console.WriteLine("2. Triangulo rectangulo invertido");
            Console.WriteLine("3. Piramide centrada");
            Console.WriteLine("4.Rombo");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                
                    Console.WriteLine("\nCuadrado hueco:");

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == 0 || i == 4 ||
                                j == 0 || j == 4)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
  
                    Console.WriteLine("\nTriangulo invertido:");

                    for (int i = 5; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
     
                    Console.WriteLine("\nPiramide centrada:");

                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 0; j < 5 - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < 2 * i - 1; k++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                
  
                    break;
                case 4:
                    Console.WriteLine("\nRombo:");

                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 0; j < 5 - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < 2 * i - 1; k++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

                    for (int i = 4; i >= 1; i--)
                    {
                        for (int j = 0; j < 5 - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < 2 * i - 1; k++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                case 5:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opcion no valida. Intenta de nuevo.");
                            break;
                        }

        } while (opcion != 4);
    }
}