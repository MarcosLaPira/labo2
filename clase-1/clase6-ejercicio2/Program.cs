using Microsoft.VisualBasic;
using System;
using System.Collections.Immutable;
using System.Runtime.Intrinsics.X86;

namespace clase6_ejercicio2
{
    internal class Program
    {
        /*
         * Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 
         * números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

        Mostrar la colección tal como fue cargada.
        Luego mostrar los positivos ordenados en forma decreciente.
        Por último, mostrar los negativos ordenados en forma creciente.
         * */
        static void Main(string[] args)
        {
       
            Random random = new Random();


            /// LISTA ///
            List<int> list = new List<int>();//instancio una lista
            Console.WriteLine("LISTA");
            for (int i = 0; i < 20; i++)  //cargo valores para list
            {
                list.Add(random.Next(-100, 100));//agrego valores
            }

            Console.WriteLine("ordenamiento como fue cargado la list");      
            
            foreach (var iteracion in list)//muestro lista
            {
                Console.WriteLine(iteracion);
            }



            //mostrar negetivos de forma creciente
            Console.WriteLine("mostrar negativos en forma creciente en lista:");
            list.Sort();//ordeno lista de forma crcreciente
            foreach (var iteracion in list)
            {
                if (iteracion < 0)
                {
                    Console.WriteLine(iteracion);
                }
            }
            //mostrar positivos de forma decreciente
            Console.WriteLine("mostrar positivos de forma decrecient en lista:");
            list.Reverse();//ordeno lista de forma decreciente         
            foreach (var iteracion in list)
            {
                if (iteracion > 0)
                {
                    Console.WriteLine(iteracion);
                }
            }

            /// PILA ///
             
            Stack<int> stack = new Stack<int>();//instancio pila    //ultimo en entrar primero en salir
            Console.WriteLine("PILA");
            for (int i = 0; i < 20; i++) //cargo valores para stack(pila)  
            {
                stack.Push(i);
                //stack.Push(random.Next(-100,100));
            }
            Console.WriteLine("muestro valores como fueron cargados");
            foreach (var iteracion in stack)//muestro valores como fueron cargados
            {
                Console.WriteLine(iteracion);
            }

            List<int> bufferStack = new List<int>(stack);//instancio una lista temporal para ordenar stack

            Console.WriteLine("mostrar negativos de forma creciente ");
            //mostrar negativos de forma creciente
            bufferStack.Sort();//ordeno lista de forma decreciente         
            foreach (var iteracion in bufferStack)
            {
                if (iteracion < 0)
                {
                    Console.WriteLine(iteracion);
                }
            }
          

            Console.WriteLine("mostrar positivos de forma decreciente");
            //mostrar positivos de forma decreciente
            bufferStack.Reverse();//ordeno lista de forma decreciente         
            foreach (var iteracion in bufferStack)
            {
                if (iteracion > 0)
                {
                    Console.WriteLine(iteracion);
                }
            }

            Console.WriteLine("QUEUE");
            Queue<int> valuesQueue = new Queue<int>();
          
            //cargo valores para cola enqueque  //primero en entrar primero en salir
            for (int i = 0; i < 20; i++)
            {
                valuesQueue.Enqueue(i);
               //valuesQueue.Enqueue(random.Next(-100, 100));
           
            }

            Console.WriteLine("valores como fueron cargados");
            foreach (var iteracion in valuesQueue)//muestro valores como fueron cargados
            {
                Console.WriteLine(iteracion);
            }

            List<int> bufferqueue= new List<int>(valuesQueue);//instancio una lista temporal para ordenar stack


            //mostrar negativos de forma creciente
            Console.WriteLine("mostrar negativos de forma creciente ");
            bufferqueue.Sort();//ordeno lista de forma decreciente         
            foreach (var iteracion in bufferqueue)
            {
                if (iteracion < 0)
                {
                    Console.WriteLine(iteracion);
                }
            }
            //mostrar positivos de forma decreciente
            Console.WriteLine("mostrar positivos de forma decreciente");
            bufferqueue.Reverse();//ordeno lista de forma decreciente         
            foreach (var iteracion in bufferqueue)
            {
                if (iteracion > 0)
                {
                    Console.WriteLine(iteracion);
                }
            }
        }
    }
}