using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
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

=======
        Login.Ejecutar();
>>>>>>> 08bf4c1c28524e4f7dbe86b15392adb14e67cfd3
    }
}