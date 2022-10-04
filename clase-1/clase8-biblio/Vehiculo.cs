using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace clase8_biblio
{
    public abstract class Vehiculo
    {
        private string patente;
        protected byte ruedas;
        private EMarcas marca;


        protected Vehiculo(string patente, byte ruedas, EMarcas marca)
        {
            this.patente = patente;
            this.ruedas = ruedas;
            this.marca = marca;
        }
        protected string Patente 
        { 
            get { return patente; }
           
        }
        protected EMarcas Marca 
        {
            get { return marca; }
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.patente);
            sb.AppendLine(this.marca.ToString());
            sb.Append(this.ruedas);

            return sb.ToString();
        }

        public static bool operator == ( Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (v1.patente == v2.patente)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2); 
        }


       
        
         //traigo cualquier objeto y solo cuando sea algo de tipo casteo o derivado lo comparo
         
         public override bool Equals(object obj)
         {
           
            bool retorno = false;

            if (obj is not null)
            {
                if (obj is Vehiculo)
                {
                    if (this == ((Vehiculo)obj))
                    {
                        retorno = true;
                    }
                }
            }
            
             return retorno;
         }
         
        //retorna un valor entero 
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
         */
        public override string ToString()
        {
            return this.Mostrar();
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
          
              return string.Compare(v1.patente,v2.patente);
        }

        public static int OrdenarPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Marca.CompareTo(v2.marca));
        }
      
        /* Lavadero.Vehiculos.sort(Lavadero.OrdenarVehiculosPorPatente) */
   
    }
}
