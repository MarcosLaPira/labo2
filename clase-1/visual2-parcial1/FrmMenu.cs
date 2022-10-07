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
          
            this.Hide();//escondo menu

            FrmCargarPasajero cargaPasajero = new FrmCargarPasajero();
            cargaPasajero.Show();//llamo a nuevo form
        }
    }
}
