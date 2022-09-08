using Entidades;
namespace clase3_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool flagOpcion;

            short nivelAPintar;
            bool flagNivelPintar;
            bool confirmPintar;

            char operacion;

            short gastol;
            string mensaje;

            Boligrafo boligrafo1 = new Boligrafo(10, ConsoleColor.Blue);

         
            

            do
            {
                do
                {
                    Console.WriteLine("ingrese numero: 1- Recargar tinta, 2- para pintar");
                    flagOpcion = int.TryParse(Console.ReadLine(), out opcion);//parseo numero y valido que se puo hacer bien 

                } while (opcion < 0 || flagOpcion == false);//si es menor a 0 o no se pudo parsear vuelvo a pedir 

                switch (opcion)
                {
                    case 1://recargo tinta al maximo

                        boligrafo1.Recargar();//llamo a recargar

                        break;

                    case 2://pintar
                           
                        do//pido ingreso de tinta que desea gastar
                        {
                            Console.WriteLine("ingrese nivel a pintar");
                            flagNivelPintar = short.TryParse(Console.ReadLine(), out nivelAPintar);//parseo numero y valido que se pudo hacer bien 

                        } while (opcion < 0 || flagNivelPintar == false);//si es menor a 0 o no se pudo parsear vuelvo a pedir 

                        confirmPintar = boligrafo1.Pintar(nivelAPintar, out mensaje);

                        Console.WriteLine("nivel de tinta gastado: {0}", mensaje);
                        //Console.ReadKey();//mantiene la consola abierta


                        break;
                }
                Console.WriteLine("si desea continuar presione 's' ");
                operacion = Convert.ToChar(Console.ReadLine());

             }while (operacion == 's') ;

        }
            

        

    }
}