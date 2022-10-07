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
    public partial class FrmPasaporte : Form
    {
        string nombre;
        string apellido;
        int edad;
        Pasaporte pasaporte;

        private FrmPasaporte()
        {
            InitializeComponent();

            pasaporte = new Pasaporte("","",0,"",DateTime.Now,DateTime.Now);
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
        }
        public FrmPasaporte(string nombre, string apellido,int edad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        private void FrmPasaporte_Load(object sender, EventArgs e)
        {
            this.lblInfo.Text = "Completar los datos del pasaporte";
            this.txtNombre.Text = this.nombre;
            this.txtApellido.Text = this.apellido;
            this.txtEdad.Text = this.edad.ToString();

        }

        public Pasaporte GetPasaporte
        {
            get{ return this.pasaporte; }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(this.mcNacimiento.ToString()) &&
                !string.IsNullOrEmpty(this.mcVencimientoPasaporte.ToString()) &&
                !string.IsNullOrEmpty(this.txtNombre.Text) &&
                !string.IsNullOrEmpty(this.txtApellido.Text) &&
                !string.IsNullOrEmpty(this.txtNacionalidad.Text) &&
                !string.IsNullOrEmpty(this.txtNacionalidad.Text)

                )
            {

                int auxEdad;
                auxEdad = Convert.ToInt32(this.txtEdad.Text);
                DateTime nacimiento = this.mcNacimiento.SelectionStart;
                DateTime vencimiento = this.mcVencimientoPasaporte.SelectionStart;

                Pasaporte auxPasaporte = new Pasaporte(this.txtNombre.Text, this.txtApellido.Text, auxEdad, this.txtNacionalidad.Text, nacimiento, vencimiento);
                pasaporte = auxPasaporte;

                this.DialogResult = DialogResult.OK;

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
