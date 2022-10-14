using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
    public class Ciudad
    {
        EDestinos lugar;
        string nombre;
        int region;
        
        public Ciudad(EDestinos lugar, string nombre, int region)
        {
            this.lugar = lugar;
            this.nombre = nombre;
            this.region = region;
        }

        public EDestinos Lugar { get => lugar; }
        public string Nombre { get => nombre; }
        public int Region { get => region;  }
    }
}
