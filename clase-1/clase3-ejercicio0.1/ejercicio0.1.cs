using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3_ejercicio0._1
{
    public class Animal
    {
        //ATRIBUTOS(caracteristicas-datos)   vendrian a ser los campos(no llamar asi)
     
        public string nombre;     
        public int edad;
        public string tipoDeAnimal;
        public static int contadorDeAnimales;

        static Animal()
        {
            Animal.contadorDeAnimales = 0;
        }
        
        //CONSTRUCTOR  inicializo los atributos por defecto
        public Animal()
        {
            Animal.contadorDeAnimales++;
            this.nombre = "sin nombre";
            this.edad = 0;
            this.tipoDeAnimal = "desconocido";
        }
        
        //CONSTRUCTOR  inicializo los atributos pidiendo parametros
        public Animal(string nombreNuevo, int edadNuevo, string animalNuevo)
        {
            Animal.contadorDeAnimales++;
            this.nombre= nombreNuevo;
            this.edad = edadNuevo;
            this.tipoDeAnimal = animalNuevo;
        }


        //METODOS(comporatamientos-acciones)    vendrian a ser las funciones(no llamar asi)
        public string Hablar()
        {
            StringBuilder sb = new StringBuilder();//es una clase que sirve para generar textos largos concatenados se guarda todo en sb
                                                   
            sb.AppendLine("mi nombre es " + this.nombre);
            sb.AppendLine("tengo " + this.edad.ToString() + "anos");
            sb.AppendLine("soy " + this.tipoDeAnimal);

            //return $"mi nombre es {this.nombre} y soy un {this.tipoDeAnimal}";
            return sb.ToString();
        }

        //hablar
        //comer
    }
}
