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
    public partial class FrmVisualizarPasajeros : Form
    {
        Viaje viaje;
        public FrmVisualizarPasajeros(Viaje viaje)
        {
            InitializeComponent();
            this.viaje = viaje;
        }

        private void FrmVisualizarPasajeros_Load(object sender, EventArgs e)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            pasajeros = viaje.ListaPasajeros;
            string clase;//true == premium

            foreach (var item in pasajeros)
            {
                if (item.Clase == EClasePasajero.Premium)
                {
                    clase = "Premium";
                }
                else
                {
                    clase = "Turista";
                }
                this.dtgPasajeros.Rows.Add(item.Nombre.ToString(), item.Apellido.ToString(),clase);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
