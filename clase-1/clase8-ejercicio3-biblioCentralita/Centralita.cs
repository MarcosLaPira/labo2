using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_ejercicio3_biblioCentralita
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        #endregion

        #region CONSTRUCTORES
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = "";
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(ETipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(ETipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(ETipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }
        #endregion PROPIEDADES

        #region METODOS
        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float ganancia = 0;
            string tipoLlamadaActual = "";

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                tipoLlamadaActual = llamada.GetType().Name.ToString();

                if (tipoLlamadaActual == ETipoLlamada.Local.ToString() && (tipo == ETipoLlamada.Todas || tipo == ETipoLlamada.Local))
                {
                    ganancia += ((Local)llamada).CostoLlamada;
                }
                else if (tipoLlamadaActual == ETipoLlamada.Provincial.ToString() && (tipo == ETipoLlamada.Todas || tipo == ETipoLlamada.Provincial))
                {
                    ganancia += ((Provincial)llamada).CostoLlamada;
                }
            }

            return ganancia;
        }

        private string Mostrar()
        {
            StringBuilder datosCentralita = new StringBuilder();

            datosCentralita.AppendLine("********************************");
            datosCentralita.AppendLine("Razón social: " + this.razonSocial);
            datosCentralita.AppendLine("********Llamadas********");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                datosCentralita.Append(llamada.ToString());
                datosCentralita.AppendLine("---------------------");
            }
            datosCentralita.AppendLine("************************");
            datosCentralita.AppendLine("Ganancia por total: " + this.GananciasPorTotal);
            datosCentralita.AppendLine("Ganancias por local: " + this.GananciasPorLocal);
            datosCentralita.AppendLine("Ganancias por provincial: " + this.GananciasPorProvincial);
            datosCentralita.AppendLine("********************************");

            return datosCentralita.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        /*
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (nuevaLlamada is not null)
            {
                this.listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool retorno = false;

            foreach (Llamada llamada in c.listaDeLlamadas)
            {
                if (llamada == l)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static bool operator +(Centralita c, Llamada l)
        {
            bool retorno = false;

            if (c is not null && l is not null)
            {
                if (c != l)
                {
                    retorno = true;
                    c.AgregarLlamada(l);
                }
                else
                {
                    throw new CentralitaException($"La llamada desde el número {l.NroOrigen} hacia el {l.NroDestino} ya existe en la centralita", c.GetType().Name.ToString(), "public static bool operator +(Centralita c, Llamada l)");
                }
            }

            return retorno;
        }


        */
        #endregion  METODOS

    }
}
