namespace clase2_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro variebles
            int numeroIngresado;
            int numeroMaximo =0;
            int numeroMinimo=0 ;
            float promedio = 0;
            int acumulador=0;
            bool flag;
           


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese numero");
                flag = int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (!flag  || !ClaseEstatica.ValidarRango(numeroIngresado, 100, -100))
                {
                    Console.WriteLine("error, ingrese numero");
                    flag = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                if (i == 0)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > numeroMaximo)
                    {
                        numeroMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMinimo)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                        
                }

                acumulador = numeroIngresado + acumulador;
               
            }
            promedio = acumulador / 10;
            
            Console.WriteLine("maximo{0} " ,numeroMaximo);
            Console.WriteLine("minimo{0} ", numeroMinimo);
            Console.WriteLine("maximo{0} ", promedio);
           



        }
    }
}