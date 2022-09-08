using System.Runtime.ConstrainedExecution;

namespace clase1_ejercicio2
{
    internal class Program
    {
        /*
        Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR.*/
        static void Main(string[] args)
        {
            float numero;
            float resultadoCubo;
            float resultadoCuadrado;
            bool confirm;



           do
           {
                Console.WriteLine("ingrese numero");//escribo por consola
                //numero = float.Parse(Console.ReadLine());//levanto dato de forma int
               confirm = float.TryParse(Console.ReadLine(), out numero);//valida que se ingrese un numero, devuelve true o false

            } while (numero < 0 || !confirm);

            Console.WriteLine("el numero es {0}",numero);
        }
    }
}