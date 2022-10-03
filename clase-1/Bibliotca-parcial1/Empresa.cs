using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public  class Empresa
    {
        List<Barco> barcos;
        List<Viaje> viajes;
        List<Pasajero> pasajerosHistorial;
        List<Empleado> empleados;

        private Empresa()
        {
            this.barcos = new List<Barco>();
            this.viajes = new List<Viaje>();
            this.pasajerosHistorial = new List<Pasajero>();
            this.empleados = new List<Empleado>();
        }
        public Empresa(List<Barco> barcos, List<Viaje> viajes, List<Pasajero> pasajerosHistorial, List<Empleado> empleados)
        {
            this.barcos = barcos;
            this.viajes = viajes;
            this.pasajerosHistorial = pasajerosHistorial;
            this.empleados = empleados;
        }

        public List<Barco> Barcos { get => barcos; }
        public List<Viaje> Viajes { get => viajes;  }
        public List<Pasajero> PasajerosHistorial { get => pasajerosHistorial; }
        public List<Empleado> Empleados { get => empleados; }

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

       
        //cantidad de pasajeros de cada curuzero

        //destino mas elegido
    }
}
