namespace clase1_ejercicio4
{
    internal class Program
    {
        /*
        Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros
        positivos(excluido el mismo) que son divisores del número.
    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
    Escribir una aplicación que encuentre los 4 primeros números perfectos.
        */
        static void Main(string[] args)
        {


            //declaro variables
            int numeroIngresado;
            int contador = 0;
            int acumulador = 0;
            bool flag;
            

            //pedir numero
            do {
                Console.WriteLine("ingrese numero mayor a 0");
                flag = int.TryParse(Console.ReadLine(), out numeroIngresado);
            } while (flag == false || numeroIngresado < 0);

            for (int i = 1; i < numeroIngresado; i++)
            {
                if (numeroIngresado % i == 0) //dentro del for, verifico con un if si numero % i == 0
                {
                    acumulador = acumulador + i;// en caso de ser verdadero guardo el numero en un acumulador 
                }
            }
            if (acumulador == numeroIngresado)
            {
                Console.WriteLine("el numero es perfecto");
            }
            else
            {
                Console.WriteLine("el numero no es perfecto");
            }

            Console.ReadKey();//mantiene la consola abierta





            // e incremento el contador en 1
        }
    }
}