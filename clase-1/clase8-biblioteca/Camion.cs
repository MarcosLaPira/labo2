using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_biblioteca
{
    public sealed class Camion:VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
       EColores color;
        short cantidadMarchas;
        int pesoCarga;


        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color)
            :base(cantidadRuedas,cantidadPuertas,color)
        {
           
        }

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int pesoCarga) 
            : this( cantidadRuedas, cantidadPuertas, color)
        {           
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
