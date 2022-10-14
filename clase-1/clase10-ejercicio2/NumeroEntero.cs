using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace clase10_ejercicio2
{
    public static class NumeroEntero
    {
        public static void Funcion1()
        {
            try
            {
                Funcion2();
            }
            catch(DerExcepcion e)
            {
                throw new DerExcepcion( "exepcin metodo 1",e);//lanzo una excepcion y creo una nueva instancia 
            }
        }
        public static void Funcion2()
        {
            try
            {
                Funcion3();
                Console.WriteLine("hola");//no se ejecuta
            }
            catch (DerExcepcion e)
            {
                try
                {
                    throw new DerExcepcion("exepcin metodo 2", e);
                }
                catch (DerExcepcion es)
                {
                    throw new DerExcepcion("exepcin metodo 2 bis", es);
                }
            }

        }
        public static void Funcion3()
        {
            throw new DerExcepcion("exepcion de metodo 3");//lanzo excepcion
        }





    }
}
