namespace Bibliotca_parcial1
{
    public class Camarote
    {
        #region ATRIBUTOS
        private List<Pasajero> pasajerosDelCamarote;
        private int idCamarote;
        private bool tipoDeClaseCamarote; //true == premium
        private bool camaroteLleno; // true == lleno
        private int capacidadMaximaCamarote;
        private int contadorDelCamarote;
      
        #endregion ATRIBUTOS

        #region CONSTRUCTORES


        public Camarote(bool camaroteLleno, int idCamarote)
        {
            this.pasajerosDelCamarote = new List<Pasajero>();

            this.idCamarote = idCamarote;
            this.camaroteLleno = camaroteLleno;
            this.capacidadMaximaCamarote = 4;
            this.contadorDelCamarote = 0;

        }
        /*
        public Camarote( bool estadoDelCamarote, int idCamarote) : this (estadoDelCamarote,idCamarote)
        {
            this.pasajerosDelCamarote = pasajero;
          
        }
        */
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        /// <summary>
        /// retorna lisat de pasajeros del camarote
        /// </summary>
        public List<Pasajero> PasajerosDElCamarote { get => pasajerosDelCamarote;}
        /// <summary>
        /// retorna true si el camarote esta lleno
        /// </summary>
        public bool CamaroteLleno { get => camaroteLleno; set => camaroteLleno = value;}
        /// <summary>
        /// retorna id camarote
        /// </summary>
        public int IdCamarote { get => idCamarote; set => idCamarote = value; }
        /// <summary>
        /// retorna tipo de clase de camarote true= premium
        /// </summary>
        public bool TipoDeClaseCamarote { get => tipoDeClaseCamarote; set => tipoDeClaseCamarote = value; }
        //retorna cantidad de personas del camarote
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
                if (this.contadorDelCamarote < this.capacidadMaximaCamarote && !this.camaroteLleno)
                {
                    this.pasajerosDelCamarote.Add(pasajero);//agrego pasajero al camarote
                    contadorDelCamarote++;
                    retorno = true;
                }
                else
                {
                    this.camaroteLleno = true;//seteo camarote en lleno
                }
            }

            return retorno;
        }
        /*
        public bool AgregarPasajeroAlCamarote2(Pasajero pasajero,Camarote camarote)
        {
            bool retorno = false;
            if (pasajero is not null && camarote is not null)
            {
                if (this.contadorDelCamarote < this.capacidadMaximaCamarote && !this.camaroteLleno)
                {
                    this.pasajerosDelCamarote.Add(pasajero);//agrego pasajero al camarote
                    contadorDelCamarote++;
                    retorno = true;
                }
                else
                {
                    this.camaroteLleno = true;//seteo camarote en lleno
                }
            }

            return retorno;
        }
        */
        #endregion METODOS

    }
}