using System;
namespace clase2_calculadoraDeAreas
{
    internal class Program
    {
        /*
            Realizar una clase llamada CalculadoraDeArea que 
            posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:      
            public double CalcularAreaCuadrado(double longitudLado) {}
            public double CalcularAreaTriangulo(double base, double altura) {}
            public double CalcularAreaCirculo(double radio) {}
         */
        static void Main(string[] args)
        {

            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;

            Console.WriteLine("Ingrese medida de un lado del cuadrado para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out ladoCuadrado))
            {
                Console.WriteLine("ERROR, vuelva a ingresar lado del cuadrado");
            }
            Console.WriteLine("Ingrese base del triangulo para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.WriteLine("ERROR, vuelva a ingresar base del triangulo");
            }
            Console.WriteLine("Ingrese altura del triangulo para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out alturaTriangulo))
            {
                Console.WriteLine("ERROR, vuelva a ingresar altura del triangulo");
            }
            Console.WriteLine("Ingrese radio del circulo para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out radioCirculo))
            {
                Console.WriteLine("ERROR, vuelva a ingresar radio del circulo");
            }
        }
    }
}