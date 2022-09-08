using System;

namespace clase2_pitagorasOrgulloso
{
    internal class Program
    {
        /*
        Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
    El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
    Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
    Mostrar el resultado en la consola.
        */
        static void Main(string[] args)
        {
           
            double baseTriangulo;
            double alturaTriangulo;
            double resultado;

            do//pido base
            {
                Console.WriteLine("ingrese base de triangulo mayor a 0");
            } while (!double.TryParse(Console.ReadLine(), out baseTriangulo) || baseTriangulo < 0);

            do//pido altura
            {
                Console.WriteLine("ingrese altura de triangulo mayor a 0");
            } while (!double.TryParse(Console.ReadLine(), out alturaTriangulo) || alturaTriangulo < 0);

           

           // Console.WriteLine(Math.Sqrt(baseTriangulo));
            Math.Pow(baseTriangulo, 2);
            Math.Pow(alturaTriangulo, 2);

            resultado = Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2);
            Console.WriteLine("la hipotenusa es:{0}",resultado);

            Console.ReadKey();//mantiene la consola abierta



        }
    }
}