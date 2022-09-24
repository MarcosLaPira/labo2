using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_biblioteca
{
    public abstract class VehiculoTerrestre
    {
        short cantidadRuedas;
       short cantidadPuertas;
        EColores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

       
    }
}
