using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_ejercicio3_biblioCentralita
{
   
    public class Provincial : Llamada
    {
        #region ATRIBUTOS
        protected EFranja franja;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR

        public Provincial(float duracion, string nroDestino, string nroOrigen, EFranja miFranja) : base(duracion, nroDestino, nroOrigen)
        {
            this.franja = miFranja;
        }
        public Provincial(Llamada llamada,EFranja franja) : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, franja)
        {
          
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion PROPIEDADES


        #region METODOS

        /// <summary>
        /// calcula el costo de la llamada a travez de la franaja horaria por la duracion
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float retorno;
            float costoPorSegundo = 0;

            switch ((int) this.franja)
            {
                case 1:
                    costoPorSegundo = 0.99f;
                    break;
                case 2:
                    costoPorSegundo = 1.25f;
                    break;
                case 3:
                    costoPorSegundo = 0.66f;
                    break;
            }
            retorno = this.duracion * costoPorSegundo;
            return retorno;


        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada.ToString()}");
            sb.AppendLine($"Franja: {this.franja}");
            

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion METODOS
    }
}
