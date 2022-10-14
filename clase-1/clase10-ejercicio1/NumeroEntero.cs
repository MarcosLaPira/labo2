using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10_ejercicio1
{
    public static class NumeroEntero
    {
        public static bool TryParser(string numero,out int numeroCasteado)
        {
            bool ret = true;
            numeroCasteado = 0;

            try//intento catear numero
            {
                numeroCasteado = int.Parse(numero);              
            }
            catch(Exception e)//entro en caso de no poder castear
            {
                Console.WriteLine("no fue posible catear numero");
                ret = false;
            }


            return ret;
        }

    }
}
