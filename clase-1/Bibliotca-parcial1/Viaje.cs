using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public sealed class Viaje
    {
        #region ATRIBUTOS
        private Barco barco;
        private EDestinos partida;
        private EDestinos destino;
        private DateTime fechaInicioViaje;
        List<Pasajero> listaPasajeros;

        static int contadorDePasajeros;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        static Viaje()
        {
            contadorDePasajeros = 0;
         //   camarotesDisponiblesTurista = 0;
           // camarotesDisponiblesPremium = 0;
        }
        public Viaje(Barco barco, EDestinos partida, EDestinos destino, DateTime fechaInicioViaje, List<Pasajero> listaPasajeros)
        {
            this.barco = barco;
            this.partida = partida;
            this.destino = destino;
            this.fechaInicioViaje = fechaInicioViaje;
            this.listaPasajeros = listaPasajeros;
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public Barco Barco { get => barco;  }
        public EDestinos Partida { get => partida; }
        public EDestinos Destino { get => destino;  }
        public DateTime FechaInicioViaje { get => fechaInicioViaje;}

       
        public List<Pasajero> ListaPasajeros
        { 
            get => listaPasajeros;
          
        }

        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// agrega un pasaejro premium a un camarote premium vacio
        /// </summary>
        /// <param name="pasajero"></param>
        /// <returns> true si lo agrego y false si no lo agrego</returns>
        public bool AgregarPasajeroCamaroteVacioPremium(Pasajero pasajero)
        {
            bool retorno = false;
            if (pasajero is not null && contadorDePasajeros < barco.CapacidadDePersonas && barco.BarcoEnPuerto == true)
            {
                if (pasajero.Clase == EClasePasajero.Premium)//busco solo en camarotes premium
                {
                    for (int i = 0; i < this.barco.CantidadDeCamarotesPremium; i++)//recorro camarotes
                    {
                        if (this.barco.ListCamarotes[i].ContadorDelCamarote == 0)//verifico que el camarote no tenga ningun pasajero
                        {
                            listaPasajeros.Add(pasajero);//agrego pasajero a la lista general 
                            barco.ListCamarotes[i].AgregarPasajeroAlCamarote(pasajero);//agrego pasajero
                            contadorDePasajeros++;
                            retorno = true;
                            break;
                        }
                    }
                   
                }
            
            }
            return retorno ;  
        }

        /// <summary>
        /// agrega un pasajero turista a un camarote turista vacio
        /// </summary>
        /// <param name="pasajero"></param>
        /// <returns>true lo agrego y false no lo agrego</returns>
        public bool AgregarPasajeroCamaroteVacioTurista(Pasajero pasajero)
        {
            bool retorno = false;
            if (pasajero is not null && contadorDePasajeros < barco.CapacidadDePersonas && barco.BarcoEnPuerto == true)
            {
                if (pasajero.Clase == EClasePasajero.Turista)//busco solo en camarotes turista
                {
                    for (int i = 0; i < this.barco.CantidadDeCamarotesTurista; i++)//recorro camarotes
                    {
                        if (this.barco.ListCamarotes[i].ContadorDelCamarote == 0)//verifico que el camarote no tenga ningun pasajero
                        {
                            listaPasajeros.Add(pasajero);//agrego pasajero a la lista general 
                            barco.ListCamarotes[i].AgregarPasajeroAlCamarote(pasajero);//agrego pasajero
                            contadorDePasajeros++;
                            retorno = true;
                            break;
                        }
                    }

                }

            }
            return retorno;
        }

        /// <summary>
        /// Agrega un pasajero a un camaorte en especifico
        /// </summary>
        /// <param name="idDeCamarote">id del camarote</param>
        /// <param name="pasajero"></param>
        /// <returns> true lo agrego y false no lo agrego </returns>
        public bool AgregarPasajeroACamaroteEspecifico(int idDeCamarote, Pasajero pasajero)
        {
            bool retorno = false;
            if (pasajero is not null && idDeCamarote >= 0 && idDeCamarote < barco.CantidadDeCamarotes && contadorDePasajeros < barco.CapacidadDePersonas )
            {
                if (!barco.ListCamarotes[idDeCamarote].CamaroteLleno) //veridfico que el camarote no este lleno
                {
                    barco.ListCamarotes[idDeCamarote].AgregarPasajeroAlCamarote(pasajero);//agrego pasajero
                    listaPasajeros.Add(pasajero);//agrego pasajero a la lista general 
                    contadorDePasajeros++;
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion METODOS
        //camarotes disponibles clase turisata

        //camarotes disponibles clase premium

        //precio



        //duracion del viaje 

        //duracion del viaje 


    }
}
