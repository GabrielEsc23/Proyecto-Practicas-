// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola Mundo");
        Console.WriteLine("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}!");
    }
}

