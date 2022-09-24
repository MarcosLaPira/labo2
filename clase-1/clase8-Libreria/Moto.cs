using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Libreria
{
    public class Moto:VehiculoTerrrestre
    {
           
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, colores color)
            :base(cantidadRuedas,cantidadPuertas,color)
        {
            
        }
        public Moto(short cantidadRuedas, short cantidadPuertas, colores color, short cilindrada)
            :this(cantidadRuedas, cantidadPuertas, color)
        {
           
            this.cilindrada = cilindrada;
        }
    }
}
