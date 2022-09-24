using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase7_Entidades
{
    public class PuestoDeAtencion
    {
        #region ATRIBUTOS

        private static int numeroActual;
       private  EPuesto puesto;

        #endregion ATRIBUTOS

        #region PROPIEDADES
        public static int NumeroActual
        {
           
            get 
            {
                numeroActual++;
                return numeroActual;
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTOR
        static PuestoDeAtencion()
        {
            numeroActual = 0;
        }
        public PuestoDeAtencion(EPuesto puesto)
        {
          this.puesto = puesto;//seteo pueso de atencion
        }

        #endregion CONSTRUCTOR

        #region METODOS

        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if (cli is not null)
            {
                retorno = true;
                 Thread.Sleep(2000);
            }
            

            return retorno;
        }


        #endregion METODOS
    }
}
