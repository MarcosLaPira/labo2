using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clase10_ejercicio1_guia
{
    public  class MiClase
    {
        public MiClase()
        {
            try
            {
                MetodoVacio();//llamo a mi metodo que lanza una excepcion
            }
            catch (Exception e)//capturo la excepcion
            {
                try
                {
                }
                catch
                {
                    
                }
            }            
        }
        public MiClase(InnerException )
        {
            try
            {
                MiClase           
            }
            catch
            { 
                 MiClase(e);
            }
        }
        public static void MetodoVacio()
        {
            throw new DivideByZeroException("Lanzo excepcion desde mi clase estatica");
        }
    }
}
