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
    public partial class FrmVisualizarCamarote : Form
    {
        Camarote camarote;
        public FrmVisualizarCamarote(Camarote camarote )
        {
            InitializeComponent();
            this.camarote = camarote;
        }

        private void FrmVisualizarCamarote_Load(object sender, EventArgs e)
        {
            int contadorCamarote = camarote.ContadorDelCamarote;
            int idDelCamarote = camarote.IdCamarote;
            bool claseCamarote = camarote.TipoDeClaseCamarote;//true premium
            List<Pasajero> pasajeros = new List<Pasajero>();
            pasajeros = camarote.PasajerosDElCamarote;

            this.lblCantidadPasajeros.Text = $"Cantidad de Pasajeros: {contadorCamarote.ToString()}";
            this.lblIdDeCamarote.Text = $"Id del Camarote: {idDelCamarote.ToString()}" ;
            if (claseCamarote)
            {
                this.lblClaseCamarote.Text = "Clase: Premium";
            }
            else
            {
                this.lblClaseCamarote.Text = "Clase: Turista";
            }

            foreach (var item in pasajeros)
            {

               this.dtgPasajeros.Rows.Add(item.Nombre.ToString(),item.Apellido.ToString());
            }
           

            //  dtgCamarotes.Rows.Add(camarote.IdCamarote.ToString(), claseCamarote.ToString(), camarote.ContadorDelCamarote.ToString());
        }
    }
}
