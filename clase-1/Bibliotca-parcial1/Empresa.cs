using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public  class Empresa
    {
        private List<Barco> barcos;
        private List<Viaje> viajes;      
        private  List<Empleado> empleados;         
        private string usuario;  
        private string contrasena;
        
        public Empresa()
        {
            this.barcos = new List<Barco>();
            this.viajes = new List<Viaje>();
            this.empleados = new List<Empleado>();
            usuario = "";
            contrasena = "";
        }
     
        public Empresa(List<Barco> barcos, List<Viaje> viajes, List<Empleado> empleados,string usuario,string contrasena)
        {
            this.barcos = barcos;
            this.viajes = viajes;
           
            this.empleados = empleados;
            this.usuario = usuario; 
            this.contrasena = contrasena;
        }


        public List<Barco> Barcos { get => barcos; }
        public List<Viaje> Viajes { get => viajes;  }
       
        public List<Empleado> Empleados { get => empleados; }

        public string Usuario
        {
            get { return this.usuario; }
        }
        public string Contrasena
        {
            get { return this.contrasena; }
        }


        /// <summary>
        /// muezstra informacion sencilla, salida y destino
        /// </summary>
        /// <returns></returns>
        public string MostrarViajesDisponibles()
        {
            StringBuilder sb = new StringBuilder();
            bool bandera = false;

            foreach (var item in this.viajes)
            {
                sb.Append("Nuestros viajes disponibles son:");
                if (item.Barco.BarcoEnPuerto)// en caso de que el barco asignado al viaje este en puerto
                {
                    sb.Append($"{item.Partida}-{item.Destino} ");//seteo info 
                    bandera = true;                    
                }
                if (!bandera)
                {
                    sb.Append("Sin viajes dispoibles");
                }              
            }               
            return sb.ToString();
        }

        public string MostrarInformacionCompletaDelViaje(Viaje viaje)
        {
            if (viaje is not null)
            {
                //Console.WriteLine(viaje.MostrarInfoDelViaje());
                return viaje.MostrarInfoDelViaje();


            }

            return"error";
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

       
        //mostrar historial de viajes 

        //mostrar empleados 

        //

        //destino mas elegido
    }
}
