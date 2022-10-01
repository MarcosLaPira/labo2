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




    }
}