namespace clase2_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            char operacion;
            float resultado;
            char  continuar;

            bool flagUno;
            bool flagDos;

            do
            {
                /*
                do
                {
                    Console.WriteLine("ingresar primer numero");
                    flagUno = int.TryParse(Console.ReadLine(), out numeroUno);
                } while (!flagUno);
                */
                do
                {
                    Console.WriteLine("ingresar primer numero");
                   // flagUno = int.TryParse(Console.ReadLine(), out numeroUno);
                } while (!int.TryParse(Console.ReadLine(), out numeroUno));

                do
                {
                    Console.WriteLine("ingresar segundo numero");
                    flagDos = int.TryParse(Console.ReadLine(), out numeroDos);
                } while (!flagDos);

                do
                {
                    Console.WriteLine("ingresar operacion deseada ('+' '-' '/' '*')");
                    operacion = Convert.ToChar(Console.ReadLine());
                } while (operacion != '+' && operacion != '-' && operacion != '/' && operacion != '*');


                resultado = Calculadora.Calcular(numeroUno, numeroDos, operacion);

                Console.WriteLine("el resulatdo es: {0}", resultado);

                Console.WriteLine("si desea continuar presione 's' ");
                operacion = Convert.ToChar(Console.ReadLine());
                
            }
            while (operacion == 's');


        }



    }
}