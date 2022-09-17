using clase4_ejercicio5;

namespace integrador2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Apellido y Nombre";//Cambiar por SU apellido y      SU nombre
            Cliente mauri = new Cliente(ETipoCliente.PoliticoCorrupto,"Mauri");
            Cliente fariña = new Cliente(ETipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(ETipoCliente.JugadorDeFutbol,
            "Lio");
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lázaro",
            ETipoCliente.EmpresarioCorrupto, 456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678, 50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);
            ParaisoFIscal panamaPappers = EParaisosFiscales.Panama;

            panamaPappers += messiOff;
            // bool buffer = panamaPappers + messiOff; //asi si me lo toma bien
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;
            panamaPappers.MostrarParaiso();
            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;
            panamaPappers.MostrarParaiso();
            Console.ReadLine();
        }
    }
}