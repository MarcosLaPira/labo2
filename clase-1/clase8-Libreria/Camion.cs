using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Libreria
{
    public class Camion:VehiculoTerrrestre
    {
      
        private short cantidadMarchas;
        private int PesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, colores color)
             : base(cantidadRuedas, cantidadPuertas, color)
        {
          
        }  
        public Camion(short cantidadRuedas, short cantidadPuertas, colores color, short cantidadMarchas, int pesoCarga)
             : this(cantidadRuedas, cantidadPuertas, color)
        {
          
            this.cantidadMarchas = cantidadMarchas;
            PesoCarga = pesoCarga;
        }
    }
}
