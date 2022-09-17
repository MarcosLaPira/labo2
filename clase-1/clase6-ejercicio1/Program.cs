using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;
using Microsoft.VisualBasic;

namespace clase6_ejercicio1
{
    /*
    Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos)
    distintos de cero de forma aleatoria utilizando la clase Random.
    Mostrar el vector tal como fue ingresado.
    Luego mostrar los positivos ordenados en forma decreciente.
    Por último, mostrar los negativos ordenados en forma creciente.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            /*
            int[] numeros = new int[20];
            Console.WriteLine("Hello, World!");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0);
            }
            foreach (var iteracion in numeros)
            {
                Console.WriteLine(iteracion);
            }
            */

            List<int> list = new List<int>();//instancio una lista
   
           
            
           
            //cargo valores para list
            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-100,100));//agrego valores
            }

            //muesto vector como fue cargado
            Console.WriteLine("ordenamiento como fue cargado");        
            foreach (var iteracion in list)
            {
                Console.WriteLine(iteracion);
            }

            // Luego mostrar los positivos ordenados en forma decreciente.
            Console.WriteLine("ordenamiento de positivos decreciente");
            list.Sort();
            foreach (var iteracion in list)
            {
                if (iteracion > 0)
                {
                    Console.WriteLine(iteracion);                    
                }
            }

           // mostrar los negativos ordenados en forma creciente.
            Console.WriteLine("ordenamiento de negativos creceinte");
            list.Reverse();//ordeno lista de forma decreciente         
            foreach (var iteracion in list)
            {
                if (iteracion < 0)
                {
                    Console.WriteLine(iteracion);                  
                }
            }

        }
    }
}