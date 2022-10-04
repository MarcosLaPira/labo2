using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public static class CoreDelSistema
    {
       
       
        static List<Viaje> viajes;
      
        static List<Empleado> empleados;
       


        static CoreDelSistema()
        {          
            viajes = new List<Viaje>();          
            empleados = new List<Empleado>();

            CargarEmpleados();
            CargarViajes();           
        }
       
      
        private static void CargarEmpleados()
        {
            empleados.Add(new("diego", "armando", 34, "dieguitobostero", "123", viajes));
            empleados.Add(new("roman", "riquelme", 40, "romiboca", "10", viajes));

        }

        /// <summary>
        /// creo 2 viajes enteros, cada viaje tiene 3 pasajeros, el primer viaje esta navegando el sagundo en puerto
        /// </summary>
        private static void CargarViajes()
        {


            viajes.Add(new(

                            new Barco("alfa123", "el destructor", 70, 1, 1, 2000, 250, false),

                             EDestinos.Miami,

                            EDestinos.Montevideo,

                            new DateTime(2022, 9, 10)


                            
       
                       )  );
            viajes[0].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "marcos",

                                                                        "lapi",

                                                                        19,

                                                                        new Pasaporte("marcos", "lapi", 19, "argentina", new DateTime(2003, 7, 4), new DateTime(2023, 7, 4)),

                                                                        EClasePasajero.Premium

                                                                        ));

            viajes[0].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "pichi",

                                                                        "fer",

                                                                        40,

                                                                        new Pasaporte("pichi", "fer", 40, "argentina", new DateTime(1945, 7, 4), new DateTime(2043, 7, 4)),

                                                                        EClasePasajero.Premium

                                                                         ));
            viajes[0].AgregarPasajeroCamaroteVacioTurista(new Pasajero(

                                                                        "lauti",

                                                                        "esco",

                                                                        17,

                                                                        new Pasaporte("lauti", "esco", 17, "indonesiA", new DateTime(2005, 7, 4), new DateTime(2022, 7, 4)),

                                                                        EClasePasajero.Turista

                                                                        ));

            viajes.Add(new(

                           new Barco("beta", "sin descenso", 150, 3, 0, 6000, 500, true),

                            EDestinos.Lima,

                           EDestinos.NuevaYork,

                           new DateTime(2023, 10, 10)

                         

                      ));
            viajes[1].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "aldo",

                                                                        "norque",

                                                                        34,

                                                                        new Pasaporte("aldo", "norque", 34, "suiza", new DateTime(1986, 2, 24), new DateTime(2045, 3, 14)),

                                                                        EClasePasajero.Premium

                                                                        ));
            viajes[1].AgregarPasajeroCamaroteVacioPremium(new Pasajero(

                                                                        "oscar",

                                                                        "romeo",

                                                                        56,

                                                                        new Pasaporte("oscar", "romeo", 56, "ucrania", new DateTime(1945, 12, 12), new DateTime(2023, 7, 4)),

                                                                        EClasePasajero.Premium

                                                                        ));
            viajes[1].AgregarPasajeroCamaroteVacioTurista(new Pasajero(

                                                                        "flavio",

                                                                        "nazaret",

                                                                        22,

                                                                        new Pasaporte("flavio", "nazaret", 17, "iran", new DateTime(1999, 5, 14), new DateTime(2022, 7, 4)),

                                                                        EClasePasajero.Turista

                                                                        ));


        }
       
    }
}
