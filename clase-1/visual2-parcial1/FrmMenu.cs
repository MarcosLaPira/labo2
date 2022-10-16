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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
          

            FrmCargarPasajero cargaPasajero = new FrmCargarPasajero();//nuevo form de pasajero 

            if (cargaPasajero.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("completado ", "completado",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          
            /*
            this.Hide();//escondo menu
            FrmCargarPasajero cargaPasajero = new FrmCargarPasajero();
            cargaPasajero.Show();//llamo a nuevo form
            */
        }

        private void btnSeleccionarViaje_Click(object sender, EventArgs e)
        {
            frmViajes formularioViajes = new frmViajes();
            if (formularioViajes.ShowDialog() == DialogResult.OK)
            {
                
            }
          
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FrmSubMenuVizualizacion FrmVisualizarViajes = new FrmSubMenuVizualizacion();

            this.Hide();
            FrmVisualizarViajes.Show();
        }
    }
}
