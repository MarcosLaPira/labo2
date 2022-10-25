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
        #region ATRIBUTOS
        Viaje? viaje;
        Pasajero? pasajero;///
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public FrmCargarPasajero()//////////
        {
            InitializeComponent();
            
        }
        public FrmCargarPasajero(Viaje viaje):this()
        {
            this.viaje = viaje;
            this.pasajero = null;
        }

        #endregion COSNTRUCTORES

        #region PROPIEDADES
        public Pasajero? GetPasajero
        {
            get { return this.pasajero; }
        }

        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Evento botn siguiente, valida todos los campos ingresados, en caso de que este todo ok, instacia FrmPasaporte, si en el pasaporte sale todo ok, obtiene sus datos y luego crea un pasajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {                  
            bool flag = false;         
            EClasePasajero clasePasajero = EClasePasajero.Turista;
            int edad;

            if (!string.IsNullOrEmpty(txtNombre.Text) && //validamos los campos
                !string.IsNullOrEmpty(txtApellido.Text) && 
                int.TryParse(txtEdad.Text,out edad)//verifico que sea un numero                  
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
                  
                    //  Pasaporte pasaporte1 = new Pasaporte(nombre, apellido, edad, nacionalidad, nacimiento, vencimiento);
                    FrmPasaporte frmPasaporte = new FrmPasaporte(nombre,apellido,edad);//creo la instancia del formulario pasaporte y e paso ciertos parametros para que ya aparezcan cargados
                   
                    if (frmPasaporte.ShowDialog() == DialogResult.OK)//si el form de pasaporte salio bien creo el pasajero
                    {
                        Pasaporte pasaporte = frmPasaporte.GetPasaporte;//obtengo los campos completados en frmPasaporte
                        if (pasaporte is not null)
                        {
                            Pasajero auxPasajero = new Pasajero(nombre, apellido, edad,pasaporte , clasePasajero);//creo el pasajero
                            if (auxPasajero is not null)
                            {
                                this.pasajero = auxPasajero;
                                this.DialogResult = DialogResult.OK;                            
                            }                                                     
                        }                       
                    }                 
                }
                else
                {
                    MessageBox.Show(" Campos incorrectos o invalidos ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" Campos incorrectos o invalidos ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        #endregion METODOS
    }
}
