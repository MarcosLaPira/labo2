using System;
namespace clase2_sello2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo2";//asigno valpor a sello mensaje 


            Sello.color = ConsoleColor.Red;

                
            Sello.ImprimirEnColor();//llamo a imprimir en color


            Sello.Imprimir();//llamo a imprimir

        }
    }
}