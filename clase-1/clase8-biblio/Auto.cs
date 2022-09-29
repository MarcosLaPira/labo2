using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_biblio
{
    public class Auto:Vehiculo
    {
        protected int cantidadDeAsientos;
        
              
        public Auto(string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {

        }
        public Auto(string patente, byte ruedas, EMarcas marca, int cantidadDeAsientos) :this(patente, ruedas, marca)
        {
            this.cantidadDeAsientos = cantidadDeAsientos;
        }
        public string MostrarAuto()
        {
            bool retorno = false;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());//viene de la clase vehiculo, padre
            sb.AppendLine(this.cantidadDeAsientos.ToString());

            return sb.ToString();
        }

      


    }
}
