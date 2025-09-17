using System;

public class vocal
{
    public static void Ejecutar()
    {
        List<string> vocales = new List<string> { "a", "e", "i", "o", "u" };
        Console.WriteLine("Ingrese una letra: ");
        string letra = Console.ReadLine();
        foreach (string vocal in vocales)
        {
            continue;
        }
        if (vocales.Contains(letra))
            {
                Console.WriteLine("Vocal");
            }
            else
            {
                Console.WriteLine("Consonante");
            }
        ;

    }
}