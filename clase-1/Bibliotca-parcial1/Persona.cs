using System.Text;

namespace Bibliotca_parcial1
{
    public abstract class Persona
    {
        #region ATRIBUTOS 
        protected string nombre;
        protected string apellido;
        protected int edad;
    
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        private protected Persona(string nombre, string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;        
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES


        #endregion PROPIEDADES

        
        public virtual string MostrarDatos()
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


    }
}