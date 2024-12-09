using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //botella: capacidad, color, material
        private int capacidad;
        private string color;
        private string material;
        
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
