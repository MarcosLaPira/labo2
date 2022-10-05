namespace Bibliotca_parcial1
{
    public class Camarote
    {
        #region ATRIBUTOS
        private List<Pasajero> pasajerosDelCamarote;
        private int idCamarote;
        private bool tipoDeClaseCamarote; //true == premium
        private bool camaroteLleno; // true == lleno
        static int capacidadMaximaCamarote;
        private int contadorDelCamarote;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        /// <summary>
        /// inicializo la capacidad maxima del camarote y el conteador
        /// </summary>
        static Camarote()
        {
            capacidadMaximaCamarote = 4;
            
        }

        private Camarote()
        {
            this.pasajerosDelCamarote = new List<Pasajero>();
            /*
            this.camaroteLleno = false;
            this.tipoDeClaseCamarote = false;
            */
        }
        public Camarote(bool estadoDelCamarote, int idCamarote):this()
        {
         
            this.camaroteLleno = estadoDelCamarote;
            this.idCamarote = idCamarote;
         
        }
        /*
        public Camarote( bool estadoDelCamarote, int idCamarote) : this (estadoDelCamarote,idCamarote)
        {
            this.pasajerosDelCamarote = pasajero;
          
        }
        */
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public List<Pasajero> PasajerosDElCamarote { get => pasajerosDelCamarote;  }
        public bool CamaroteLleno { get => camaroteLleno; set => camaroteLleno = value; }
        public int IdCamarote { get => idCamarote; set => idCamarote = value; }
        public bool TipoDeClaseCamarote { get => tipoDeClaseCamarote; set => tipoDeClaseCamarote = value; }
        public  int ContadorDelCamarote { get => contadorDelCamarote; }
        #endregion PROPIEDADES

        #region METODOS

        /// <summary>
        /// Agrego un pasajero al camarote 
        /// </summary>
        /// <param name="pasajero"></param>
        /// <returns>true lo agrego y false no lo agrego </returns>        
        public bool AgregarPasajeroAlCamarote( Pasajero pasajero)
        {
            bool retorno = false;
            if (pasajero is not null )
            {
                if (contadorDelCamarote < capacidadMaximaCamarote)
                {
                    this.pasajerosDelCamarote.Add(pasajero);//agrego pasajero al camarote
                    contadorDelCamarote++;
                    retorno = true;
                }
                else
                {
                    this.camaroteLleno = true;//seteo camarote lleno
                }
            }

            return retorno;
        }
        #endregion METODOS

    }
}