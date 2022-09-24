using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace clase7_Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        #region PROPIEDADES
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public int Numero
        {
           
            get { return this.numero; }
        }
        #endregion PROPIEDADES

        #region METODOS

        public Cliente(int numero)
        { 
            this.numero = numero;
            this.nombre = "";
           
        }

        public Cliente(int numero, string nombre):this(numero)
        {
            this.nombre = nombre ;
        }
        #endregion METODOS

        #region SOBRECARGA

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool confirm = false;

            if (c1.Numero == c2.Numero)
            {
                confirm = true;
            }

            return confirm;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {          
            return !(c1 == c2);
        }

        #endregion SOBRECARGA

    }
}
