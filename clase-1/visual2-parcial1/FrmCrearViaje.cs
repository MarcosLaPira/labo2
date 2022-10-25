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
        Empresa empresa;
        List<Barco> barcos;
        public FrmCrearViaje(Empresa empresa)
        {
            InitializeComponent();
            barcos = new List<Barco>();
            this.empresa = empresa;
        }

        private void FrmCrearViaje_Load(object sender, EventArgs e)
        {
            ActualizarListaBarcos();
            foreach (var item in CoreDelSistema.ciudades)
            {
                this.cbPartida.Items.Add(item.Nombre);
                this.cbDestino.Items.Add(item.Nombre);
            }
          
        }

        private void ActualizarListaBarcos()
        {
            barcos = CoreDelSistema.Barcos;

            string matricula;
            string capacidadPersonas;
            string estadoDelBarco;

            foreach(var item in barcos)
            {
                matricula = item.Matricula;
                capacidadPersonas = item.CapacidadDePersonas.ToString();
              

                if (item.BarcoEnPuerto)//true en puerto
                {
                    estadoDelBarco = "Disponible";
                }
                else
                {
                    estadoDelBarco = "No disponible";
                }

                dtgBarcos.Rows.Add(matricula, capacidadPersonas, estadoDelBarco);

            }
        }

        private void dtgBarcos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            Barco auxBarco;
            int indicePartida = 0;
            int indiceDestino = 0;
            bool retorno;

            Viaje auxViaje;
            //valido que el combobox tenga datos
            if (
                  !string.IsNullOrEmpty(this.cbPartida.Text) &&
                  !string.IsNullOrEmpty(this.cbDestino.Text) &&
                  !string.IsNullOrEmpty(this.mcFechaInicio.ToString())
               )
            {
                //valido el barco elegido en datagrid
                posicion = dtgBarcos.CurrentRow.Index;//obtengo indice selccionado del data grid
                auxBarco = CoreDelSistema.Barcos[posicion];//obtengo barco seleccionado

                if (auxBarco is not null && auxBarco.BarcoEnPuerto)
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
                    auxViaje = new Viaje(auxBarco, CoreDelSistema.Ciudades[indicePartida], CoreDelSistema.Ciudades[indiceDestino], this.mcFechaInicio.MinDate);
                    if (auxViaje is not null)
                    {
                        retorno = CoreDelSistema.CrearViaje(auxViaje);
                        if (retorno)
                        {
                            auxBarco.BarcoEnPuerto = false;//seteo el barco en ocupado
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
            DialogResult = DialogResult.Cancel;
        }
    }
}
