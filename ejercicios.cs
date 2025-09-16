using System;
using System.ComponentModel;

public class ejercicios
{
    public static void Ejecutar()
    {
        int cantidad;
        while (true)
        {
            Console.WriteLine("Ingrese el tamaño de la lista:");
            string tamanio = Console.ReadLine() ?? "";
            if (int.TryParse(tamanio, out cantidad) && cantidad > 0)
            {
                break;
            }
            Console.WriteLine("Elija un tamaño positivo y mayor a 0.");
        }

        List<int> numeros = new List<int>();
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            string numero = Console.ReadLine() ?? "";
            if (int.TryParse(numero, out int num))
            {
                numeros.Add(num);
            }
        }
        Console.WriteLine("Elementos de la lista:");
        Console.WriteLine(String.Join(", ", numeros));

        // Ver si el numero es par o impar
        foreach (int cant in numeros)
        {
            if (cant % 2 == 0)
            {
                Console.WriteLine($"El número {cant} es par");
            }
            else {
                Console.WriteLine($"El número {cant} es impar");
            }
        }
    }
}