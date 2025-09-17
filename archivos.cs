using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO;

public class archivos
{
    public static void Ejecutar()
    {
        File.WriteAllText("Datos.txt", string.Empty);
        Console.WriteLine("Ingrese la cantidad de estudiantes a registrar: ");
        int cantidad = int.Parse(Console.ReadLine());
        int[] calificacion = new int[cantidad];
        string[] estudiante = new string[cantidad];

        File.AppendAllText("Datos.txt", $"Item  |" + $"Estudiante        |" + $"Materia       |" + $"Calificacion      |"+$"Estado        \n");
        double suma = 0;

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Estudiante: ");
            estudiante[i] = Console.ReadLine() ?? "";
            Console.WriteLine("Materia: ");
            string materia = Console.ReadLine() ?? "";
            Console.WriteLine("Calificacion: ");
            calificacion[i] = int.Parse(Console.ReadLine() ?? "");
        
            string Estado=string.Empty;
        
            foreach (int nota in calificacion)
            {
                if (nota < 14)
                {
                    Estado = "Reprobado";
                   
                }
                else
                {
                    Estado = "Aprobado";
                    
                }
            }
            File.AppendAllText("Datos.txt", $"{i + 1}      " + $"{estudiante[i]}            " + $"{materia}              " + $"{calificacion[i]}          "+ $"{Estado}\n" );
            
        }

        Console.WriteLine("\nCalificaciones ingresadas:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Calificación de {estudiante[i]}: {calificacion[i]}");
        }
        for (int i = 0; i < cantidad; i++)
        {
            suma += calificacion[i];
        }

        int menor = calificacion[0];
        int mayor = calificacion[0];


        foreach (int nota in calificacion)
        {
            if (nota < menor)
            {
                menor = nota;
            }

        }
        foreach (int nota in calificacion)
        {
            if (nota > mayor)
            {
                mayor = nota;
            }

        }


        /*foreach (int nota in calificacion)
        {
            if (nota < 14)
            {
                File.AppendAllText("Datos.txt", $"Reprobado\n");
            }
            else
            {
                File.AppendAllText("Datos.txt", $"Aprobado \n");
            }
        }*/

        File.AppendAllText("Datos.txt", $"\nPromedio General: {suma / cantidad}\n");
        File.AppendAllText("Datos.txt", $"Calificacion mas alta: {mayor}\n");
        File.AppendAllText("Datos.txt", $"Calificacion mas baja: {menor}\n");
        




    }
}
