using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyudaNoEntiendoNada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings by using a
            // collection initializer.
            List<string> salmons = ["chinook", "coho", "pink", "sockeye"];

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye

            // Remove an element from the list by specifying
            // the object.
            salmons.Remove("coho");


            // Iterate using the index:
            for (var index = 0; index < salmons.Count; index++)
            {
                Console.Write(salmons[index] + " ");
            }
            // Output: chinook pink sockeye

            // Add the removed element
            salmons.Add("coho");
            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook pink sockeye coho
        }
    }
}
