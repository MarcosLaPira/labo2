using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_ejercicio3_biblioCentralita
{
   

    public class Local : Llamada
    {
        #region ATRIBUTOS
        private float costo;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Local(float duracion, string nroDestino, string nroOrigen,float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        
        public Local(Llamada llamada,float costo):this(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen,costo)
        { 
         
        }
        
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// retorna el costo de la llamada local
        /// </summary>
        public float CostoLlamada
        {
            get { return CalcularCosto(); } 
        }

        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// calcula el costo de la llamada duracion * costo
        /// </summary>
        /// <returns> retorna el costo tipo float</returns>
        private float CalcularCosto()
        {
            float retorno;
            retorno = this.duracion * this.costo;

            return retorno;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine(this.CostoLlamada.ToString());

            return sb.ToString();
        }
        /*
        public override bool Equals(object obj)
        {
            return String.Equals(obj.GetType().Name.ToString(), eTipoLlamada.Local.ToString());
        }

        */
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion METODOS
    }



}
