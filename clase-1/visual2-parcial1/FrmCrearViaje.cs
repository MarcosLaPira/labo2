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
    public partial class FrmCrearViaje : Form
    {
        #region ATRIBUTOS
        Empresa empresa;
        List<Barco> barcos;
        #endregion ATRIBUTOS

        #region COSNTRUCTORES
        /// <summary>
        /// Constructor de FrmCrearViaje, recine una empresa de parametro
        /// </summary>
        /// <param name="empresa"></param>
        public FrmCrearViaje(Empresa empresa)
        {
            InitializeComponent();
            this.barcos = new List<Barco>();
            this.empresa = empresa;
        }
        #endregion CONSTRUCTORES

        #region METODOS
        /// <summary>
        /// Eb=vento de carga, setea combo box e invoca a actualizarLista barcos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCrearViaje_Load(object sender, EventArgs e)
        {
            this.ActualizarListaBarcos();
            foreach (var item in CoreDelSistema.ciudades)
            {
                this.cbPartida.Items.Add(item.Nombre);
                this.cbDestino.Items.Add(item.Nombre);
            }
          
        }

        /// <summary>
        /// Actualiza el datagrid de barcos
        /// </summary>
        private void ActualizarListaBarcos()
        {
            this.barcos = CoreDelSistema.Barcos;

            string matricula;
            string capacidadPersonas;
            string estadoDelBarco;

            foreach(var item in this.barcos)
            {
                matricula = item.Matricula;
                capacidadPersonas = item.CapacidadDePersonas.ToString();
              

                if (item.EstadoDelBarco)//true en puerto
                {
                    estadoDelBarco = "Disponible";
                }
                else
                {
                    estadoDelBarco = "No disponible";
                }

               this.dtgBarcos.Rows.Add(matricula, capacidadPersonas, estadoDelBarco);

            }
        }

        /// <summary>
        /// Valida campos, si estan ok, obtien indice del datagrid. Chequea que el barco este disponoble, deser asi, crea el viaje y lo agrega en core del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgBarcos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Barco auxBarco;
            Viaje auxViaje;
            int posicion;
            int indicePartida = 0;
            int indiceDestino = 0;
            bool retorno;
       
            //valido que el combobox tenga datos
            if (
                  !string.IsNullOrEmpty(this.cbPartida.Text) &&
                  !string.IsNullOrEmpty(this.cbDestino.Text) &&
                  !string.IsNullOrEmpty(this.mcFechaInicio.ToString())
               )
            {
                //valido el barco elegido en datagrid
                posicion = this.dtgBarcos.CurrentRow.Index;//obtengo indice selccionado del data grid
                auxBarco = CoreDelSistema.Barcos[posicion];//obtengo barco seleccionado

                if (auxBarco is not null && auxBarco.EstadoDelBarco)//Verifico que el barco obtenido no es nulo
                {
                    for (int i = 0; i < CoreDelSistema.Ciudades.LongCount(); i++)
                    {
                        if (this.cbPartida.Text == CoreDelSistema.Ciudades[i].Nombre)
                        {
                            indicePartida = i;
                        }
                        if (this.cbDestino.Text == CoreDelSistema.Ciudades[i].Nombre)
                        {
                            indiceDestino = i;
                        }
                    }
                   //creo el viaje 
                   //instancio viaje
                    auxViaje = new Viaje(auxBarco, CoreDelSistema.Ciudades[indicePartida], CoreDelSistema.Ciudades[indiceDestino], this.mcFechaInicio.MinDate);
                    if (auxViaje is not null)//si viaje no es nulo
                    {
                        retorno = CoreDelSistema.CrearViaje(auxViaje);
                        if (retorno)
                        {
                            auxBarco.EstadoDelBarco = false;//seteo el barco en ocupado
                            //mensaje viaje creado
                            this.DialogResult = DialogResult.OK;
                           MessageBox.Show(" El viaje fue creado con exito ", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);                          
                        }
                        else
                        {
                            //no se creo viaje 
                            MessageBox.Show(" El viaje no pudo ser creado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }   
                else
                {
                    //error al selecionar barco
                    MessageBox.Show(" Barco no disponible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //mensaje de error completar los campos
                MessageBox.Show(" Campos incompletos o invalidos ", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion METODOS
    }
}
