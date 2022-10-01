using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Bibliotca_parcial1
{
    public class Barco
    {
        #region ATRIBUTOS

        private string matricula;
        private string nombre;
        private int cantidadDeCamarotes;//lo que uno quiera
        private int cantidadDeSalones;
        private int cantidadDeCasinos;
        private float capacidadDeBodega;
        private int capacidadDePersonas;
        private bool barcoEnPuerto;

       
        List<Camarote> listCamarotes ;


        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        /// <summary>
        /// constructor de barco
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="nombre"></param>
        /// <param name="cantidadDeCamarotes"></param>
        /// <param name="cantidadDeSalones"></param>
        /// <param name="cantidadDeCasinos"></param>
        /// <param name="capacidadDeBodega"></param>
        /// <param name="capacidadDePersonas"></param>
        /// <param name="estadoDelBarco"></param>

       
        public Barco(string matricula, string nombre, int cantidadDeCamarotes, int cantidadDeSalones, 
            int cantidadDeCasinos, float capacidadDeBodega, int capacidadDePersonas, bool estadoDelBarco)
        {
            this.listCamarotes = new List<Camarote>(cantidadDeCamarotes);//le doy un tamano a los camarotes
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadDeCamarotes = cantidadDeCamarotes;
            this.cantidadDeSalones = cantidadDeSalones;
            this.cantidadDeCasinos = cantidadDeCasinos;
            this.capacidadDeBodega = capacidadDeBodega;
            this.capacidadDePersonas = capacidadDePersonas;
            this.barcoEnPuerto = estadoDelBarco;

            administradorCamarotesList();
        }
       
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public string Matricula { get => matricula; }
        public string Nombre { get => nombre; }
        public int CantidadDeSalones { get => cantidadDeSalones; }
        public int CantidadDeCasinos { get => cantidadDeCasinos; }
        public float CapacidadDeBodega { get => capacidadDeBodega;  }
        public int CapacidadDePersonas { get => capacidadDePersonas; }
        public bool BarcoEnPuerto { get => barcoEnPuerto; set => barcoEnPuerto = value; }
        public int CantidadDeCamarotes { get => cantidadDeCamarotes; }

        //cantidadDeCamarotesPremium
        public List<Camarote> ListCamarotes { get => listCamarotes; set => listCamarotes = value; }
        public int CantidadDeCamarotesPremium 
        {
            get 
            { 
              
                return (35/CantidadDeCamarotes)*100;
                
            }
        }
        public int CantidadDeCamarotesTurista
        {
            get
            {
                int totalCamarotes;
                totalCamarotes = 
                return;
            }


        }


        #endregion PROPIEDADES

        #region METODOS

        /// <summary>
        /// setea los id de los camaraotes y setea la cantidad de camarotes que seran premium
        /// </summary>
        private void administradorCamarotesList()
        {           
            int cantidadDeCamarotesPremium = CantidadDeCamarotesPremium;
        
            for (int i = 0; i < cantidadDeCamarotes; i++)
            {
                listCamarotes[i].IdCamarote = i;

                if (i < CantidadDeCamarotesPremium)
                {
                    listCamarotes[i].TipoDeClaseCamarote = true;//seteo el 35% de los camarotes en clase premium
                }
              
            }
           
        }
        /*

        private bool administradorCamarotes()
        {
            bool retorno = false;
            int cantidadDeCamarotesPremium = CantidadDeCamarotesPremium;

            for (int i = 0;  i < cantidadDeCamarotes; i++ )
            {
                arrayCamarotes[i].IdCamarote = i;//seteo id
                arrayCamarotes[i].EstadoDelCamarote = false;//seteo estado del camarote false(vacio)
                
            }
            return retorno;

        }
        */
        #endregion METODOS


    }
}