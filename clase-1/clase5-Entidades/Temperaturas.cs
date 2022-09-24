using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4_ejercicio5
{
    public class Fahrenheit
    {
        //atributos 
        private static double tempRespectoCelcius;
        private double cantidadFahrenheit;
        //constructores
        static Fahrenheit()
        {
            tempRespectoCelcius = 33.8;
        }

        public Fahrenheit(double cantidadFahrenheit)
        {
            this.cantidadFahrenheit = cantidadFahrenheit;
        }

        //propiedades
        public double CantidadFahrenheit
        {
            get => this.cantidadFahrenheit;
            set => this.cantidadFahrenheit = value;
        }


        //metodos

        public static double GetTempRespectoCelcius()
        {
            return tempRespectoCelcius;
        }

      /// <summary>
      /// recibe fareheint y lo trsnsforma en celcius
      /// </summary>
      /// <param name="f"></param>
        public static explicit operator Celcius(Fahrenheit f)
        {
            double conversion;
            double pasajeFahrenheit;

            pasajeFahrenheit = Convert.ToDouble(f.cantidadFahrenheit);//convierto farehient a doble 
            
            conversion = (pasajeFahrenheit - 32) * 0.55; //hago operacion, obtengo celcius pero tengo que pasarlo a doble 

            Celcius celcius = new Celcius(conversion);//instancio un nuevo celciu y debuelo el valor
            
            return celcius;//retorno celciu
        }

    }

        public class Celcius
        {
            //atributos 
            private double cantidadCelcius;
            private static double tempCelcius;
            //constructores
            static Celcius()
            {
                tempCelcius = 1;
            }
            public Celcius(double cantidad)
            {
                this.cantidadCelcius = cantidad;
            }



            //propiedades

            public double CantidadCelcius
            {
                get => this.cantidadCelcius;
                set => this.cantidadCelcius = value;
            }
            /*
        public static double GetTempRespectoCelcius()
        {
            return tempRespectoCelcius;
        }
            */

            //metodos

            /// <summary>
            /// Recibe celcius y los transforma a fahrenheit
            /// </summary>
            /// <param name="c"></param>
            public static explicit operator Fahrenheit(Celcius c)
            {

                double conversion;
                double pasajeCelcius;

                pasajeCelcius = Convert.ToDouble(c.cantidadCelcius);

                conversion = (pasajeCelcius * 1.8) + Fahrenheit.GetTempRespectoCelcius();

                Fahrenheit fahrenheit = new Fahrenheit(conversion);
                return fahrenheit;
            }
        }

    
}
