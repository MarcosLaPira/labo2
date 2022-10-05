
using clase6_Entidades;
namespace clase6_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Jugador j1 = new Jugador(444,"Marcos");

            Equipo e1 = new Equipo(3, "boca");
            Equipo e2 = new Equipo(3, "excurio");

            Console.WriteLine($" conteo al crear boca: {e1.ConteoEstatico}");
            
            Console.WriteLine($" conteo al crear boca: {e1.ConteoEstatico}");

            Console.WriteLine(e1.ConteoEstatico);


            //Equipo e1 = new Equipo(3,Marquitos);
        }
    }
}