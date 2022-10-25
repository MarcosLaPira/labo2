using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public  class Empresa
    {
        #region Atributos
        private List<Barco> barcos;
        private List<Viaje> viajes;      
        private  List<Empleado> empleados;         
        private string usuario;  
        private string contrasena;
        #endregion Atributos

        #region CONSTRUCTORES
        /// <summary>
        /// Cosntructor vacio de Empresa inicializa atributos y listas
        /// </summary>
        public Empresa()
        {
            this.barcos = new List<Barco>();
            this.viajes = new List<Viaje>();
            this.empleados = new List<Empleado>();
            usuario = "";
            contrasena = "";
        }
        /// <summary>
        /// Cosntructor de Empresa recibe lista de:barcos, viajes, empleados y un ususario y contrasena
        /// </summary>
        /// <param name="barcos"></param>
        /// <param name="viajes"></param>
        /// <param name="empleados"></param>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        public Empresa(List<Barco> barcos, List<Viaje> viajes, List<Empleado> empleados,string usuario,string contrasena)
        {
            this.barcos = barcos;
            this.viajes = viajes;
           
            this.empleados = empleados;
            this.usuario = usuario; 
            this.contrasena = contrasena;
        }
        #endregion CONSTRUCTORES

        #region PROIEDADES
        /// <summary>
        /// retornsa lista de barcos
        /// </summary>
        public List<Barco> Barcos { get => barcos; }
        /// <summary>
        /// retorna lista de viajes
        /// </summary>
        public List<Viaje> Viajes { get => viajes;  }
        /// <summary>
        /// retorna lista de empleados
        /// </summary>
       
        public List<Empleado> Empleados { get => empleados; }
        /// <summary>
        /// retorna string de usuario
        /// </summary>

        public string Usuario
        {
            get { return this.usuario; }
        }
        /// <summary>
        /// retorna string de constrasena
        /// </summary>
        public string Contrasena
        {
            get { return this.contrasena; }
        }

        /// <summary>
        /// recaudacion de todos los viajes 
        /// </summary>
        public float RecaudacionTotal
        {
            get
            {
                float buffer = 0;
                foreach (var item in this.viajes)
                {
                    buffer = item.RecaudacionDeUnViaje;
                }
                return buffer;
            }
        }
        #endregion PROIEDADES

        #region METODOS
       
        public string MostrarInfoViaje()
        {
            StringBuilder sb = new StringBuilder();
            bool bandera = false;

            sb.AppendLine("Nuestros viajes  son:");
            foreach (var item in this.viajes)
            {
                //viajes              
                sb.AppendLine($" {item.Partida} - {item.Destino}");

                //viajes disponibles
                sb.AppendLine("Estado:");
                if (item.EstadoDelViaje)// en caso de que el barco asignado al viaje este en puerto
                {
                    sb.AppendLine($"");//seteo info 
                    bandera = true;
                }
                if (!bandera)
                {
                    sb.AppendLine("Sin viajes dispoibles");
                }
            }
            sb.AppendLine("Nuestros  barcos son:");
            //barcos
            foreach (var item in this.barcos)
            {                          
                sb.AppendLine($"{item.Matricula}");//seteo info 
               
            }

            //empleados
            sb.AppendLine("Nuestros  empleados son:");
            foreach (var item in this.empleados)
            {
                sb.AppendLine($"{item.Nombre}, {item.Apellido}");//seteo info 

            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarInfoViaje();
        }


        #endregion METODOS


        //mostrar historial de viajes 

        //mostrar empleados 

        //

        //destino mas elegido
    }
}
