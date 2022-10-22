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

            this.txtCantidadDePasaejeros.Text = contadorCamarote.ToString();
            this.txtNumeroCamarote.Text = idDelCamarote.ToString();
           
          
            if (claseCamarote)
            {
                this.txtClaseCamarote.Text = "Premium";
            }
            else
            {
                this.txtClaseCamarote.Text = "Turista";
            }

            foreach (var item in pasajeros)
            {

               this.dtgPasajeros.Rows.Add(item.Nombre.ToString(),item.Apellido.ToString());
            }
           

            //  dtgCamarotes.Rows.Add(camarote.IdCamarote.ToString(), claseCamarote.ToString(), camarote.ContadorDelCamarote.ToString());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dtgPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

            posicion = dtgPasajeros.CurrentRow.Index;//obtengo indice selccionado del data grid
            Pasajero auxPasajero = camarote.PasajerosDElCamarote.ElementAt(posicion);

           

            if (auxPasajero is not null)
            {
                FrmVisualizarPasaporte formPasaporte = new FrmVisualizarPasaporte(auxPasajero);

                this.Hide();
                if (formPasaporte.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
               

            }
        }
    }
}
