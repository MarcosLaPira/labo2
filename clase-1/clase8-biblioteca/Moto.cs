using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_biblioteca
{
    public sealed class Moto :VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        EColores color;
        short cilindrada;


        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color)
             : base(cantidadRuedas, cantidadPuertas, color)
        {
        }

        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color, short cilindrada)
             : this(cantidadRuedas, cantidadPuertas, color)
        {
           
            this.cilindrada = cilindrada;
        }
    }
}
