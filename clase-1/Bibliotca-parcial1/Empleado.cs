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

        #endregion ATRIBUTOS

        #region PROPIEDADES
        /// <summary>
        /// Retorna el usuario
        /// </summary>
        public string Usuario { get => usuario; }
        /// <summary>
        /// retorna la contrasena
        /// </summary>
        public string Contrasena { get => contrasena; }

        #endregion PROPIEDADES



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
        public Empleado(string nombre, string apellido,int edad, string usuario, string contrasena , List<Viaje> viajes) :this(nombre,apellido,edad)
        {
            this.viajes = viajes;
            this.usuario = usuario;
            this.contrasena = contrasena;
            
        }
        #endregion CONSTRUCTOR

       
    }
}
