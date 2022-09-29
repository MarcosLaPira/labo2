using System.Text;

namespace integrador1_biblio
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

     

        public string Nombre { get => nombre;  }
        public string Raza { get => raza;  }

        protected virtual string DatosCompletos()//protected pq por fuera de los herederos es inaccecible y virtual porque puede de ser sobreescrito
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre}");
            sb.AppendLine($"{this.raza}");

            return sb.ToString();
        }

        protected abstract string Ficha();//metodo abrstracto solamente brindo la firma las clases hijas estan obligadas a usarlo
       
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool retorno = false;
            if (m1.nombre == m2.nombre && m1.raza == m2.raza)
            {
                retorno = true;               
            }
            return retorno;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        /*
        public override bool Equals(Object obj)
        {
            bool retorno = false;
            if (obj is Mascota)//evaluo i es perro 
            {
                retorno = this == ((Mascota)obj); //evaluo por el operator si la edad es igual
            }
            return retorno;

        }
       */

    }
}