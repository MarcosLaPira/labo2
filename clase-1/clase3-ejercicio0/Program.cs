public class Bus
{
    // Atributo estático utilizada por todas las instancias de Bus.
    // Representa la hora en que el primer autobús del día inicia su ruta.
    public static DateTime horaDeInicio;

    //atributo de instancia
    public int numeroDeRuta;

    // Constructor estático para inicializar la variable estática. solo se ejecutara una vez,la primera vez
    // Se invoca antes de que se ejecute el constructor de la primera instancia.
    static Bus()
    {
        horaDeInicio = DateTime.Now;

        // La siguiente declaración produce la primera línea de salida,
        // y la línea aparece solo una vez.
        Console.WriteLine("El constructor estático establece la hora de inicio en {0}",
            horaDeInicio.ToLongTimeString());
    }

    // Constructor de instancia.
    public Bus(int numeroDeRuta)
    {
        this.numeroDeRuta = numeroDeRuta;
        Console.WriteLine("Bus #{0} creado.", numeroDeRuta);
    }

    // Metodo de instancia. 
    public void Conducir()
    {
        TimeSpan tiempoTrascurrido = DateTime.Now - horaDeInicio;

        // Para fines de demostración, tratamos los milisegundos como minutos para simular
        // tiempos reales de autobús. ¡No haga esto en su programa!
        Console.WriteLine("{0} está comenzando su ruta {1: N2} minutos después de la hora de inicio {2}.",
                                this.numeroDeRuta,
                                tiempoTrascurrido.Milliseconds,
                                horaDeInicio.ToShortTimeString());
    }
}

class TestBus
{
    static void Main()
    {
        // La creación de esta instancia activa el constructor estático.
        Bus bus1 = new Bus(71);

        // Crea un segundo autobús.
        Bus bus2 = new Bus(72);


        bus1.Conducir();

        // Espera 25 milisegundos
        System.Threading.Thread.Sleep(25);


        bus2.Conducir();


        Console.ReadKey();
    }
}
/* Sample output:
    El constructor estático establece la hora de inicio en 3:57:08 PM.
    Bus #71 creado.
    Bus #72 creado.
    71 está comenzando su ruta 6.00 minutos después de la hora de inicio 3:57 PM.
    72 está comenzando su ruta 31.00 minutos después de la hora de inicio 3:57 PM.
*/