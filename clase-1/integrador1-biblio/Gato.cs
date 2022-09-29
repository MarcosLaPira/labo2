using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador1_biblio
{
    public class Gato:Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        { 
        }
        protected override string Ficha()
        {
            return $"{base.DatosCompletos()}";//invoco funcion de mascota
        }
        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;
            if (!(g1 is null || g2 is null))
            {
               retorno = (g1 == (Mascota)g2);
            }
            return retorno;
        }

        public static bool operator !=(Gato m1, Gato m2)
        {
            return !(m1 == m2);
        }

        //compara la instancia actual con el parametro que recibe 
        public override bool Equals(object obj) 
        {
            bool retorno = false;
            if (obj is Gato )//evaluo que lo que recibo sea un gato 
            {                                   //en caso de ser gato 
                retorno = this == ((Gato)obj);//evaluo si el objet es igual a lo que recibo
                                                // ej persona.Equals(persona2)
            }
            return retorno; 
        }


    }
}
