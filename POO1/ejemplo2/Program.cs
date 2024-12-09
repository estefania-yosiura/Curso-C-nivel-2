using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primer lote con 10 registros de productos, cada uno con
              //cod de articulo (3 digitos no correlativos)
              //precio
              //cod de marca (1 a 10)
              
            articulo [] articulos = new articulo[10];
             for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese el codigo de articulo");
                articulos[x].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el precio");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el codigo de marca (del 1 al 10)");
                articulos[x].CodArticulo = int.Parse(Console.ReadLine());
            }

           //segundo lote con ventas de la semana, contiene:
             //cod de articulo
             //cantidad
             //cod de cliente (1 al 100)
             Venta venta = new Venta();
            Console.WriteLine("ingrese los datos de la venta");
            Console.WriteLine("codigo de cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("codigo de articulo");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());

                //codigo

                Console.WriteLine("ingrese los datos de la venta");
                Console.WriteLine("codigo de cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
