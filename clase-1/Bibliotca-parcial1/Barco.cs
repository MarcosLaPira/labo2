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


        private Barco()
        {
            this.listCamarotes = new List<Camarote>();
            this.matricula = "";
            this.nombre = "";
        }


        public Barco(string matricula, string nombre, int cantidadDeCamarotes, int cantidadDeSalones, 
            int cantidadDeCasinos, float capacidadDeBodega, int capacidadDePersonas, bool estadoDelBarco):this()
        {

            //this.listCamarotes = new List<Camarote>(cantidadDeCamarotes);//defino cuantos camarotes tengo
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
        /// <summary>
        /// retorna string de matricula
        /// </summary>
        public string Matricula { get => matricula; }
        /// <summary>
        /// retorna string de nombre
        /// </summary>
        public string Nombre { get => nombre; }
        /// <summary>
        /// retorna int de salones
        /// </summary>
        public int CantidadDeSalones { get => cantidadDeSalones; }
        /// <summary>
        /// retorna int de casinos
        /// </summary>
        public int CantidadDeCasinos { get => cantidadDeCasinos; }
        /// <summary>
        /// retorna float de cpacidad bodega kg
        /// </summary>
        public float CapacidadDeBodega { get => capacidadDeBodega;  }
        /// <summary>
        /// retorna int de capacidad de personaas
        /// </summary>
        public int CapacidadDePersonas { get => capacidadDePersonas; }
        /// <summary>
        /// retorna true si el barco esta en puerto y false si esta en viaje. Permite setear estado
        /// </summary>
        public bool BarcoEnPuerto { get => barcoEnPuerto; set => barcoEnPuerto = value; }
        /// <summary>
        /// retorna la cantidad de camarotes
        /// </summary>

        public int CantidadDeCamarotes { get => cantidadDeCamarotes; }

        /// <summary>
        /// retorna lista completa de camarotes
        /// </summary>
        public List<Camarote> ListCamarotes { get => listCamarotes; set => listCamarotes = value; }
        /// <summary>
        /// retorna la cantidad de camarotes premium del barco
        /// </summary>
        public int CantidadDeCamarotesPremium 
        {
            get 
            {
                int resultado = (this.cantidadDeCamarotes * 35  ) / 100;
                return resultado;
                
            }
        }
        /// <summary>
        /// retorna la cantidad de camarotes clase turista del barco
        /// </summary>
        public int CantidadDeCamarotesTurista
        {
            get
            {
                int totalCamarotes = CantidadDeCamarotes;
                int camarotesPremium = CantidadDeCamarotesPremium;
                return totalCamarotes - camarotesPremium;
            }
        }


        #endregion PROPIEDADES

        #region METODOS

        /// <summary>
        /// setea los id de los camaraotes y setea la cantidad de camarotes que seran premium
        /// </summary>

        private void CreadorCamarotes()
        {
            for (int i = 0; i < this.cantidadDeCamarotes; i++)
            {
                this.listCamarotes.Add(new Camarote(false, i));
            }
        }
        private void administradorCamarotesList()
        {
           CreadorCamarotes();//creo los camarotes por default

            for (int i = 0; i < this.cantidadDeCamarotes; i++)
            {              
              
                if (i < CantidadDeCamarotesPremium)
                {
                    this.listCamarotes[i].TipoDeClaseCamarote = true;//seteo el 35% de los camarotes en clase premium
                }
                else
                {
                    this.listCamarotes[i].TipoDeClaseCamarote = false;//seteo el resto de los camarotes en clase turista
                }
              
            }
           
        }
       
        #endregion METODOS


    }
}