namespace clase1_ejercicio3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string respuesta;
            bool esPrimo;

            do
            {
                esPrimo = false;
                //Limpio la pantalla
                Console.Clear();
                Console.WriteLine("Ingrese un numero para saber si es primo");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))// leo consola y parseo numero 
                {
                    //Si el numero ingresado es mayor a 1 hay que verificar los divisores, sino no es primo
                    if (numeroIngresado > 1)
                    {
                        for (int i = 2; i < numeroIngresado; i++)
                        {
                            esPrimo = numeroIngresado % i != 0;
                            if (!esPrimo)
                            {
                                break;
                            }
                        }
                    }
                    if (esPrimo)
                    {
                        Console.WriteLine($"El numero {numeroIngresado} es primo");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numeroIngresado} no es primo");
                    }
                }
                //Si el texto ingresado no se pudo parsear muestro un error
                else
                {
                    Console.WriteLine("El valor ingresado no es valido. Verifique que haya ingresado un" +
                        "numero y pruebe nuevamente");
                }
                //Pregunto por otro ingreso
                Console.WriteLine("Desea ingresar otro numero? S/N");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "s");
        }
    }
}