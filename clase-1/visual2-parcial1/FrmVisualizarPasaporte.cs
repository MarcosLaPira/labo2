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
    public partial class FrmVisualizarPasaporte : Form
    {
        Pasajero pasajero;
        public FrmVisualizarPasaporte(Pasajero pasajero)
        {
            InitializeComponent();
            this.pasajero = pasajero;
        }

        private void FrmVisualizarPasaporte_Load(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string nacionalidad;
            string fechaDeNacimiento;
            string fechaDeVencimientoPasaporte;

            nombre = pasajero.Nombre;
            apellido = pasajero.Apellido;
            nacionalidad = pasajero.Pasaporte.Nacionalidad;
            fechaDeNacimiento = pasajero.Pasaporte.FechaDeNacimiento.ToShortDateString();
            fechaDeVencimientoPasaporte = pasajero.Pasaporte.FechaDeVencimiento.ToShortDateString();

            this.txtNombre.Text = nombre;
            this.txtApellido.Text = apellido;
            this.txtNacionalidad.Text = nacionalidad;
            this.txtFechaDeNacimiento.Text = fechaDeNacimiento;
            this.txtVencimientoPasaporte.Text = fechaDeVencimientoPasaporte;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
