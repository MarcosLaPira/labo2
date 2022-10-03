namespace Bibliotca_parcial1
{
    public abstract class ClaseAViajar
    {
        private int cantBolsosDeMano;
        private int cantVaijas;
        private float kgValija;
        private EClasePasajero clase;


        public ClaseAViajar(EClasePasajero clase,int cantBolsosDeMano, int cantVaijas, float kgValija)
        {
            this.clase = clase;
            this.cantBolsosDeMano = cantBolsosDeMano;
            this.cantVaijas = cantVaijas;
            this.kgValija = kgValija;
           
        }

        public int CantBolsosDeMano { get => cantBolsosDeMano; set => cantBolsosDeMano = value; }
        public int CantVaijas { get => cantVaijas; set => cantVaijas = value; }
        public float KgValija { get => kgValija; set => kgValija = value; }
        public EClasePasajero Clase { get => clase;  }
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