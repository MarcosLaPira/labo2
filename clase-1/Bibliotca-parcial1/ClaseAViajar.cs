namespace Bibliotca_parcial1
{
    public abstract class ClaseAViajar
    {
        private int cantMaxBolsoMano;
        private int cantMaxValija;
        float maxPesoValija;

        public ClaseAViajar(int cantMaxBolsoMano, int cantMaxValija, float maxPesoValija)
        {
            this.cantMaxBolsoMano = cantMaxBolsoMano;
            this.cantMaxValija = cantMaxValija;
            this.maxPesoValija = maxPesoValija;
        }
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