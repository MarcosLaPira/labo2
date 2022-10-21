using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public  class Viaje
    {
        #region ATRIBUTOS
        private Barco barco;//dejaria de tener una lista de camarotes
        private Ciudad partida;
        private Ciudad destino;
        private DateTime fechaInicioViaje;
        List<Pasajero> listaPasajeros;
        //list camarotes
        private int contadorDePasajeros;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
      
      
        public Viaje(Barco barco, Ciudad partida, Ciudad destino, DateTime fechaInicioViaje)
        {            
            this.barco = barco;
            this.partida = partida;
            this.destino = destino;
            this.fechaInicioViaje = fechaInicioViaje;

            this.listaPasajeros = new List<Pasajero>();

        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        /// <summary>
        /// retorna barco de tipo Barco
        /// </summary>
        public Barco Barco { get => barco;  }
        /// <summary>
        /// retorna partida de tipo Edestinos 
        /// </summary>
        
        public Ciudad Partida { get => partida; }
       /// <summary>
       /// retrona destino de tipo Edestinos 
       /// </summary>
        public Ciudad Destino { get => destino;  }
        /// <summary>
        /// retorna fecha de inicio del viaje 
        /// </summary>
        public DateTime FechaInicioViaje { get => fechaInicioViaje;}
         

        /// <summary>
        /// rrtorna duracion del viaje tipo int
        /// </summary>
        public int DuracionDelViaje
        {       
            get 
            {
                Random rand = new Random();
                if (this.partida.Region == this.destino.Region)
                {
                    return rand.Next(72, 360);
                }             
                else
                {
                    return rand.Next(480, 720);
                }              
            }
        }
        /// <summary>
        /// retrona costo del viaje para turista tipo float
        /// </summary>
        public float CostoDelViajeTurista
        {
            get
            {
                int duracionViaje = DuracionDelViaje;
                if (this.partida.Region == this.destino.Region)//verifico que tipo de viaje hizo
                {
                    return duracionViaje * 57;//viaje regional 
                }
                else
                {
                    return duracionViaje * 120;//viaje internacional
                }
            }
        }
      /// <summary>
      /// retrona costo del viaje premium tipo float
      /// </summary>
        public float CostoDelViajePremium
        {
            get
            {
                int duracionViaje = DuracionDelViaje;
                if (this.partida.Region == this.destino.Region)//verifico que tipo de viaje hizo
                {
                    return duracionViaje * 114;//viaje regional 
                }
                else
                {
                    return duracionViaje * 240;//viaje internacional
                }
            }
        }
        /// <summary>
        /// retrona pasajeros del viaje tipo  List<Pasajero>
        /// </summary>
        public List<Pasajero> ListaPasajeros
        { 
            get => listaPasajeros;          
        }

        /// <summary>
        /// recaudacion de un viaje
        /// </summary>
        public float RecaudacionDeUnViaje
        {
            get 
            {
                float recaudacion = 0;
                float buffer = 0; 
                foreach (Pasajero pasajero in ListaPasajeros)
                {
                    if (pasajero.Clase == EClasePasajero.Premium)
                    {
                        buffer = CostoDelViajePremium;
                    }
                    else
                    {
                        buffer = CostoDelViajeTurista;
                    }

                    recaudacion = buffer + recaudacion;
                }
                return recaudacion;
            }
        }

        /// <summary>
        /// retrona cantidad de pasajeros
        /// </summary>
        public int CantidadDePasajeros
        {
            get
            {
                return this.contadorDePasajeros;
            }
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
            if (pasajero is not null && this.contadorDePasajeros < barco.CapacidadDePersonas )////////acaaaaaaaaaaa
            {
                if (pasajero.Clase == EClasePasajero.Premium)//busco solo en camarotes premium
                {
                    for (int i = 0; i < this.barco.CantidadDeCamarotesPremium; i++)//recorro camarotes
                    {
                        if (this.barco.ListCamarotes[i].ContadorDelCamarote == 0)//verifico que el camarote no tenga ningun pasajero
                        {
                            listaPasajeros.Add(pasajero);//agrego pasajero a la lista general 
                            barco.ListCamarotes[i].AgregarPasajeroAlCamarote(pasajero);//agrego pasajero
                            this.contadorDePasajeros++;
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
            if (pasajero is not null && this.contadorDePasajeros < barco.CapacidadDePersonas && barco.BarcoEnPuerto == true)
            {
                if (pasajero.Clase == EClasePasajero.Turista)//busco solo en camarotes turista
                {
                    for (int i = 0; i < this.barco.CantidadDeCamarotesTurista; i++)//recorro camarotes
                    {
                        if (this.barco.ListCamarotes[i].ContadorDelCamarote == 0)//verifico que el camarote no tenga ningun pasajero
                        {
                            listaPasajeros.Add(pasajero);//agrego pasajero a la lista general 
                            barco.ListCamarotes[i].AgregarPasajeroAlCamarote(pasajero);//agrego pasajero
                            this.contadorDePasajeros++;
                            retorno = true;
                            break;
                        }
                    }

                }

            }
            return retorno;
        }
        /*
        /// <summary>
        /// Agrega un pasajero a un camaorte en especifico
        /// </summary>
        /// <param name="idDeCamarote">id del camarote</param>
        /// <param name="pasajero"></param>
        /// <returns> true lo agrego y false no lo agrego </returns>
        public bool AgregarPasajeroACamaroteEspecifico(int idDeCamarote, Pasajero pasajero)
        {
            bool retorno = false;
            if (pasajero is not null && idDeCamarote >= 0 && idDeCamarote < barco.CantidadDeCamarotes && this.contadorDePasajeros < barco.CapacidadDePersonas )
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
        */
        public bool AgregarPasajeroACamaroteEspecifico(Camarote camarote, Pasajero pasajero)
        {
            bool retorno = false;
            if (pasajero is not null && camarote is not null && this.contadorDePasajeros < barco.CapacidadDePersonas)
            {
                if (!camarote.CamaroteLleno)
                {
                    camarote.AgregarPasajeroAlCamarote(pasajero);
                    listaPasajeros.Add(pasajero);//agrego pasajero a la lista general 
                    contadorDePasajeros++;
                    retorno = true;
                }
               
            }
            return retorno;
        }

        public string MostrarInfoDelViaje()
        {
            StringBuilder sb = new StringBuilder();           

            sb.Append($"Nombre del barco:{this.barco.Nombre}");
            sb.Append($"Origen:{this.partida}");
            sb.Append($"Destino: {this.Destino}");
            sb.Append($"Fecha de inicio: {this.FechaInicioViaje}");
            sb.Append($"Duracion del viaje: {this.DuracionDelViaje}");
            sb.Append($"Costo clase premium: {this.CostoDelViajePremium}");
            sb.Append($"Costo clase turista: {this.CostoDelViajeTurista}");
                   
            return sb.ToString();
        }

        
        public override string ToString()
        {
            return MostrarInfoDelViaje();
        }
        
        #endregion METODOS
        //camarotes disponibles clase turisata

        //camarotes disponibles clase premium

        //precio




        //duracion del viaje 


        //duracion del viaje 


    }
}
