using System;
using System.Reflection.Metadata;
public class HelloWorld
{
    public static void Main(string[] args) {
        const string passCorrecta = "all hail";
        string clave;
    int intentosF = 0;
        do
        {
            Console.WriteLine("Ingrese la contraseña: ");
            clave = Console.ReadLine();
            if (clave != passCorrecta)
            {
                intentosF++;
                Console.WriteLine("Contraseña incorrecta intentelo de nuevo");
            }
                    } while (clave != passCorrecta);
        Console.WriteLine("\n Acceso consedido:");
        Console.WriteLine("intentos fallidos: {intentosF)");
        

}
}
