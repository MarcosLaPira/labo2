using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public class Empresa
    {
        List<Barco> barcos = new List<Barco>();
        List<Viaje> viajes = new List<Viaje>();
        List<Pasajero> pasajerosHistorial = new List<Pasajero>();
        List<Empleado> empleados = new List<Empleado>();

        public Empresa(List<Barco> barcos, List<Viaje> viajes, List<Pasajero> pasajerosHistorial, List<Empleado> empleados)
        {
            this.barcos = barcos;
            this.viajes = viajes;
            this.pasajerosHistorial = pasajerosHistorial;
            this.empleados = empleados;
        }

    }
}
