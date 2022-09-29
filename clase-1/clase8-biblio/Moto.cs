using System.Text;

namespace clase8_biblio
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;
        public Moto(string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {

        }
        public Moto(string patente, byte ruedas, EMarcas marca, float cilindrada) : this(patente, ruedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {


            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());//viene de la clase vehiculo, padre
            sb.AppendLine(this.cilindrada.ToString());

            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarMoto();
        }
    }
}