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
    public partial class FrmMenu : FormPadre
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
          

            FrmCargarPasajero cargaPasajero = new FrmCargarPasajero();//nuevo form de pasajero 

            if (cargaPasajero.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("completado ", "completado",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          
            /*
            this.Hide();//escondo menu
            FrmCargarPasajero cargaPasajero = new FrmCargarPasajero();
            cargaPasajero.Show();//llamo a nuevo form
            */
        }

        private void btnSeleccionarViaje_Click(object sender, EventArgs e)
        {

            Viaje auxViaje;
            Pasajero auxPasajero;

            FrmViajes formularioViajes = new FrmViajes();
            this.Hide();

            if (formularioViajes.ShowDialog() == DialogResult.OK)
            {
                auxViaje = formularioViajes.ViajeSelecionado;//obtengo el viaje seleccionado
                formularioViajes.Hide();

                //instancio formulario de pasajero 
                FrmCargarPasajero cargaPasajero = new FrmCargarPasajero(auxViaje);//instancio formulario de pasajero
                if (cargaPasajero.ShowDialog() == DialogResult.OK)
                {
                    auxPasajero = cargaPasajero.GetPasajero;
                    cargaPasajero.Hide();

                    if (auxPasajero is not null)
                    {
                        FrmCamarotes formCamarote = new FrmCamarotes(auxViaje);//instancio formulario de camarotes
                        if (formCamarote.ShowDialog() == DialogResult.OK)
                        {
                            Camarote auxCamarote;
                            auxCamarote = formCamarote.GetCamarote;
                            formCamarote.Hide();
                            if (auxCamarote is not null)
                            {
                               bool retorno= auxViaje.AgregarPasajeroACamaroteEspecifico(auxCamarote, auxPasajero);
                                if (retorno)
                                {
                                    MessageBox.Show(" agregado correctamente ", "ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    FrmMenu menuNuevo = new FrmMenu();
                                    menuNuevo.Show();
                                }
                               
                            }


                        }

                    }

                   
                }
                
            }        
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FrmSubMenuVizualizacion frmVisualizarViajes = new FrmSubMenuVizualizacion();

            this.Hide();
            if (frmVisualizarViajes.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
            
        }
    }
}
