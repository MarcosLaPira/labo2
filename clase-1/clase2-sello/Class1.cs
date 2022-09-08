using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_sello
{
    public static class Sello
    {
        public static string mensaje;


        public static string Imprimir ()
        {
            return Sello.mensaje;
        }
        public static void Borrar()
        {
             Sello.mensaje = "";
        }
       
    }
    
}
