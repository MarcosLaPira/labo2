namespace clase10_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int numeroOk;

            numero = "s";


            if (NumeroEntero.TryParser(numero, out numeroOk))//invoco funcion 
            {
                Console.WriteLine($"se pudo parciar el num es: {numeroOk}");
            }
            else
            {
                
                Console.WriteLine("no fue posible parciar");
            }
        }
    }
}