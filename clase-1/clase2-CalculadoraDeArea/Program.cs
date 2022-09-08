using System;
namespace clase2_CalculadoraDeArea
{
    /*
    Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase(estáticos) 
    que realicen el cálculo del área que corresponda:
    public double CalcularAreaCuadrado(double longitudLado) { }
    public double CalcularAreaTriangulo(double base, double altura) { }
    public double CalcularAreaCirculo(double radio) { }
    El ingreso de los datos como la visualización se deberán realizar desde el método Main().
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitudCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;
            bool flagCuadrado;

            double resultadoAreaCuadrado;
            double resultadoAreaTriangulo;
            double resultadoAreaCirculo;


            // area cuadrado
            do
            {
                Console.WriteLine("ingrese un lado del cuadrado");
               
            } while (!double.TryParse(Console.ReadLine(), out longitudCuadrado) || longitudCuadrado < 0);
            //base triangulo
            do
            {
                Console.WriteLine("ingrese la base del triangulo");

            } while (!double.TryParse(Console.ReadLine(), out baseTriangulo) || baseTriangulo < 0);

            do
            {
                Console.WriteLine("ingrese la altura del triangulo");

            } while (!double.TryParse(Console.ReadLine(), out alturaTriangulo) || alturaTriangulo < 0);

            do
            {
                Console.WriteLine("ingrese el radio del circulo");

            } while (!double.TryParse(Console.ReadLine(), out radioCirculo) || radioCirculo < 0);

            resultadoAreaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(longitudCuadrado);
            resultadoAreaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo) ;
            resultadoAreaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);

            Console.WriteLine(" el area del cuadrado es: {0} el area del triangulo es:{1} el area del circulo es:{2}",
                resultadoAreaCuadrado,resultadoAreaTriangulo,resultadoAreaCirculo );
            Console.ReadKey();//mantiene la consola abierta
        }
    }
}