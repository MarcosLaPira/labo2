namespace ConsoleApp1
{
    internal class Program
    {
        /*
        Ingresar 5 números por consola, 
            guardándolos en una variable escalar.
            Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/
        static void Main(string[] args)
        {
            int numero;
            int numeroMaximo=0;
            int numeroMinimo=0;
            int acumNum = 0;
            float promedio=0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese numero");
                numero =int.Parse(Console.ReadLine());//levanto dato de forma int

                if (i == 0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                }
                else
                {
                    if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }
                acumNum = numero + acumNum;
            }

            promedio = acumNum / 5;
            Console.WriteLine("el promedio es : {0} El maximo es: {1} El minimo es {2} ", promedio,numeroMaximo,numeroMinimo);//imprimo el 0 hace referencia al orde de variables luego de la coma
        }
    }
}