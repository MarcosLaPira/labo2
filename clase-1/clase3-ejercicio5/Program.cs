using Entidades;
namespace clase3_ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            float[] kmPorSemanaConductor1 = new float[7];//reservamos un array de flotantes 
            float[] kmPorSemanaConductor2 = new float[7];//reservamos un array de flotantes 
            float[] kmPorSemanaConductor3 = new float[7];//reservamos un array de flotantes 

            Random numero = new Random();
            //asignacion de km

            for(int i=0; i<kmPorSemanaConductor1.Length;i++)//conductor 1
            {
                kmPorSemanaConductor1[i] = numero.Next(0, 100);
            }

            for (int i = 0; i < kmPorSemanaConductor2.Length; i++)//conductor 2
            {
                kmPorSemanaConductor2[i] = numero.Next(0, 100);
            }

            for (int i = 0; i < kmPorSemanaConductor3.Length; i++)//conductor 3
            {
                kmPorSemanaConductor3[i] = numero.Next(0, 100);
            }

            // crear un array de conductores // reservo lugar para 3 conductores
            Camionero[] conductores = new Camionero[3];

            //objetos
            Camionero conductor1 = new Camionero("juan", kmPorSemanaConductor1);//le paso el nombre y los km por semana
            Camionero conductor2 = new Camionero("hernan", kmPorSemanaConductor2);//le paso el nombre y los km por semana
            Camionero conductor3 = new Camionero("miriam", kmPorSemanaConductor3);//le paso el nombre y los km por semana

            //asigno objetos
            conductores[0] = conductor1;
            conductores[1] = conductor2;
            conductores[2] = conductor3;

            Empresa empresa = new Empresa(conductores);



            //El conductor que hizo más km en esa semana.
            string nombre = empresa.CalculoDeMayorkmEnLaSemana();
            Console.WriteLine(nombre);

            //El conductor que hizo más km el día 3.
            nombre = empresa.CalculoDeMayorkmEnDiaDeterminado(3);
            Console.WriteLine(nombre);

            //El conductor que hizo más km el día 5.
            nombre = empresa.CalculoDeMayorkmEnDiaDeterminado(5);
            Console.WriteLine(nombre);





        }
    }
}