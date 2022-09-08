using Entidades;
namespace clase3_ejercicio1
{
    /*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
    Deberá tener los atributos:
    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    Construir los siguientes métodos para la clase:
    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta.Si el monto ingresado es negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta.La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro variables 
            int opcion;
            decimal dineroAIngresar;
            decimal dineroARetirar;
            char opcionPermanecer;
            bool flagIngresoDinero;
            bool flagExtraccionDinero;
            string mensajeMonto ;

            Cuenta usuario1 = new Cuenta();//creo objeto 

            do
            {

                //pregunto que desea hacer
                do
                {
                    Console.WriteLine("ingrese una opcion: 1-Para acreditar 2-Para retirar");
                }
                while (!int.TryParse(Console.ReadLine(), out opcion));

                switch (opcion)    //switch con lo que se va a hacer
                {
                    case 1://acreditacion

                        do
                        {
                            Console.WriteLine("ingrese el dinero a acreditar");
                        }
                        while (!decimal.TryParse(Console.ReadLine(), out dineroAIngresar));//verifico que ingrese un numero

                        flagIngresoDinero  = usuario1.Ingresar(dineroAIngresar);//hago operacion
                        if (flagIngresoDinero)//si la operacion salio bien 
                        {
                            Console.WriteLine(usuario1.Mostrar());//muestro estado de cuenta

                        }
                       

                    break;

                    default:
                        do
                        {
                            Console.WriteLine("ingrese el dinero a retirar");

                        }
                        while (!decimal.TryParse(Console.ReadLine(), out dineroARetirar));

                        flagExtraccionDinero = usuario1.Retirar(dineroARetirar);//hago operacion

                        if (flagExtraccionDinero)//si la operacion salio bien 
                        {
                            Console.WriteLine(usuario1.Mostrar());//muestro estado de cuenta

                        }

                        break;
                }

                Console.WriteLine("desea seguir haciendo operaciones? s/n"); //pregunto si desea permanecer en el programa
                opcionPermanecer = char.Parse(Console.ReadLine());

            }
            while (opcionPermanecer == 's');

        }
    }
}