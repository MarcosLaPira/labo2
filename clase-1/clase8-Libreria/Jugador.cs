using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Libreria
{
    public class Jugador:Persona
    {
        
        private int totalPartidos;
        private int totalGoles;

       
        public int TotalPartidos
        {
            get { return this.totalPartidos; }
            set { this.totalPartidos = value; }
        }
        public float PromedioGoles
        {
            get
            {

                return TotalPartidos / TotalGoles;
            }

        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; }
        }
       


        /*   
        private Jugador()
        {
            totalPartidos = 0;
            totalGoles = 0;
           
        }
        */
        public Jugador(int dni, string nombre) : base(dni,nombre)
        {
           
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre)
        {
           
            this.totalGoles = totalGoles;
            this.totalPartidos = totalPartidos;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(MostrarDatosss());//muestro dni y nombre del padre        
            sb.AppendLine(this.TotalPartidos.ToString());
            sb.AppendLine(this.PromedioGoles.ToString());
            sb.AppendLine(this.TotalGoles.ToString());

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1.Dni== j2.Dni)
            {
                retorno = true;
            }

            return retorno;

        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
