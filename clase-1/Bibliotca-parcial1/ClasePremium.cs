using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public class ClasePremium : ClaseAViajar
    {
        static int cantMaxValija;
        static int cantMaxBolsoMano;
        static float maxKgValija;
        private float kgValija2;

        static ClasePremium()
        {
            cantMaxValija = 2;
            cantMaxBolsoMano = 1;
            maxKgValija = 25;
        }
        public ClasePremium(EClasePasajero clase, int cantValija, int cantBolsoDeMano, float kgValija, float kgValija2) : base(clase, cantValija, cantBolsoDeMano, kgValija)
        {
            if (cantValija <= cantMaxValija && cantBolsoDeMano <= cantMaxBolsoMano && kgValija <= maxKgValija && kgValija2 <= maxKgValija)
            {
                this.kgValija2 = kgValija2;
            }

        }
    }
   

}
