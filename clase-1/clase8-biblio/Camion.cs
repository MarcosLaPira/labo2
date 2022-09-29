using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_biblio
{
    public class Camion:Vehiculo
    {
        protected float tara;
        public Camion(string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {

        }
        public Camion(string patente, byte ruedas, EMarcas marca, float tara) : this(patente, ruedas, marca)
        {
            this.tara = tara;
        }
        public string MostrarCamion()
        {
           
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());//viene de la clase vehiculo, padre
            sb.AppendLine(this.tara.ToString());

            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarCamion();
        }

    }
}
