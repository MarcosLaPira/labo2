using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public class Pasajero:Persona
    {
        #region ATRIBUTOS
        private Pasaporte pasaporte;
       // private ClaseAViajar claseAViajar;
        private EClasePasajero clase;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
             
        public Pasajero(string nombre, string apellido,int edad, Pasaporte pasaporte, EClasePasajero clase/*, ClaseAViajar claseAViajar*/) : base(nombre, apellido, edad)
        {
            this.pasaporte = pasaporte;
            this.clase = clase; 
           // this.claseAViajar = claseAViajar;
        }
        
        #endregion CONSTRUCTORES

        #region PROPIEDADES       
        /// <summary>
        /// retorrna tipo pasaporte un pasaporte
        /// </summary>
        public Pasaporte Pasaporte { get => pasaporte;  }    
        /// <summary>
        ///  retorna enum de clase de pasajero
        /// </summary>
        public EClasePasajero Clase { get => clase; }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Boleano verifica si pasajero 1 es igual al pasajero 2
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns> True si son iguales y false si son diferentes</returns>
        public static bool operator == (Pasajero p1, Pasajero p2)
        {
            bool retorno = false;
            if (p1 is not null && p2 is not null)
            {
                if (p1.pasaporte.Apellido == p2.pasaporte.Apellido && 
                    p1.pasaporte.FechaDeNacimiento == p2.pasaporte.FechaDeNacimiento)
                {
                     retorno = true;
                }
               
            }
            return retorno;
        }
        /// <summary>
        ///  Boleano verifica si pasajero 1 es igual al pasajero 2
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si son iguales y false si son diferentes</returns>
        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Pasajero)
            {
                return this == ((Pasajero)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion METODOS
    }
        
}
