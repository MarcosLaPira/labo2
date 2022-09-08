using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_sello2
{
    public static class Sello
    {
        //atributos
        public static string mensaje;// defino metodo
        public static ConsoleColor color; //defino metodo


        public static string Imprimir()
        {
            Sello.mensaje = ArmarFormatoMensaje();//a mensaje le asigno el rotorno de ArmarFormatoMensaje();

            return Sello.mensaje;//retorno el mensaje ya armado
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());//imprimo en color con writeLine 
            Console.ResetColor();
        }
        private static string ArmarFormatoMensaje()
        {
            string asteriscos; // variable tipo string de asteriscos

            asteriscos  = new string('*',Sello.mensaje.Length);//por cada caracterer de mensaje genero un nuevo *
            Sello.mensaje = asteriscos + "\n" + Sello.mensaje + "\n" + asteriscos; // a Sello.mensaje le asigno este nuevo contenido

            return Sello.mensaje;// retoro el mensaje final. que se lo retorno a la linea 18.
        }

    }
}
