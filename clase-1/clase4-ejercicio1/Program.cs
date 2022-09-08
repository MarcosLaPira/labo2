using clase4_Entidades;

namespace clase4_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Sumador n1 = new Sumador();
            Sumador n2 = new Sumador();

            Console.WriteLine(n1.Sumar(2,2));
            Console.WriteLine(n1.Sumar("como","va"));
            Console.WriteLine((int)n1);

            Console.WriteLine( n1 | n2);
            Console.WriteLine( n1 + n2);


        }
    }


}