using System.Runtime.CompilerServices;
using System.Text;

namespace clase5_Entidades
{
    public class Ingresante
    {
        //ATRIBUTOS
        private string cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
           
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.direccion);
            sb.AppendLine(this.edad.ToString());
            sb.AppendLine(this.genero);
            sb.AppendLine(this.pais);
            sb.AppendLine(this.cursos);

            return sb.ToString();
        }
    }
}