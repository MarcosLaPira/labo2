using System.Threading;
using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Entidades
{
    /*
    Deberá tener los atributos:
    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    Construir los siguientes métodos para la clase:
    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta.Si el monto ingresado es negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta.La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
    */
    public class Cuenta
    {
        //atributos
        public string titular;
        public decimal cantidad;

        public Cuenta()// Un constructor que permita inicializar todos los atributos.
        {
            this.titular = "vacio";
            this.cantidad = 0;
        }
        public Cuenta(string titular, decimal cantidad)// Un constructor que permita inicializar todos los atributos.
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string ObtenerTitular()//geter para obtener titular
        {
            return this.titular;
        }
        public decimal ObtenerCantidad()//geter para obtener cantidad de cuenta 
        {
            return this.cantidad;
        }

        public string Mostrar()//metodo para mostrar al final el mensaje 
        {
            StringBuilder sb = new StringBuilder();//es una clase que sirve para generar textos largos concatenados se guarda todo en sb

            sb.AppendLine(" el titular es " + this.titular);
            sb.AppendLine("y tiene " + this.cantidad.ToString() + " de plata");


            //return $"mi nombre es {this.nombre} y soy un {this.tipoDeAnimal}";
            return sb.ToString();
        }

        public bool Ingresar(decimal cantidadAIngresar)//ingreso a la cuenta 
        {
            bool retorno = false;
            if (cantidadAIngresar > 0)
            {
                decimal nuevaCantidad = cantidadAIngresar + this.cantidad;
                this.cantidad = nuevaCantidad;
                retorno = true;
            }

            return retorno;

        }
        public bool Retirar(decimal cantidadARetirar)
        {
            bool retorno = false;
            if (cantidadARetirar > 0)
            {
                decimal cantidad = ObtenerCantidad();
                decimal nuevaCantidad = cantidad - cantidadARetirar;
                this.cantidad = nuevaCantidad;
                retorno = true;
            }

            return retorno;
        }



    }
    /*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.
    Deberá tener los atributos:
    nombre
    fechaDeNacimiento
    dni
    Deberá tener un constructor que inicialice todos los atributos.
    Construir los siguientes métodos para la clase:
    Setter y getter para cada uno de los atributos.
    CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
    Instanciar 3 objetos de tipo Persona en el método Main.
    Mostrar quiénes son mayores de edad y quiénes no.
    */
    public class Persona
    {
        //atributos
        public string nombre;
        public DateTime fechaDeNaciemiento;
        public string dni;

        //constructor 
        public Persona()
        {
            this.nombre = "vacio";
            this.fechaDeNaciemiento = new DateTime();
            this.dni = "vacio";
        }
        public Persona(string nombre, DateTime fechaDeNaciemiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNaciemiento = fechaDeNaciemiento;
            this.dni = dni;
        }

        // Setter y getter para cada uno de los atributos.
        //GETERS
        public string ObtenerNombre()
        {
            return this.nombre;
        }

        public DateTime ObtenerFechaDeNaciemiento()
        {
            return this.fechaDeNaciemiento;
        }
        public string ObtenerDni()
        {
            return this.dni;
        }

        //SETERS
        public void SetearNombre(string nombre)
        {
            this.nombre = nombre;

        }
        public void SetearFechaDeNacimiento(DateTime fechaDeNaciemiento)
        {
            this.fechaDeNaciemiento = fechaDeNaciemiento;
        }

        public void SetearDni(string dni)
        {
            this.dni = dni;

        }

        //CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.

        private int CalcularEdad()
        {
            DateTime nacimiento = ObtenerFechaDeNaciemiento();

            DateTime hoy = DateTime.Today;//obtengo la fecha actual 
            int edad = hoy.Year - fechaDeNaciemiento.Year;//obtengo la cantidad de anos transcurridos
            if (fechaDeNaciemiento > hoy.AddYears(-edad))//me paro en el mismo ano. comparo mes y dia
            {
                edad--;
            }

            return edad;
        }

        //EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
        public string EsMayorDeEdad()//metodo para mostrar al final el mensaje 
        {
            string indicadorDeEdad = "es menor de edad";
            int edad = CalcularEdad();
            if (edad >= 18)
            {
                indicadorDeEdad = "es mayor de edad";
            }
            return indicadorDeEdad;
        }

        //Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.

        public string Mostrar()//metodo para mostrar al final el mensaje 
        {
            StringBuilder sb = new StringBuilder();//es una clase que sirve para generar textos largos concatenados se guarda todo en sb

            sb.AppendLine("el nombre es: " + ObtenerNombre());
            sb.AppendLine("su edad es:" + CalcularEdad());
            sb.AppendLine("su dni es: " + ObtenerDni());
            sb.AppendLine(EsMayorDeEdad());


            return sb.ToString();
        }




    }

    public class Estudiante
    {
        //atributos
        public string apellido;
        public string legajo;
        public string nombre;
        public int notaPrimerParcial;
        public int notaSegundoParcial;
        public static Random random;

        //constructores 

        static Estudiante()//constructor estatico
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)//constructor de instancia
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;


        }

        //seters
        public void SetearNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;

        }

        public void SetearNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        //metodos

        private int CalcularNotaFinal()
        {
            int nota1 = this.notaPrimerParcial;
            int nota2 = this.notaSegundoParcial;
            int notaFinal;



            if (nota1 >= 4 && nota2 >= 4)
            {
                Random numeroRand = new Random();
                notaFinal = numeroRand.Next(6, 10);
            }
            else
            {
                notaFinal = -1;
            }

            return notaFinal;
        }

        public string Mostrar()//metodo para mostrar al final el mensaje 
        {
            int notaFinal;
            float promedio;
            StringBuilder sb = new StringBuilder();//es una clase que sirve para generar textos largos concatenados se guarda todo en sb

            sb.AppendLine("el nombre es: " + this.nombre);
            sb.AppendLine("el apellido es: " + this.apellido);
            sb.AppendLine("el legajo es: " + this.legajo);
            sb.AppendLine("la nota del primer parcial es: " + this.notaPrimerParcial);
            sb.AppendLine("la nota del segundo parcial es: " + this.notaSegundoParcial);
            notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine("la nota final es:" + notaFinal);
            }
            else
            {
                sb.AppendLine("alumno desaprobado");
            }
            promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
            sb.AppendLine("el promedio es:" + promedio);


            return sb.ToString();
        }



    }
    
    public class Boligrafo
    {
        //ATRIBUTOS
        const short CantidadDeTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)//constructor de instancia
        {
           this.tinta = tinta;
            this.color = color;
        }

        //GETERS
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }


        //METODOS
        
        
        private void SetTinta(short tinta)//seteo datos en this.tinta
        {
            short tintaActual = GetTinta();//tanque 
            if (tinta >= 0 && tinta <= CantidadDeTintaMaxima)//opcion cargar tinta //verfico que sea mayor a 0 y menor a la cantidad de tinta maxima
            {
                if ((tintaActual + tinta) <= CantidadDeTintaMaxima)//verifico que al cargar la tinta mas la tinta que ya tengo no sobrecargue
                {
                     this.tinta = tinta;//seteo tanque
                }
                   
            }
            else//en caso de ser negativo(gastar)
            {
                if ((tintaActual - tinta) >= 0)//verfico que al momento de gastar no se gasta mas de lo que hay
                {
                    this.tinta = (short)(tintaActual - tinta);//realizo operacion gasto
                }
            }
        }

        public void Recargar()//recargo tinta al maximo
        {
            short tintaActual = GetTinta();
            short nivelARecargar;

            nivelARecargar = (short)(CantidadDeTintaMaxima - tintaActual);//verifico cuanto hace falta para llenar el nivel
            SetTinta(nivelARecargar);//recargo tinta
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short tintaAGastar;
            bool confirm = true;
            short tintaActual = GetTinta();
            Console.ForegroundColor = this.color;

           StringBuilder sb = new StringBuilder();//es una clase que sirve para generar textos largos concatenados se guarda todo en sb

            if (tintaActual == 0)//si el nivel de tinta es 0 devuelvo cadena vacia
            {
                sb.Append("nivel de tinta = 0");


            }
            else
            {
                if (gasto > tintaActual)//si la tinta a gastar es mayor de la que hay en el tanque, solo gasto la cantidad disponiblde del tanque
                {
                    SetTinta((short)-tintaActual);

                    for (int i = 0; i < tintaActual; i++)
                    {
                        sb.Append("*");

                    }
                }
                else
                {
                    SetTinta((short)-gasto);//si la tinta a gastar es menor al tanque, paso tinta a gastar
                    for (int i = 0; i < gasto; i++)
                    {
                        sb.Append("*");
                    }
                }
            }
           
            dibujo = sb.ToString();

            return confirm;
        }
    }

    /*
    public class Punto
    {
        //ATRIBUTIOS
        private int x;
        private int y;


        //GETERS
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }

        //constructor

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


    }

    public class Rectangulo
    {
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        private float area;
        private float perimetro;

        public  float GetArea()
        {
            return this.area;
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public float Area()
        {

            return;
        }
        public float Perimetro()
        {
            return;
        }

        public Rectangulo(Punto vertice1,Punto Vertice3)
        {
            
        }
    }
    */

    public class Camionero
    {
       private string nombre;
      public float[] arrayDiasKm;

        

        //ATRIBUTOS
        public Camionero(string camionero, float[] arrayKm)
        {
            this.nombre = camionero;
            this.arrayDiasKm = arrayKm;
        }

        //PROPIEDADES
        public string Nombre 
        {
            set { this.nombre = value;}
            get { return this.nombre; } 
        }

        public float[] ArrayDiasKm
        {
            set { this.arrayDiasKm = value; }
            get { return this.arrayDiasKm; }
        }




    }

    public class Empresa
    {
        //ATRIBUTOS
       private Camionero[] arrayConductores;//un camionero completo con nombre y los 7 km

        //CONSTRUCTOR
        /// <summary>
        /// Constructor que espera aray de conductores
        /// </summary>
        /// <param name="arrayConductores"></param>

        public Empresa(Camionero[] arrayConductores)
        {
            this.arrayConductores = arrayConductores;         
        }

        //propiedad
        
        public Camionero[] ArrayConductores
        {
            set { arrayConductores = value; }
            get { return this.arrayConductores;}
        }
        
        //METODOS

      //  El conductor que hizo más km en esa semana.
        public string CalculoDeMayorkmEnLaSemana()
        {
            string ganador ;
            float buffer ;//porque tengo que darle un valor
            int  indiceConductorConMasKm = -1;//por que tengo qe darle un valor
          

           // float tamanio = ArrayDiasKm.Length;

            for (int j =0; j < arrayConductores.Length;j++)
            {

                buffer = arrayConductores[j].ArrayDiasKm.Sum();//suma de km de un conductor
                if (j == 0 ) 
                {                  
                    indiceConductorConMasKm = j;
                }
                else
                {                
                    if (buffer > arrayConductores[indiceConductorConMasKm].ArrayDiasKm.Sum())
                    {
                        
                        indiceConductorConMasKm = j;
                    }
                }
            }

            ganador = RetornoConductorByIndice(indiceConductorConMasKm);//llamo a funcion que devuelve ganador
         
            return ganador;
        }

        /// <summary>
        /// Retorna string ganador a travez del indice que recibe por parametro
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public string RetornoConductorByIndice(int indice)
        {
            string nombreCamioneroGanador;
            Camionero unCamionero = ArrayConductores[indice];//recibo un camionero completo

            nombreCamioneroGanador = unCamionero.Nombre;//busco en el camionero el nomnre

            return nombreCamioneroGanador;//retorno
        }

        /// <summary>
        /// Recibe un numero de dia a evaluar y retorna el camionero con mas km en ese dia
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>

        public string CalculoDeMayorkmEnDiaDeterminado(int dia)
        {
            int indiceConductorConMasKm=-1;
            string nombreCamioneroGanador;
            float buffer;
            Camionero[] arrayConductores = ArrayConductores;


            for (int j = 0; j < arrayConductores.Length; j++)
            {

                buffer = arrayConductores[j].ArrayDiasKm[dia];//suma de km de un conductor
                if (j == 0)
                {
                    indiceConductorConMasKm = j;
                }
                else
                {
                    if (buffer > arrayConductores[indiceConductorConMasKm].ArrayDiasKm[dia])
                    {
                        indiceConductorConMasKm = j;
                    }
                }
            }

             nombreCamioneroGanador = RetornoConductorByIndice(indiceConductorConMasKm);
                
             return nombreCamioneroGanador;//retorno
        }

    }

   
    





}
