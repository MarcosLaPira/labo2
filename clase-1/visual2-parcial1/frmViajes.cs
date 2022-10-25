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

        #region PROPOIEDADES
        /// <summary>
        /// retrorna el viaje seleccionado
        /// </summary>
        public Viaje ViajeSelecionado
        {
            get { return this.viajes[indiceDelViajeSeleccionado]; }
        }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// evento de carga, actualiza la lista de viajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmViajes_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        /// <summary>
        /// setea data grid con los viajes de coredel sistema
        /// </summary>
        public void ActualizarLista()
        {
            this.viajes = CoreDelSistema.Viajes;//obtengo lista de viajes 

            string partida;
            string destino;
            string estadoViaje;

            foreach (var item in viajes)
            {
                //obtengo los nombres de los destinos
                partida = item.Partida.Nombre;
                destino = item.Destino.Nombre;

                if (item.EstadoDelViaje)
                {
                    estadoViaje = "Disponible";
                }
                else
                {
                    estadoViaje = "No disponible";
                }
                this.dtgViajes.Rows.Add(partida, destino, item.FechaInicioViaje.ToShortDateString(), estadoViaje);//, item.Barco.BarcoEnPuerto                                                                                                                                //  }
            }

        }

        #region EVENTOS
       
        /// <summary>
        /// Obtiene indice selecionado del data grid y en caso del que viaje este disponible setea dialogo result en ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

            posicion = dtgViajes.CurrentRow.Index;//obtengo indice selccionado del data grid
           Viaje auxViaje = this.viajes.ElementAt(posicion);//obtengo el viaje en el indice seleccionado
                                                       // Viaje auxViaje = viajes[posicion];//obtengo el viaje en el indice seleccionado           
            if (auxViaje is not null)
            {
                if (auxViaje.EstadoDelViaje)
                {
                    this.indiceDelViajeSeleccionado = posicion;
                    this.DialogResult = DialogResult.OK;//para el subMenuVizualizaciones                                    
                }
                else
                {
                    MessageBox.Show("El crucero esta en viaje","Error,viaje no disponible",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }          

        }

        /// <summary>
        /// evento boton volver, redireciona el menu, setea dialogo result en cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion eventos   
    }
    #endregion METODOS
}
