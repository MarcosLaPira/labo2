namespace Bibliotca_parcial1
{
    public class Pasaporte:Persona
    {
        #region ATRIBUTOS
        private string nacionalidad;
        private DateTime fechaDeNacimiento;
        private DateTime fechaDeVencimiento;

        #endregion ATRIBUTOS 
        #region CONSTRUCTORES
        private Pasaporte(string nombre,string apellido,int edad):base(nombre,apellido, edad)
        {
            this.nacionalidad = "";
         
        }
        public Pasaporte(string nombre,string apellido,int edad,string nacionalidad, DateTime fechaDeNacimiento, DateTime fechaDeVencimiento):this(nombre,apellido,edad)
        {
            this.nacionalidad = nacionalidad;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.fechaDeVencimiento = fechaDeVencimiento;
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        /// <summary>
        /// retorna string con la nacionalidad
        /// </summary>
        public string Nacionalidad { get => nacionalidad; }
        /// <summary>
        /// retorna tipo dateTime la fecha de naciemiento
        /// </summary>
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; }
        /// <summary>
        /// retrona de tipo dateTime la fecha de vencimiento del pasaortw
        /// </summary>
        public DateTime FechaDeVencimiento { get => fechaDeVencimiento; }
       

        #endregion PROPIEDADES

    }
}