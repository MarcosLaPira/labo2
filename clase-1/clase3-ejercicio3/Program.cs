using Entidades;
namespace clase3_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("marcos", "1234", "lapi");
            estudiante1.SetearNotaPrimerParcial(2);
            estudiante1.SetearNotaSegundoParcial(8);

            string mostrar = estudiante1.Mostrar();
            Console.WriteLine(mostrar);

        }
    }
}