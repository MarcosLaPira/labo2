namespace clase3_ejercicio0._1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Animal animal1;//creo un objeto 
            animal1 = new Animal("ela",6,"perro");  //instancio una clase (es el constructor) -> reservas espacio

            /*
            //le doy un valor a los atributos PARA ANIMAL1
            animal1.nombre = "juan";
            animal1.edad = 12;
            animal1.tipoDeAnimal = "perro";

            //creo un objeto e instancio una clase
            Animal animal2 = new Animal();
            //le doy un valor a los atributos PARA ANIMAL2
            animal2.nombre = "ela";
            animal2.edad = 5;
            animal2.tipoDeAnimal = "gato";
            */



            //animal1.Hablar();
            Console.WriteLine(animal1.Hablar());
           // Console.WriteLine(animal2.Hablar());

        }
    }
}