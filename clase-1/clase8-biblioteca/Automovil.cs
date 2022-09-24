using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_biblioteca
{
    public sealed  class Automovil :VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        EColores  color;
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color)
             : base(cantidadRuedas, cantidadPuertas, color)
        {         
        }

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int cantidadPasajeros)
             : this(cantidadRuedas, cantidadPuertas, color)
        {
            
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
