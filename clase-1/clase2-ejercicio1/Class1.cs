using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_ejercicio1
{
    //la clase debe de ser publica
    public static class ClaseEstatica
    {
        public static bool ValidarRango( int datoAValidar, int maximoValor, int minimoValor)//me va a retornar un verdadero o falso
        {
           bool retorno = false;
            if (datoAValidar > minimoValor && datoAValidar < maximoValor)
            {
               retorno = true;
            }

            return retorno;
        }

    }
    
}
