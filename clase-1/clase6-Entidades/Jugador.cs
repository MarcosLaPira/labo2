using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase6_Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int totalPartidos;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            float promedioGoles;
            promedioGoles = totalPartidos / totalGoles;
            return promedioGoles;
        }

       

        private Jugador()
        {
            totalPartidos = 0;
            promedioGoles = 0;
            totalGoles = 0;
            this.nombre = "";
        }
        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            this.totalPartidos = totalPartidos;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(dni.ToString());
            sb.AppendLine(nombre);
            sb.AppendLine(totalPartidos.ToString());
            sb.AppendLine(promedioGoles.ToString());
            sb.AppendLine(totalGoles.ToString());

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1.dni == j2.dni)
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
