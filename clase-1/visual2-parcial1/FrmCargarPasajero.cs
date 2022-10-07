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
                   
            bool flag = false;
          
            EClasePasajero clasePasajero = EClasePasajero.Turista;

            if (!string.IsNullOrEmpty(txtNombre.Text) && //validamos los campos
                !string.IsNullOrEmpty(txtApellido.Text) && 
                !string.IsNullOrEmpty(txtEdad.Text)       
                )
            {
                if (this.rbPremium.Checked == true)//valido el tipo de pasajero 
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
                if (flag)//entro solo si paso las validaciones anteriores
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int edad = Convert.ToInt32(this.txtEdad.Text);

                    //  Pasaporte pasaporte1 = new Pasaporte(nombre, apellido, edad, nacionalidad, nacimiento, vencimiento);
                    FrmPasaporte frmPasaporte = new FrmPasaporte(nombre,apellido,edad);//creo la instancia del formulario pasaporte y e paso ciertos parametros para que ya aparezcan cargados

                    if (frmPasaporte.ShowDialog() == DialogResult.OK)//si el form de pasaporte salio bien creo el pasajero
                    {
                        Pasaporte pasaporte = frmPasaporte.GetPasaporte;//obtengo los campos completados en frmPasaporte
                        if (pasaporte is not null)
                        {
                            Pasajero pasajero = new Pasajero(nombre, apellido, edad,pasaporte , clasePasajero);//creo el pasajero
                        }                       

                    }
                  
                }
                else
                {
                    MessageBox.Show("Hay un errror, se debe completar todos los campos ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
