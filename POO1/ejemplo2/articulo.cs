using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class articulo
    {
        //cod de articulo (3 digitos no correlativos)
        //precio
        //cod de marca (1 a 10)
        public int CodArticulo { get; set; }
        public float Precio { get; set; }
        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
