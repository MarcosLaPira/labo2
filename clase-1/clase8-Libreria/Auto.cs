using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Libreria
{
    public class Auto:VehiculoTerrrestre
    {
       
        private short cantidadMarchas;
        private int cantidadpasajeros;

        public Auto(short cantidadRuedas, short cantidadPuertas, colores color)
            :base(cantidadRuedas, cantidadPuertas, color)
        {
           
        }
        public Auto(short cantidadRuedas, short cantidadPuertas, colores color, short cantidadMarchas, int cantidadpasajeros)
            :this(cantidadRuedas, cantidadPuertas, color)
        {         
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadpasajeros = cantidadpasajeros;
        }
    }
}
