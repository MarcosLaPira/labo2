namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int numero;
            // float numero2;
            // char letra = 'a';
            //  bool flag = false;
            //int[] numeros = new int[5]//declaro array
            string palabra;

            Console.WriteLine("ingresar palabra");//imprimir

            palabra = Console.ReadLine();//levanto dato

            Console.WriteLine("la palabra es: {0} ", palabra);//imprimo el 0 hace referencia al orde de variables luego de la coma

            Console.ReadKey();//mantiene la consola abierta
        }
    }
}