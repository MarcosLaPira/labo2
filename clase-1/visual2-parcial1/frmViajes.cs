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
    public partial class FrmViajes : Form
    {
        #region ATRIBUTOS
        List<Viaje> viajes;
        int indiceDelViajeSeleccionado;///
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public FrmViajes()
        {
            InitializeComponent();
            viajes = new List<Viaje>();
        }
        #endregion CONSTRUCTORES

        #region METODOS

        private void frmViajes_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }
        public void ActualizarLista()
        {
            viajes = CoreDelSistema.Viajes;//obtengo lista de viajes 

            string partida;
            string destino;
            string estadoBarco;

            foreach (var item in viajes)
            {
                //obtengo los nombres de los destinos
                partida = item.Partida.Nombre;
                destino = item.Destino.Nombre;
              
                if (item.Barco.BarcoEnPuerto)
                {
                    estadoBarco = "Disponible";
                }
                else
                {
                    estadoBarco = "No disponible";
                }
                dtgViajes.Rows.Add(partida, destino, item.FechaInicioViaje.ToString(), estadoBarco);//, item.Barco.BarcoEnPuerto
                                                                                                                                //  }
            }

        }
        private void dtgViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

            posicion = dtgViajes.CurrentRow.Index;//obtengo indice selccionado del data grid
           Viaje auxViaje = viajes.ElementAt(posicion);//obtengo el viaje en el indice seleccionado
                                                       // Viaje auxViaje = viajes[posicion];//obtengo el viaje en el indice seleccionado           
            if (auxViaje is not null)
            {
                if (auxViaje.Barco.BarcoEnPuerto)
                {
                    indiceDelViajeSeleccionado = posicion;
                    this.DialogResult = DialogResult.OK;//para el subMenuVizualizaciones
                   
                    /*
                    FrmCargarPasajero cargaPasajero = new FrmCargarPasajero(auxViaje);//instancio formulario de pasajero
                    this.Hide();
                    if (cargaPasajero.ShowDialog() == DialogResult.OK)
                    {
                        cargaPasajero.Hide();
                    
                        FrmCamarotes formCamarote = new FrmCamarotes(auxViaje);//instancio formulario de camarotes
                        if (formCamarote.ShowDialog() == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;//carga de pasaejro relaizada
                            
                        }
                    }
                    */
                }
                else
                {
                    MessageBox.Show("El crucero esta en viaje","Error,viaje no disponible",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }          

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// retrorna el viaje seleccionado
        /// </summary>
        public Viaje ViajeSelecionado
        {
            get { return viajes[indiceDelViajeSeleccionado]; }
        }

    }
    #endregion METODOS
}
