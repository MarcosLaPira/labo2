using System.Security.Cryptography;
using System;

namespace clase1_ejercicio3
{
    internal class ejercicio3
    {
        /*
        Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
        Validar que el dato ingresado por el usuario sea un número.
        Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
        Si ingresa "salir", cerrar la consola.
        Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa,
        iterar.De lo contrario, cerrar la consola.
        */
        static void Main(string[] args)
        {

            double numero;
            double resultado;
            int bufferDivisible;
            bool flag;
            string continuar;

            do
            {
                do
                {
                    Console.WriteLine("ingresar numero mayor a 0");//pido numero al usuario
                    flag = double.TryParse(Console.ReadLine(), out numero);//parseo numero y valido que se puo hacer bien 

                } while (numero < 0 || flag == false);//si es menor a 0 o no se pudo parsear vuelvo a pedir 

                for (int i = 2; i < numero; i++)//comiezo bucle de iteracion con el numero a comparar
                {
                    bufferDivisible = 0;
                    for (int j = 1; j <= numero; j++)
                    {
                       
                        if ((i%j)==0)
                        {
                            bufferDivisible++;
                        }
                       
                                             
                    }
                    if (bufferDivisible == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
               

                Console.WriteLine("si desea finalizar, ingrese: salir");
                continuar = Console.ReadLine();//levanto dato

            } while (continuar != "salir");
          



          
        }
    }
}