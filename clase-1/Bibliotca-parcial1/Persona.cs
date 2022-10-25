using System.Text;

namespace Bibliotca_parcial1
{
    public abstract class Persona
    {
        #region ATRIBUTOS 
        private string nombre;
        private string apellido;
        protected int edad;

        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        /// <summary>
        /// constructor de clase Persona, recibe de parametro string nombre, string apellido y int edad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        private protected Persona(string nombre, string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;        
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES

        /// <summary>
        /// Raetrona string, el nombre
        /// </summary>
          public string Nombre { get => nombre; set => nombre = value; }
        /// <summary>
        /// retrorna string, el apellido
        /// </summary>
         public string Apellido { get => apellido; set => apellido = value; }
        #endregion PROPIEDADES

        #region METODOS
        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre es: {this.nombre}");
            sb.AppendLine($"Apellido es: {this.apellido}");
            sb.AppendLine($"Edad es: {this.edad}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarDatos();
        }
        #endregion METODOS


    }
}