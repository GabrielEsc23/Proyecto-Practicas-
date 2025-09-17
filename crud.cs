using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class crud
{
    public static void Ejecutar()
    {
        List<Jugador> jugadores = new List<Jugador>();
        
        while (true)
        {
            Console.WriteLine("----Bienvenidos al Sistema de jugadores-----");
            Console.WriteLine("Elije la accion a realizar\n");
            Console.WriteLine($"1.- Ingresar un jugador\n" +
                              $"2.- Lista de jugadores\n" +
                              $"3.- Eliminar un jugador\n" +
                              $"4.- Actualizar un jugador\n" +
                              $"5.- Salir");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("----Ingrese un jugador nuevo----");
                    Console.WriteLine("Nombre: ");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Posicion: ");
                    String posicion = Console.ReadLine();
                    Console.WriteLine("# Camisa: ");
                    int camisa = int.Parse(Console.ReadLine());

                    Jugador nuevoJugador = new Jugador
                    {
                        Nombre = nombre,
                        Edad = edad,
                        Posicion = posicion,
                        Camisa = camisa
                    };
                    jugadores.Add(nuevoJugador);
                    Console.WriteLine("Jugador ingresado corrctamente");
                    Console.WriteLine($"=====================\n");

                    break;

                case 2:
                    Console.WriteLine("----Lista de Jugadores----\n");

                    foreach (Jugador j in jugadores)
                    {
                        Console.WriteLine($"Nombre: {j.Nombre}");
                        Console.WriteLine($"Edad: {j.Edad}");
                        Console.WriteLine($"Posicion: {j.Posicion}");
                        Console.WriteLine($"# Camiseta: {j.Camisa}");
                        Console.WriteLine($"=====================\n");

                    }
                    break;

                case 3:

                    Console.WriteLine($"----Eliminacion de jugadores----");
                    Console.WriteLine("Ingrese el nombre del jugador: ");
                    string nombrej = Console.ReadLine();
                    jugadores.RemoveAll(j => j.Nombre == nombrej);
                    Console.Write($"Ingrese el numero de camisa del jugador a eliminar: ");
                    int NumCamisa = int.Parse(Console.ReadLine());
                    jugadores.RemoveAll(j => j.Camisa == NumCamisa);
                    Console.WriteLine("Jugador eliminado correctamente");
                    break;

                case 4:
                    Console.WriteLine("----Editar informacion del jugador----");
                    Console.WriteLine("Ingresa el nombre del jugador: ");
                    string nombreE = Console.ReadLine();
                    Console.WriteLine("Ingresa el numero del jugador: ");
                    int num = int.Parse(Console.ReadLine());

                    Jugador jugadorE = jugadores.Find(j => j.Nombre == nombreE && j.Camisa==num);
                    
                    if (jugadorE != null )
                    {
                        Console.WriteLine("Ingrese el nuevo nombre: ");
                        string Nnombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la nueva edad: ");
                        int Nedad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese a nueva posicion: ");
                        string Nposicion = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo # camisa: ");
                        int Ncamisa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Jugador editado correctaente");

                        jugadorE.Nombre = Nnombre;
                        jugadorE.Edad = Nedad;
                        jugadorE.Posicion = Nposicion;
                        jugadorE.Camisa = Ncamisa;
                        Console.WriteLine("================================\n");

                    }
                    else
                    {
                        Console.WriteLine("----Jugador no encontrado----");
                    }


                    break;                  
            }
        
            if (opcion == 5)
            {
                Console.WriteLine("----HA SALIDO DEL SISTEMA----");
                break;
            }
        }
     
    }

}
public class Jugador
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Posicion { get; set; }
    public int Camisa { get; set; }
}