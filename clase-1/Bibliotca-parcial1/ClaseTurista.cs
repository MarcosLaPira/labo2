using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{

    public class ClaseTurista : ClaseAViajar
    {

        static int cantMaxValija;
        static int cantMaxBolsoMano;
        static float maxKgValija;

        static ClaseTurista ()
        {
            cantMaxValija = 1;
            cantMaxBolsoMano = 1;
            maxKgValija = 25;
        }
       
        public ClaseTurista(EClasePasajero clase,int cantValija, int cantBolsoDeMano, float kgValija) : base( clase,cantValija, cantBolsoDeMano, kgValija)
        {
            if (cantValija <= cantMaxValija && cantBolsoDeMano <= cantMaxBolsoMano && kgValija <= maxKgValija)
            {
                
            }
           
        }
        

    }
    
}
