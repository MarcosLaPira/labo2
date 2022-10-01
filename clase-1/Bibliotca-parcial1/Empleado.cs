﻿using System;
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
        }
        /// <summary>
        /// constructor publico, inicialliza un emleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <param name="PasajerosList"></param>
        public Empleado(string nombre, string apellido,int edad, string usuario, string contrasena ,List<Persona> PasajerosList):this(nombre,apellido,edad)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.PasajerosList = PasajerosList;
        }
        #endregion CONSTRUCTOR
    }
}
