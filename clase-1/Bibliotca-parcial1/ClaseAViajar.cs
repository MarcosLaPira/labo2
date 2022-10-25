namespace Bibliotca_parcial1
{
    public abstract class ClaseAViajar
    {
        #region ATRIBUTOS
        private int cantBolsosDeMano;
        private int cantValijas;
        private float kgValija;
        private EClasePasajero clase;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public ClaseAViajar(EClasePasajero clase,int cantBolsosDeMano, int cantVaijas, float kgValija)
        {
            this.clase = clase;
            this.cantBolsosDeMano = cantBolsosDeMano;
            this.cantValijas = cantVaijas;
            this.kgValija = kgValija;
           
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// Rertorna int cantidadd de bolsos de mano
        /// </summary>
        public int CantBolsosDeMano { get => cantBolsosDeMano; set => cantBolsosDeMano = value; }
        /// <summary>
        /// 
        /// </summary>
        public int CantValijas { get => cantValijas; set => cantValijas = value; }
        /// <summary>
        /// Retorna float kg de Valija
        /// </summary>
        public float KgValija { get => kgValija; set => kgValija = value; }
        /// <summary>
        /// Retorna enum de clase de pasajero
        /// </summary>
        public EClasePasajero Clase { get => clase;  }

        #endregion PROPIEDADES

        //public EClasePasajero clase;


        /*
        public ClaseAViajar(EClasePasajero clase)
        {
            this.clase = clase;
            this.cantMaxValija = 0;
            this.cantMaxBolsoMano = 0;
            this.maxPesoValija = 0;
        }
        
      */
    }
}