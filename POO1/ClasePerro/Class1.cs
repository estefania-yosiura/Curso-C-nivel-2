using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePerro
{
     class Dog
    {  //miembros privaos
        private string nombre;
        private string color;
        private string origen;
        //setter y getter
        //primera forma
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        //segunda forma
        //color
        public void setColor (string c)
        {
            color = c;
        }
        public string GetColor()
        {
            return color;
        }
        //origen
        public void setOrigen (string o)
        { 
            origen = o;
        }
        public string getOrigen()
        {
            return origen;
        }
    }
}
