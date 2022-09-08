using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_calculadoraDeAreas
{
    public class CalculoDeArea
    {
    public static double CalcularAreaCuadrado(double longitudLado) 
     {
            double resultado=0;
            resultado = longitudLado* longitudLado;
            return resultado;
     }

    public static double CalcularAreaTriangulo(double bases, double altura)
    {
            double resultado = 0;
            resultado = bases * altura;
            return resultado;
    }

    public static double CalcularAreaCirculo(double radio) 
        {
            double resultado;
            resultado = Math.PI * Math.Pow(radio, 2);/* La función Math. pow() retorna la base elevada al exponente ,
                                                      * es decir, baseexponente . La base y el exponente estan en el sistema numérico decimal*/

            return resultado;
        }
    }
}
