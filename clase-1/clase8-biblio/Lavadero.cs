using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_biblio
{
    public class Lavadero
    {
        
        List<Vehiculo> vehiculos ;
        float precioAuto;
        float precioCamion;
        float precioMoto;


        private Lavadero()
        {
            vehiculos = new List<Vehiculo>();//inicializo lista generica
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto, Vehiculo vehiculos) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
           
        }

        public string Detalle
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.precioAuto.ToString());
                sb.AppendLine(this.precioCamion.ToString());
                sb.AppendLine(this.precioMoto.ToString());

                sb.AppendLine(LecturaVehiculos);
                
                return sb.ToString() ;
            }
        }
        public string LecturaVehiculos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in vehiculos)
                {
                    sb.AppendLine(item.ToString());//reutilizo tostring sobrecargado en vehiculos. Muestra patente, marca,etc

                }
                return sb.ToString() ; 
            }
        }

        /*
        public double MostrarTotalFacturado(EVehiculo vehiculo)
        {
            double totalFacturado = 0;

            if (vehiculo == EVehiculos.Auto)
            {
                totalFacturado = this.precioAuto
            }
            else
            {
                if (vehiculo == EVehiculos.Moto)
                {
                    totalFacturado = this.precioAuto
                }
                else
                {
                    totalFacturado = this.precioAuto
                }
            }
        }
        */
        public static bool operator ==(Lavadero lavadero,Vehiculo vehiculo)
        {
            bool retorno = false;
            foreach (var item in lavadero.vehiculos)
            {
                if (item == vehiculo)//determino si el veghiclo se encurnra en el lavadero 
                {
                    retorno = true;
                    break;
                }
            }
           
            return retorno;
        }
        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }
        public static bool operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;

            if (lavadero != vehiculo)
            {
                lavadero.vehiculos.Add(vehiculo);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;

            if (lavadero == vehiculo)
            {
                lavadero.vehiculos.Remove(vehiculo);
                retorno = true;
            }
            return retorno;
        }

        /*
        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            int retorno = 0;

            if()

            return retorno;
        }

        */
    }
}
