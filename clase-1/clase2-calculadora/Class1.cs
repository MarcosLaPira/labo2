using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_calculadora
{
    public static class Calculadora
    {
        public static float Calcular(int numeroUno, int numeroDos, char operacion)
        {
            float resultado = 0 ;
            float hola;
            bool retornoDivision;

            switch (operacion)
            {
                case '+':
                    resultado = numeroUno + numeroDos;
                    break;

                case '-':
                    resultado = numeroUno - numeroDos;
                    break;

                case '/':

                    retornoDivision = ValidarOperando(numeroDos);
                    if (retornoDivision)
                    {
                        resultado = numeroUno / numeroDos;
                    }
                    else 
                    {
                        Console.WriteLine("error en operando");
                    }
                     
                    break;

                default:
                    resultado = numeroUno * numeroDos;
                    break;
            }
            
            return resultado;
        }
        private static bool ValidarOperando(int numeroOperando)
        {
            bool retorno = false;
            if (numeroOperando != 0)
            {
               retorno = true;
            }
            return retorno;
        }
    }
}
