using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_Libreria
{
    public class DirectorTecnico:Persona
    {
        DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre):base(nombre)
        { 

        }
        public DirectorTecnico(string nombre, DateTime fechaDeNacimiento):this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public string MostrarDatos()
        {
            StringBuilder sb= new StringBuilder();

            sb.AppendLine(MostrarDatosss());
            sb.AppendLine(this.fechaDeNacimiento.ToString());
            
            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            bool retorno = false;
            if (dt1.Dni == dt2.Dni && dt1.fechaDeNacimiento == dt2.fechaDeNacimiento)
            {
                retorno = true;

            }
            return retorno;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
