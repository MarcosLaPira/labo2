using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public class Empleado:Persona
    {
        #region ATRIBUTOS

        private string usuario;
        private string contrasena;
        List<Viaje> viajes;
        List<Persona> PasajerosList;

        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        /// <summary>
        /// constructor privado aolo invocable dentro de la clase Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        private Empleado(string nombre, string apellido,int edad):base(nombre,apellido, edad)
        {
            this.usuario = "";
            this.contrasena = "";
            PasajerosList = new List<Persona>();
            viajes = new List<Viaje>(); 
        }
        /// <summary>
        /// constructor publico, inicialliza un emleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <param name="PasajerosList"></param>
        public Empleado(string nombre, string apellido,int edad, string usuario, string contrasena ,List<Persona> PasajerosList, List<Viaje> viajes) :this(nombre,apellido,edad)
        {
            this.viajes = viajes;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.PasajerosList = PasajerosList;
        }
        #endregion CONSTRUCTOR

        //vendedor puede acceder a la indormacion detalla de los pasajero a travez de viajes
    }
}
