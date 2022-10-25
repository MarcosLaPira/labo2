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
    public partial class FrmSubMenuVizualizacion : Form
    {
         List<Viaje> viajes;
       // FrmMenu menuPrincipal;////
        public FrmSubMenuVizualizacion(/*FrmMenu menuPrincipal*/)
        {
            InitializeComponent();
            viajes = new List<Viaje>();
           // this.menuPrincipal = menuPrincipal;///
        }

        private void FrmSubMenuVizualizacion_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }
        public void ActualizarLista()
        {
            viajes = CoreDelSistema.Viajes;//obtengo lista de viajes 

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
                    estadoViaje = "En viaje";
                }
                

                dtgSubmenuViajes.Rows.Add(partida, destino, item.FechaInicioViaje.ToShortDateString(), estadoViaje);
                                                                                                                         

            }

        }

        /// <summary>
        /// evento cuando seleciona un viaje, redirecciona a ver estadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dtgSubmenuViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

            posicion = dtgSubmenuViajes.CurrentRow.Index;//obtengo indice selccionado del data grid
            Viaje auxViaje = viajes.ElementAt(posicion);//obtengo el viaje en el indice seleccionado

            if (auxViaje is not null)
            {
                FrmVisualizarEstadisticas formVizualizacion = new FrmVisualizarEstadisticas(auxViaje);
                this.Hide();
                if (formVizualizacion.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
                //FrmVisualizarEstadisticas formVizualizacion = new FrmVisualizarEstadisticas(auxViaje);
                // this.Hide();
                // formVizualizacion.Show();

            }


        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // menuPrincipal.Show();//
            this.DialogResult = DialogResult.Cancel;



        }

    }
}
