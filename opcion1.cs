using System;
using Microsoft.Win32.SafeHandles;

public class opcion1
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese sus datos personales");
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine() ?? "";
        Console.Write("Apellido: ");
        string apellido = Console.ReadLine() ?? "";
        Console.Write("Edad: ");
        string edad = Console.ReadLine() ?? "";
        Console.Write("Sus Datos son:\n");
        Console.WriteLine($"Nombre: {nombre}  Apellido: {apellido}  Edad: {edad}");
    }
}
