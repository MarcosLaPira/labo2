using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_sello1
{
    public static class Sello
    {
        public static string mensaje;// defino metodo
        public static ConsoleColor color ; //defino metodo
         

        public static string Imprimir()
        {
            return Sello.mensaje;
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color; 
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

    }
}
