namespace clase2_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int resultado;
            bool flagUno;
            do
            {
                Console.WriteLine("ingresar  numero");
                flagUno = int.TryParse(Console.ReadLine(), out numeroUno);
            } while (!flagUno);

            for (int i = 1; i < 10; i++)
            {
                resultado = numeroUno * i;                         
                Console.WriteLine("{0} x {1} = {2}", numeroUno, i, resultado);
            }

            Console.WriteLine("Tabla de multiplicar del número {0}",numeroUno);
           
        }
    }
}