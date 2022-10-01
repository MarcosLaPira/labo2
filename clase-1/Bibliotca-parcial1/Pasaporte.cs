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
        public string Nacionalidad { get => nacionalidad; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; }
        public DateTime FechaDeVencimiento { get => fechaDeVencimiento; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }

        #endregion PROPIEDADES

    }
}