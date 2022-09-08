using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_CalculadoraDeArea
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double resultado = 0;
            resultado = longitudLado * longitudLado;
            return resultado;
        }
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        { 
            return baseTriangulo * altura;
        }
        public static double CalcularAreaCirculo(double radio)
        { 
            return Math.PI * Math.Pow(radio, 2);//funcion math pow,eleva la primer variable al numero que le digas
        }
    }
}
