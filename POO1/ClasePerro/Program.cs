using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePerro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog p1 = new Dog();
            Console.WriteLine("como se llama tu peggo?");
            p1.Nombre = Console.ReadLine();
            Console.WriteLine("de q color es?");
            p1.setColor(Console.ReadLine());
            Console.WriteLine("de q origen es el peggito?");
            p1.setOrigen(Console.ReadLine());
            Console.WriteLine("con la informacion que me diste, puedo decirte con certeza que:");
            Console.WriteLine("tu perro se llama " + p1.Nombre);
            Console.WriteLine("tu perro es de color " + p1.GetColor());
            Console.WriteLine("y que viene de " + p1.getOrigen());
            Console.WriteLine("ahora que se todo de tu perro, lo voy a secuestrar >:)");
            Console.ReadLine();
        }
    }
}
