namespace clase8_Libreria
{
    public abstract class VehiculoTerrrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        colores color;

        public VehiculoTerrrestre(short cantidadRuedas, short cantidadPuertas, colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}