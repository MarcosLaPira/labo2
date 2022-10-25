using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Bibliotca_parcial1
{
    public static class CoreDelSistema
    {
        #region ATRIBUTOS     
        static List<Viaje> viajes;     
        static List<Empleado> empleados;
        public static List<Ciudad> ciudades;
        static List<Barco> barcos;
        static Empresa empresa;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        static CoreDelSistema()
        {
            CoreDelSistema.viajes = new List<Viaje>();
            CoreDelSistema.empleados = new List<Empleado>();
            CoreDelSistema.ciudades = new List<Ciudad>();
            CoreDelSistema.barcos = new List<Barco>();
            CoreDelSistema.empresa = new Empresa();//por defoult



            CoreDelSistema.CargarClaseCiudades();
            CoreDelSistema.CargarBarcos();
            CoreDelSistema.CargarViajes();
            CoreDelSistema.CargarEmpleados();
            CoreDelSistema.CargarEmpresa();
        }
        #endregion CONSTRUCTORES

        #region CARGA FORZADA
       private static void CargarClaseCiudades()
       {
            //sudamerica
            CoreDelSistema.ciudades.Add(new(EDestinos.Montevideo, "Montevideo", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.Ushuaia, "Ushuaia", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.Recife, "Recife", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.Santiago, "Santiago", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.Lima, "Lima", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.IslaDePascua, "Isla De Pascua", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.IslaGalápagos, "IslaGalápagos", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.PuertoMadryn, "Puerto Madryn", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.RíodeJaneiro, "Ríode Janeiro", 0));
            CoreDelSistema.ciudades.Add(new(EDestinos.Cartagena, "Cartagena", 0));

            //norteamerica
            CoreDelSistema.ciudades.Add(new(EDestinos.LaHabana, "La Habana", 1));
            CoreDelSistema.ciudades.Add(new(EDestinos.Venecia, "Venecia", 1));
            CoreDelSistema.ciudades.Add(new(EDestinos.Acapulco, "Acapulco", 1));
            CoreDelSistema.ciudades.Add(new(EDestinos.Miami, "Miami", 1));
            CoreDelSistema.ciudades.Add(new(EDestinos.NuevaYork, "Nueva York", 1));
            CoreDelSistema.ciudades.Add(new(EDestinos.Bangkok, "Bangkok", 1));
            CoreDelSistema.ciudades.Add(new(EDestinos.Taipei, "Taipei", 1));
            CoreDelSistema.ciudades.Add(new(EDestinos.Atenas, "Atenas", 1));
        }
        private static void CargarEmpleados()
        {
            CoreDelSistema.empleados.Add(new("dieguito ", "boca ", 34, "ab", "ab", viajes));
            CoreDelSistema.empleados.Add(new("andy", "deusi", 40, "ba", "ba", viajes));

        }
        private static void CargarBarcos()
        {
           CoreDelSistema.barcos.Add( new Barco("alfa", "el destructor", 50, 1, 1, 2000, 250, true));
           CoreDelSistema.barcos.Add(new Barco("beta", "sin descenso", 200, 3, 0, 6000, 500, true));
            CoreDelSistema.barcos.Add(new Barco("centauro", "libertadores", 500, 7, 3, 60000, 2000, true));
        }

        private static void CargarEmpresa()
        {
            CoreDelSistema.empresa = new Empresa(CoreDelSistema.barcos,CoreDelSistema.viajes, CoreDelSistema.empleados,"Carlos","Carlos");
        }
        /// <summary>
        /// creo 2 viajes enteros, cada viaje tiene 3 pasajeros, el primer viaje esta navegando el sagundo en puerto
        /// </summary>
        private static void CargarViajes()
        {

            //creo primer viaje. no esta en puerto

          CrearViaje(new(
                           CoreDelSistema.barcos[0], //new Barco("alfa123", "el destructor", 50, 1, 1, 2000, 250, true),

                           CoreDelSistema.ciudades[1],

                           CoreDelSistema.ciudades[12],

                           new DateTime(2022, 9, 10)


                      ));
            /*
            CoreDelSistema.viajes.Add(new(
                            CoreDelSistema.barcos[0], //new Barco("alfa123", "el destructor", 50, 1, 1, 2000, 250, true),

                            CoreDelSistema.ciudades[1],

                            CoreDelSistema.ciudades[12],

                            new DateTime(2022, 9, 10)
                           
       
                       )  );
            */
           CoreDelSistema.viajes[0].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "marcos",

                                                                        "lapi",

                                                                        19,

                                                                        new Pasaporte("marcos", "lapi", 19, "argentina", new DateTime(2003, 7, 4), new DateTime(2023, 7, 4)),

                                                                        EClasePasajero.Premium

                                                                        ));

            CoreDelSistema.viajes[0].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "pichi",

                                                                        "fer",

                                                                        40,

                                                                        new Pasaporte("pichi", "fer", 40, "argentina", new DateTime(1945, 7, 4), new DateTime(2043, 7, 4)),

                                                                        EClasePasajero.Premium

                                                                         ));
            CoreDelSistema.viajes[0].AgregarPasajeroCamaroteVacioTurista(new Pasajero(

                                                                        "lauti",

                                                                        "esco",

                                                                        17,

                                                                        new Pasaporte("lauti", "esco", 17, "indonesiA", new DateTime(2005, 7, 4), new DateTime(2022, 7, 4)),

                                                                        EClasePasajero.Turista

                                                                        ));

            CrearViaje(new(

                          CoreDelSistema.barcos[1],// new Barco("beta", "sin descenso", 200, 3, 0, 6000, 500, false),

                           CoreDelSistema. ciudades[4],

                           CoreDelSistema.ciudades[6],

                           new DateTime(2023, 10, 10),
                           false

                      ));
            CoreDelSistema.viajes[1].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "aldo",

                                                                        "norque",

                                                                        34,

                                                                        new Pasaporte("aldo", "norque", 34, "suiza", new DateTime(1986, 2, 24), new DateTime(2045, 3, 14)),

                                                                        EClasePasajero.Premium

                                                                        ));
            CoreDelSistema.viajes[1].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "oscar",

                                                                        "romeo",

                                                                        56,

                                                                        new Pasaporte("oscar", "romeo", 56, "ucrania", new DateTime(1945, 12, 12), new DateTime(2023, 7, 4)),

                                                                        EClasePasajero.Premium

                                                                        ));
           CoreDelSistema. viajes[1].AgregarPasajeroCamaroteVacioTurista(new Pasajero(

                                                                        "flavio",

                                                                        "nazaret",

                                                                        22,

                                                                        new Pasaporte("flavio", "nazaret", 17, "iran", new DateTime(1999, 5, 14), new DateTime(2022, 7, 4)),

                                                                        EClasePasajero.Turista

                                                                        ));


        }
        #endregion CARGA FORZADA

        public static List<Viaje> Viajes
        {           
            get { return CoreDelSistema.viajes; }
        }

        public static List<Barco> Barcos
        {
            get { return CoreDelSistema.barcos; }
        }

        public static List<Ciudad> Ciudades
        {
            get { return CoreDelSistema.ciudades; }
        }

        #region METODOS

        /// <summary>
        /// valida que los campos no sean ni null o empty
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns>true no es ni null ni empty else false</returns>
        private static bool ValidarCamposIngresados(string usuario, string contrasena)
        {
            bool retorno = false;
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(contrasena))
            {            
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// metodo para invocar desde form. busca a travez de usuario y contrasena al empleado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns> Empleado en caso de que lo encontro,  null si no hay nada</returns>
        public static object? LogearUsuario(string usuario, string contrasena)//////////////////
        {
            Empleado aux = null;

            string usuarioaVerd;
            string contrasenaVerd;

            if (ValidarCamposIngresados(usuario, contrasena))//valido usuario y contrasena
            {
                  
                for (int i = 0; i < CoreDelSistema.empleados.LongCount(); i++)
                {
                       usuarioaVerd = CoreDelSistema.empleados[i].Usuario;
                       contrasenaVerd = CoreDelSistema.empleados[i].Contrasena;

                        if (usuarioaVerd == usuario && contrasenaVerd == usuario)
                        {
                          return empleados[i];
                        }

                }
                if (CoreDelSistema.empresa.Usuario == usuario && CoreDelSistema.empresa.Contrasena == contrasena)
                {
                    return CoreDelSistema.empresa;

                }


            }

            return aux;
        }

        //logica para agregar un nuevo pasajero 

        //valido que datos no sean nullos: nombre, apellido, edad, clase
        //valido que el pasaporte no sea nullo 
        //invoco agregar 

        public static bool AgregarPasajeroCamaroteTurista(Viaje viaje, Pasajero pasajero)
        {
            bool retorno = false;

            if (viaje is not null && pasajero is not null)
            {
                if (viaje.AgregarPasajeroCamaroteVacioTurista(pasajero))
                {
                    retorno = true;
                }
                
            }
        
            return retorno;
        }

        public static bool AgregarPasajeroCamarotePremium(Viaje viaje, Pasajero pasajero)
        {
            bool retorno = false;

            if (viaje is not null && pasajero is not null)
            {
                if (viaje.AgregarPasajeroCamaroteVacioPremium(pasajero))
                {
                    retorno = true;
                }

            }

            return retorno;
        }
        
        /// <summary>
        /// agrega viaje a la lista estatica viajes
        /// </summary>
        /// <param name="viaje"></param>
        /// <returns> true agregado con exito y false no lo agrego</returns>
        public static bool CrearViaje(Viaje viaje)
        {
            bool retorno = false;
         
            if (viaje is not null)
            {
                viaje.Barco.EstadoDelBarco = false;
                 CoreDelSistema.viajes.Add(viaje);              
                 retorno = true;               
            }
            return retorno;
        }
        
        #endregion METODOS

    }
}
