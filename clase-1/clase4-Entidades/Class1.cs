using System.Net;
using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace clase4_Entidades
{
    public class Sumador
    {
        //atributos
        private int cantidadSumas;

        //constructores
        public Sumador(int cantidadSumas)//inicializa cantidadSumas en el valor recibido por parámetro.
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)//inicializa cantidadSumas en cero. Reutilizará al primer constructor.
        {
           
        }

        //metodos

       public int CantidadSumas 
        {
           get { return cantidadSumas; }
                
        }

        public long Sumar(long n1, long n2)//En el caso de Sumar(long, long) sumará los valores numéricos
        {
            this.cantidadSumas++;
            return n1 + n2;
        }

        public string Sumar(string cadena1, string cadena2)//n el de Sumar(string, string) concatenará las cadenas de texto.
        {
            this.cantidadSumas++;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{cadena1 } {cadena2}");

            return sb.ToString();
        }

        //SOBRECARGA    

 //Generar una conversión explícita que retorne cantidadSumas.
        public static explicit operator int(Sumador n1)//si hay perdida de datos
        {
            return n1.cantidadSumas;
        }


  //   Sobrecargar el operador + (suma) con dos operadores de tipo Sumador.El resultado será un long 
  //     correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.
        public static long operator +(Sumador n1, Sumador n2)
        {
            return (n1.cantidadSumas + n2.cantidadSumas);   
        }


  //Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador.
  //Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
        public static bool operator |(Sumador n1, Sumador n2)
        {
            return n1.cantidadSumas == n2.cantidadSumas;
        }

    }

    public class Dolar
    {
        //ATRIBUTOS
        private double cantidad;
        static double cotzRespectoDolar;



       

        static Dolar()
        {
            cotzRespectoDolar = 102.65;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        explicit operator Euro(Dolar d)
        {
            return ;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
    }

    public class Peso
    {
        //ATRIBUTOS
        private double cantidad;
        static double cotzRespectoDolar;


        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar= cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
          
    }

    public class Euro
    {
        //ATRIBUTOS
        private double cantidad;
        static double cotzRespectoDolar;


        static Euro()
        {
            cotzRespectoDolar = 0.84;// es igual a un dolar
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

    }




}