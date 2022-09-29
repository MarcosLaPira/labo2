using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Libreria
{
    public abstract class Persona
    {
        private long dni;
        private string nombre;

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; } 
        }

        public string MostrarDatosss()
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Dni.ToString());
            sb.AppendLine(Nombre.ToString());
            return sb.ToString();

        }
        public Persona(string nombre)
        { 
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre ):this(nombre)
        {
           this.dni = dni;         
        }
    }
}
