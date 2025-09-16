using System;
using System.Collections;
using System.IO;

public class archivos
{
    public static void Ejecutar()
    {
        File.WriteAllText("Datos.txt", string.Empty);
        Console.WriteLine("Ingrese la cantidad de estudiantes a registrar: ");
        int cantidad = int.Parse(Console.ReadLine());
        File.AppendAllText("Datos.txt",$"Item  |"+ $"Nombre    |" + $"Apellido     |" + $"Edad     \n");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            File.AppendAllText("Datos.txt",$"{i+1}       "+$"{nombre}    "+$"{apellido}      "+$"{edad}     \n");
            
        }
    }
}