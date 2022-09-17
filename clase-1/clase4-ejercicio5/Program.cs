

namespace clase4_ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celcius c1 = new Celcius(24);//instancio un oibjeto de tipo celciu

            Fahrenheit f1 = new Fahrenheit(73);

            Console.WriteLine("cantidad de grados instanciados");
            Console.WriteLine(c1.CantidadCelcius);

            Console.WriteLine("cantidad de grados pasados a fahereint");
            Fahrenheit auxFahrenheit = (Fahrenheit)c1;
            Console.WriteLine(auxFahrenheit.CantidadFahrenheit);

            Console.WriteLine("cantidad fahereint instanciados");
            Console.WriteLine(f1.CantidadFahrenheit);

            Console.WriteLine("cantidad de fahereint pasado a celcius");
            Celcius auxCelcius= (Celcius)f1;
            Console.WriteLine(auxCelcius.CantidadCelcius);

        }
    }
}