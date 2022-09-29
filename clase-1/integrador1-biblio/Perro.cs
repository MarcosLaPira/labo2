using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace integrador1_biblio
{
    public class Perro:Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza):base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }
        public Perro(string nombre,string raza,int edad, bool esAlfa):this(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"edad: {this.edad}");
            if (this.esAlfa)
            {
                sb.AppendLine($"es alfa de la mandada");
            }
            

            return sb.ToString();
        }
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            if (p1 == (Mascota)p2)
            {
                if (p1.edad == p2.edad)
                {
                    retorno = true;
                }

            }
            return retorno;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        //
        public  override bool Equals(Object obj)
        {
            bool retorno = false;
            if (obj is Perro)//evaluo i es perro 
            {
                retorno = this == ((Perro)obj); //evaluo por el operator si la edad es igual
            }
            return retorno;
            
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public  static explicit  operator int(Perro perro)
        {
            int bufferEdad = 0;

            bufferEdad = perro.edad;

            return bufferEdad;
        }
        public override string ToString()
        {
            return this.Ficha();
        }


    }
}
