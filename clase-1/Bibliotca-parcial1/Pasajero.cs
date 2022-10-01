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
       private EClasePasajero clase;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        private Pasajero(string nombre, string apellido,int edad) : base(nombre, apellido, edad)
        {
             this.nombre = "";
            this.apellido = "";
            pasaporte = new Pasaporte("", "", 0,"", DateTime.Today, DateTime.Today);
           
        }
        private Pasajero(string nombre, string apellido,int edad, Pasaporte pasaporte, EClasePasajero clase) : this(nombre, apellido, edad)
        {
            this.pasaporte = pasaporte;
            this.clase = clase;
        }
        #endregion CONSTRUCTORES

        #region PREPIEDADES
        public Pasaporte Pasaporte { get => pasaporte;  }
        public EClasePasajero Clase { get => clase;  }
        #endregion PREPIEDADES

        #region METODOS

        public static bool operator == (Pasajero p1, Pasajero p2)
        {
            bool retorno = false;
            if (p1 != null && p2 != null)
            {
                if (p1.pasaporte.Apellido == p2.pasaporte.Apellido && 
                    p1.pasaporte.FechaDeNacimiento == p2.pasaporte.FechaDeNacimiento)
                {
                     retorno = true;
                }
               
            }
            return retorno;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        #endregion METODOS
    }
}
