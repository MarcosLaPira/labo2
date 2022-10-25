using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotca_parcial1
{
  
    public class Ciudad
    {
        #region ATRIBUTOS
        EDestinos lugar;
        string nombre;
        int region;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Ciudad(EDestinos lugar, string nombre, int region)
        {
            this.lugar = lugar;
            this.nombre = nombre;
            this.region = region;
        }
        #endregion CONSTRUCTORES

        public EDestinos Lugar { get => lugar; }
        public string Nombre { get => nombre; }
        public int Region { get => region;  }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    
}
