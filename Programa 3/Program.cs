using System;

namespace programa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.Read();
        }
    }
}