using Bibliotca_parcial1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual2_parcial1
{
    public partial class frmViajes : Form
    {
        List<Viaje> viajes;
        public frmViajes()
        {
            InitializeComponent();
            viajes = new List<Viaje>();
        }

        private void frmViajes_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }
        public void ActualizarLista()
        {
            viajes = CoreDelSistema.Viajes;//obtengo lista de viajes 
            dtgViajes.DataSource = viajes;//seteo viajes en data grid
        }

    }
}
