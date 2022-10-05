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
    public partial class FrmCargarPasajero : Form
    {
        public FrmCargarPasajero()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
           
            
            DateTime nacimiento = this.dtpNacimiento.Value;
            bool flag = false;
            DateTime vencimiento = this.dtpVencimiento.Value;
            EClasePasajero clasePasajero = EClasePasajero.Turista;

            if (!string.IsNullOrEmpty(txtNombre.Text) && 
                !string.IsNullOrEmpty(txtApellido.Text) && 
                !string.IsNullOrEmpty(txtEdad.Text) && 
                !string.IsNullOrEmpty(txtNacionalidad.Text) &&
                !string.IsNullOrEmpty(nacimiento.ToString()) &&
                 !string.IsNullOrEmpty(vencimiento.ToString())
                )
            {
                if (this.rbPremium.Checked == true)
                {
                    flag = true;
                    clasePasajero = EClasePasajero.Premium;
                    
                }
                else
                {
                    if (this.rbTurista.Checked == true)
                    { 
                        flag = true;
                        clasePasajero = EClasePasajero.Turista;

                    }

                }
                
                if (flag)
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int edad = Convert.ToInt32(this.txtEdad.Text);
                    string nacionalidad = txtNacionalidad.Text;
                   

                    Pasaporte pasaporte1 = new Pasaporte(nombre, apellido, edad, nacionalidad, nacimiento, vencimiento);

                    if (pasaporte1 is not null)
                    {
                        Pasajero pasajero = new Pasajero(nombre, apellido, edad, pasaporte1, clasePasajero);
                    }




                    this.Hide();
                    FrmPasaporte pasaporte = new FrmPasaporte();
                    pasaporte.ShowDialog();

                    
                }
                else
                {
                    MessageBox.Show("Hay un errror, se debe completar apellido ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
