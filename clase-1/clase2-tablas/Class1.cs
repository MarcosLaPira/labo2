using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_tablas
{
    public static class StringBuilder
    {
        public static string ArmadoTablas(int numeroUno)
        {
            string buffer;
            


             for (int i=1; i< 10; i++)
            {
                resultado = numeroUno* i;
                StringBuilder sd = new StringBuilder(str);

                 Console.WriteLine("{0} x {1} = {2}",numeroUno,i,resultado);
            }
             
            return;
        }
    }
}
