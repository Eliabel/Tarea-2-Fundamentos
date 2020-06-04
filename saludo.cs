using System;

namespace tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("¿Cual es tu nombre completo?");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hola " + nombre + " espero que tengas un lindo dia hoy.");
        }
    }
}
