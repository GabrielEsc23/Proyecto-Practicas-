using System;
using System.IO;

public class archivos
{
    public static void Ejecutar()
    {
        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Apellido: ");
        string apellido = Console.ReadLine();
        Console.WriteLine("Edad: ");
        int edad = int.Parse(Console.ReadLine());
        File.WriteAllText("Datos.txt", $"Nombre: {nombre}\n"+ $"Apellido:{apellido}\n"+$"Edad: {edad}");
    }
}