using Entidades;
namespace clase3_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            DateTime dt = new DateTime(2001,07,4);
           
            Persona persona1 = new Persona("marcos", dt, "44892562");
           

            Console.WriteLine(persona1.Mostrar());
        }
    }
}