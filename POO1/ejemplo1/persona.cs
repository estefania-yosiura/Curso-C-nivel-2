using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class persona
    {
        //persona: sueldo, edad, nombre
        //ATRIBUTOS O MIEMBROS:
        private int edad;
        private float sueldo;       //segun el encapsulamiento, los miembros no deben ser accedidos desde el exterior DIRECTAMENTE.
        private string nombre;   //los atributos, por defecto tienen el modificador de visibilidad "internal".
                                 //para acceder a los miembros privados se usan las funciones que permitan escribir en la variable
        public void setEdad (int e)
        {
          edad = e; //para recibir el valor desde el exterior
        }
        public int getEdad() 
        { 
            return edad; //para poder leer el valor
        }

}
}  
