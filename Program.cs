// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        LoginManager loginManager = new LoginManager();
        Console.WriteLine("Bienvenido al sistema de Login");

        Console.Write("Ingresa tu nombre de ususario: ");
        String usuario = Console.ReadLine();

        Console.Write("Ingresa tu contraseña: ");
        String contraseña = Console.ReadLine();

        if (loginManager.ValidarLogin(usuario, contraseña))
        {
            Console.WriteLine("Login exitoso");
        }
        else
        {
            Console.WriteLine("Error: Credenciales incorrectas");
        }

    }
}

