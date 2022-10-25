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
    public partial class FrmVisualizarEstadisticas : FormPadre
    {
        #region ATRIBUTOS
        Viaje viaje;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor de FrmVisualizarEstadisticas, recibe un viaje de parametro
        /// </summary>
        /// <param name="viaje"></param>
        public FrmVisualizarEstadisticas(Viaje viaje)
        {
            InitializeComponent();
            this.viaje = viaje;
        }
        #endregion ATRIBUTOS

        #region METODOS
        /// <summary>
        /// Evento load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVisualizarEstadisticas_Load(object sender, EventArgs e)
        {
            ActualizarListaCamarotesEstadisticas();

            int cantidadDePasajeros;
            string fechaDeSalida;
            bool estadoDeCrucero;
            int camarotesPremiumVacios;
            int camarotesTuristaVacios;

            cantidadDePasajeros = this.viaje.CantidadDePasajeros;
            fechaDeSalida = this.viaje.FechaInicioViaje.ToString();
            estadoDeCrucero = this.viaje.EstadoDelViaje;//true si el barco esta en puerto
            camarotesPremiumVacios = this.viaje.CantidadCamarotesPremiumVacios;
            camarotesTuristaVacios = this.viaje.CantidadCamarotesTuristaVacios;

            this.txtCantidadPasajeros.Text = cantidadDePasajeros.ToString();
            this.txtFechaSalida.Text = fechaDeSalida.ToString();

            if (estadoDeCrucero)
            {
                this.txtEstadoCrucero.Text = "En puerto";
            }
            else
            {
                this.txtEstadoCrucero.Text = "En viaje";
            }

            this.txtCamarotesPremiumDisponibles.Text = camarotesPremiumVacios.ToString();
            this.txtCamarotesTuristaDispo.Text = camarotesTuristaVacios.ToString();
        }
        /// <summary>
        /// Actualiza el dataGrid de camarotes
        /// </summary>
        private void ActualizarListaCamarotesEstadisticas()
        {

            ///////////////////
            List<Camarote> aux = new List<Camarote>();//instancio lista de camarotes
            aux = this.viaje.ListCamarotes;//obtengo lisat de camarotes de la base de datos
            string claseCamarote;


            foreach (Camarote camarote in aux)
            {
                if (camarote.TipoDeClaseCamarote == true)//evaluo si el camarote es premium
                {
                    claseCamarote = "Premium";
                }
                else
                {
                    claseCamarote = "Turista";
                }
               this.dtgCamarotes.Rows.Add(camarote.IdCamarote.ToString(), claseCamarote.ToString(), camarote.ContadorDelCamarote.ToString());
            }
        }
        /// <summary>
        /// Evento al hacer click obtiene el camarote selecionado, abre form de vizualizar FrmVisualizarCamarote 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgCamarotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

            posicion = this.dtgCamarotes.CurrentRow.Index;//obtengo indice selccionado del data grid
            Camarote auxCamarote = this.viaje.ListCamarotes.ElementAt(posicion);//obtengo el el camarote del indice seleccionado

            if (auxCamarote is not null)
            {
                FrmVisualizarCamarote visualizarCamarote = new FrmVisualizarCamarote(auxCamarote);
                this.Hide();
                if (visualizarCamarote.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }               
            }
        }

        /// <summary>
        /// Evento boton para vizualizar la lista de pasajeros del viaje 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaPasajeros_Click(object sender, EventArgs e)
        {
            
            FrmVisualizarPasajeros listaPasajeros = new FrmVisualizarPasajeros(this.viaje);
            this.Hide();
            if (listaPasajeros.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        /// <summary>
        /// Evento boton volver, redirecciona a menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
        }
        #endregion METODOS
    }
}
