using System;
using System.Collections.Generic;

public class opcion2
{
    public static void Ejecutar()
    {
        Console.WriteLine("Calculadora");
        List<string> operaciones = new List<string> { "Suma", "Resta", "Multiplicacion", "Division" };
        for (int i = 0; i < operaciones.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {operaciones[i]}");
        }

        Console.Write("Seleccione una opción (1-4): ");
        if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion >= 1 && seleccion <= operaciones.Count)
        {
            string operacionElegida = operaciones[seleccion - 1];
            Console.WriteLine($"Seleccionaste: {operacionElegida}");

            if (seleccion == 1)
            {
                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Número inválido.");
                    return;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Número inválido.");
                    return;
                }

                double resultado = num1 + num2;
                Console.WriteLine($"Resultado de la suma: {resultado}");
            }
            else if (seleccion == 2) 
            {
                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Número inválido.");
                    return;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Número inválido.");
                    return;
                }

                double resultado = num1 - num2;
                Console.WriteLine($"Resultado de la resta: {resultado}");
            }
            else if (seleccion == 3) 
            {
                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Número inválido.");
                    return;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Número inválido.");
                    return;
                }

                double resultado = num1 * num2;
                Console.WriteLine($"Resultado de la multiplicación: {resultado}");
            }
            else if (seleccion == 4) 
            {
                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Número inválido.");
                    return;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2) || num2 == 0)
                {
                    Console.WriteLine("Número inválido o división por cero.");
                    return;
                }

                double resultado = num1 / num2;
                Console.WriteLine($"Resultado de la división: {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
}
