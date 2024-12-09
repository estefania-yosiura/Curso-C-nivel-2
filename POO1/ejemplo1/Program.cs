using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         persona p1 = new persona();
            p1.setEdad(20); //ahora la persona tiene 20 years old por llamar esta "funcion" (setEdad)
            Console.WriteLine("la edad es de" + p1.getEdad());
            Console.ReadKey();
        }
          
    }
}
