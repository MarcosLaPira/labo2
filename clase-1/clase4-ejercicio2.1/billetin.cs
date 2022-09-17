using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4_ejercicio2._1
{

    public class Dolar
    {
        private static double cotizRespectDolar;
        private double cantidad;

        #region CONSTRUCTORES
        static Dolar()
        {
            Dolar.cotizRespectDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region GETTERS
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES DE CONVERSION
        #region SOBRECARGA EXPLICITA
        public static explicit operator Euro(Dolar d)  //CONVIERTO EXPLICITAMENTE UN DOLAR A EURO  ej:  (Euro)dolar1.
        {
            double conversion;
            Euro euro;

            conversion = Euro.GetCotizacion() * d.cantidad; // 
            euro = new Euro(conversion);//instancia eur, es decir euro.cantidad = ...

            return euro;
        }

        public static explicit operator Peso(Dolar d)//CONVIERTO EXPLICITAMENTE UN PESO A DOLAR ej:  (Dolar)dolar1.
        {
            double conversion;
            Peso peso;

            conversion = Peso.GetCotizacion() * d.cantidad;
            peso = new Peso(conversion);//instancio euro

            return peso;
        }
        #endregion

        #region SOBRECARGA IMPLICITA
        public static implicit operator Dolar(double d)    // es para llmar desde otras clases
        {
            return new Dolar(d);
        }
        #endregion
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e; 
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            double resultado = d.cantidad + ((Dolar)e).cantidad;
            return new Dolar(resultado);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            double resultado = d.cantidad - ((Dolar)e).cantidad;
            return new Dolar(resultado);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            double resultado = d.cantidad + ((Dolar)p).cantidad;
            return new Dolar(resultado);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            double resultado = d.cantidad - ((Dolar)p).cantidad;
            return new Dolar(resultado);
        }
        #endregion

    }

    public class Euro
    {
        private static double cotizRespectDolar;
        private double cantidad;

        #region CONSTRUCTORES
        static Euro()
        {
            cotizRespectDolar = 1.0048; //1.17
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectDolar = cotizacion;
        }
        #endregion

        #region GETTERS
        public static double GetCotizacion()
        {
            return Euro.cotizRespectDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region SOBRECARGAS DE OPERADORES DE CONVERSION
        #region SOBRECARGAS EXPLICITAS
        public static explicit operator Dolar(Euro e)
        {
            double conversion;
            Dolar dolar;

            conversion = e.cantidad / Euro.cotizRespectDolar;
            dolar = new Dolar(conversion);

            return dolar;
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)(Dolar)e;
        }
        #endregion

        #region SOBRECARGAS IMPLICITAS
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        #endregion
        #endregion

        #region SOBRECARGAS DE OPERADORES
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return d == e;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return p == e;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return (Euro)(d + e);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            double resultado = e.cantidad - ((Euro)d).cantidad;
            return new Euro(resultado);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return (Euro)(p + e);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            double resultado = e.cantidad - ((Euro)p).cantidad;
            return new Euro(resultado);
        }
        #endregion

    }

    public class Peso
    {
        private static double cotizRespectDolar;
        private double cantidad;

        #region CONSTRUCTORES
        static Peso()
        {
            Peso.cotizRespectDolar = 139.1776; //102.65
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizRespectDolar ) : this(cantidad)
        {
            Peso.cotizRespectDolar = cotizRespectDolar;
        }
        #endregion

        #region GETTERS
        public static double GetCotizacion()
        {
            return Peso.cotizRespectDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES DE CONVERSION
        #region SOBRECARGA EXPLICITA
        public static explicit operator Dolar(Peso p)
        {
            double conversion;
            Dolar d;

            conversion = p.cantidad / Peso.cotizRespectDolar;
            d = new Dolar(conversion);

            return d;//devuelvo un nuevo dolar
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)(Dolar)p;
        }
        #endregion

        #region SOBRECARGA IMPLICITA

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        #endregion
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return d == p;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return (Peso)(d + p);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            double resultado = p.cantidad - ((Peso)d).cantidad;
            return new Peso(resultado);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            double resultado = p.cantidad + ((Peso)e).cantidad;
            return new Peso(resultado);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            double resultado = p.cantidad - ((Peso)e).cantidad;
            return new Peso(resultado);
        }
        #endregion

    }

}
