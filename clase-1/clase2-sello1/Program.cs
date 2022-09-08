namespace clase2_sello1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";

            Console.WriteLine(Sello.Imprimir());//muestro hola munod

            Sello.Borrar();//borro mensaje


            Console.WriteLine(Sello.Imprimir());//muestro mensaje, no tiene nada


            Sello.mensaje = "hola mundo C#";//le doy un nuevo valor a mensaje 

            Sello.color = ConsoleColor.Red;//le doy un valor a color

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());

        }
    }
}