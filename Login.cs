using System;

public class Login
{
    public static void Ejecutar()
    {
        string user = "Nicolas";
        string password = "12345";

        while (true)
        {
            Console.WriteLine("LOGIN");
            Console.Write("USUARIO: ");
            string usuario = Console.ReadLine() ?? "";
            Console.Write("CONTRASEÑA: ");
            string contrasenia = Console.ReadLine() ?? "";

            if (usuario == user && contrasenia == password)
            {
                /*datos.Mostrar();
                break;*/
                Console.WriteLine("-----Ingreso exitoso-----");
                break;
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos. Intente de nuevo.\n");
            }
        }
    }
}
