using System;
using System.ComponentModel.DataAnnotations;
internal class program { 

    static void Main(string[] args)
    {
       
        string correoCorrecto = "jangelgamezjimenez@unicaribe.edu.co";
        string passCorrecta = "jg12345";

        string email = "";
        string pass = "";

        int intentos = 0;
        while (intentos < 3)
        {
            Console.WriteLine("Ingrese su correo: ");
            email = Console.ReadLine();
            
            Console.WriteLine("Ingrese su contraseña: ");
            pass = Console.ReadLine();

            if (email == correoCorrecto && pass == passCorrecta)
            {
                Console.WriteLine("Bienvenido a la platyaforma de Unicaribe");
                break;

            }else
            {
                intentos++;
                Console.WriteLine("Correo o contraseña incorrectos");
                Console.WriteLine("Intentos restantes : " + (3 - intentos));

            }
            if (intentos == 3)
            {
                Console.WriteLine("usuario bloqueado - comunicate con T.I UNICARIBE"); 
            }
        }
    }

}
