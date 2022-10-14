using System;

namespace clase10_ejercicio2
{
    internal class Program
    {
        /*
        Crear una clase que derive de Exception con una propiedad llamada Mensaje que concatene el mensaje que
            tiene como parámetro de entrada en el constructor con el ya existente.
        Realizar un burbujeo partiendo de un método, capturando y re lanzando esta misma excepción como mínimo 3 (tres)
            veces, creando los métodos que sean necesarios y colocando un nuevo mensaje por cada nuevo Throw 
            que se realice.
      */
        static void Main(string[] args)
        {
            try
            {
                NumeroEntero.Funcion1();
            }
            catch(DerExcepcion e)
            { 
                Console.WriteLine(e.Mensaje);
            }

            
        }
    }
}