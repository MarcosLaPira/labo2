using System;
namespace clase2_sello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";

            Console.WriteLine(Sello.Imprimir());

            
            Sello.Borrar();

            Console.WriteLine(Sello.Imprimir());



        }
    }
}