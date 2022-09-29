using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase7_Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int totalPartidos;
       
        private int totalGoles;

        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
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
       
       
       

        private Jugador()
        {
            totalPartidos = 0;
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
            sb.AppendLine(this.Dni.ToString());
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.TotalPartidos.ToString());
            sb.AppendLine(this.PromedioGoles.ToString());
            sb.AppendLine(this.TotalGoles.ToString());

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
