using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10_ejercicio2
{
    public class DerExcepcion:Exception
    {
        string mensaje;

        public DerExcepcion(string mensaje)
        {
            this.mensaje = mensaje;
            
        }

        public DerExcepcion(string mensaje, Exception inner) 
        {
            this.mensaje += ((DerExcepcion)inner).Message + mensaje;

        }

        public string Mensaje
        {
            get { return this.mensaje; }
            set { this.mensaje = value; }
        }

       
    }
}
