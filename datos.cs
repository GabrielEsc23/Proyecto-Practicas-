using System;

public class datos
{
    public static void Mostrar()
    {
        Console.WriteLine("¡Bienvenido al menú principal!");

        while (true)
        {
            Console.WriteLine("\nSeleccione la acción que desea realizar:");
            Console.WriteLine("1. Opción 1");
            Console.WriteLine("2. Opción 2");
            Console.WriteLine("0. Salir");

            // Leer y validar entrada
            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Opción inválida. Debe ingresar un número.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    opcion1.Ejecutar();
                    return;
                case 2:
                    Console.WriteLine("Opción 2 seleccionada.");
                    return;
                case 0:
                    Console.WriteLine("Saliendo del menú...");
                    return; // Finaliza el método Mostrar()
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
