namespace clase2_ElTiempoPasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro variables a usar

            int ano;
            int mes;
            int dia;
            
            DateTime dateTime;
            Console.WriteLine("Hello, World!");

          

            //pido ano 
            do
            {
                Console.WriteLine("ingrese año");
            } while (!int.TryParse(Console.ReadLine(), out ano) || ano < 0);
            //pido mes
            do
            {
                Console.WriteLine("ingrese mes");
            } while (!int.TryParse(Console.ReadLine(), out mes) || mes < 0);
            //pido dia
            do
            {
                Console.WriteLine("ingrese dia");
            } while (!int.TryParse(Console.ReadLine(), out dia) || dia < 0);

           

           dateTime = new DateTime(ano,mes,dia);//constructor de la fecha
            //dateTime.Subtract(DateTime.Now);//calculo dias que pasaron hasta la fecha de hoy//parametros: fecha construida y fecha actual.

            Console.WriteLine(dateTime.Subtract(DateTime.Now));
            Console.ReadKey();//mantiene la consola abierta
        }
    }
}