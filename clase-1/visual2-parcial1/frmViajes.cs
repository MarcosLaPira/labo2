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
        int posicion;
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
            foreach (var item in viajes)
            {
                dtgViajes.Rows.Add(item.Partida.ToString(),item.Destino.ToString(),item.Barco.BarcoEnPuerto.ToString());//, item.Barco.BarcoEnPuerto
            }
           
        }

        private void dtgViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgViajes.CurrentRow.Index;//obtengo indice selccionado del data grid
            Viaje auxViaje = viajes.ElementAt(posicion);//obtengo el viaje en el indice seleccionado
            FrmCargarPasajero cargaPasajero = new FrmCargarPasajero();

            if (cargaPasajero.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("completado ", "completado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        
    }
}
