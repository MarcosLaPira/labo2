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
    public partial class FrmPasaporte : Form
    {
        public FrmPasaporte()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = this.mcNacimiento.;
            DateTime vencimiento = this.mcVencimientoPasaporte.SelectionEnd;

           
            this.Close();
        }
    }
}
