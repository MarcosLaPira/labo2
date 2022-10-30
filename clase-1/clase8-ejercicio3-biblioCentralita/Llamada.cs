using System.Text;

namespace clase8_ejercicio3_biblioCentralita
{
    public class Llamada
    {
        #region ATRIBUTOS

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion CONSTRUCTOR

        #region PROPOIEDADES
        public float Duracion { get => duracion;  }
        public string NroDestino { get => nroDestino; }
        public string NroOrigen { get => nroOrigen;  }

        #endregion PROPOIEDADES

        #region METODOS

       

        /// <summary>
        /// Recibe dos llamdas y las compara por duracion
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns> Retorna 1 si la llamada 1 es mayor a la 2 y 0 si la 2 es mayor </returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1 is not null && llamada2 is not null)
            {
                if (llamada1.duracion > llamada2.duracion)
                {
                    retorno = 1;
                }
                else
                {
                    if (llamada2.duracion > llamada1.duracion)
                    {
                        retorno = - 1;
                    }

                }

            }
            return retorno;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Numero destino: {this.NroDestino}");
            sb.AppendLine($" Numero origen: {this.NroOrigen}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }


        #endregion METODOS
    }
}