using System.Runtime.CompilerServices;

namespace clase6_Entidades
{
    public class Equipo
    {
        
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        static int conteoJugadores;

        static Equipo()
        {
            conteoJugadores = 0;
        }
        private Equipo()
        {
            jugadores = new List<Jugador>();
            this.nombre = "";
            this.cantidadDeJugadores = 0;
        }
        public Equipo(short cantidadDeJugadores, string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e1, Jugador j1)
        {
            bool retorno = false;
            foreach (Jugador jugador in e1.jugadores)
            {
                if (jugador != j1 && conteoJugadores < e1.cantidadDeJugadores)//evaluo si equipo contiene al jugador con sobrecarga
                {
                    conteoJugadores++;
                    retorno = true;
                   
                    break;
                }
            }

            return retorno;
        }

        public int ConteoEstatico
        {
            get
            {
                return conteoJugadores;
            }
        }

    }
}