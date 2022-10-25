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
    public partial class FrmCamarotes : Form
    {
        #region ATRIBUTOS 
       
        Viaje viaje;
        int indiceDelCamaroteSeleccionado;

        #endregion ATRIBUTOS 

        #region CONSTRUCTORES
        public FrmCamarotes(Viaje viaje)
        {
            InitializeComponent();
            this.viaje =  viaje;

            ActualizarListaCamarotes();
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public Camarote GetCamarote
        {
            get { return viaje.ListCamarotes[indiceDelCamaroteSeleccionado]; }
        }
        #endregion PROPIEDADES

        #region METODOS
        private void ActualizarListaCamarotes()
        {

            ///////////////////
            List<Camarote> aux = new List<Camarote>();//instancio lista de camarotes
            string claseCamarote;
             aux =  this.viaje.ListCamarotes;//obtengo lisat de camarotes de la base de datos
                 
                       
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int posicion;

            posicion = this.dtgCamarotes.CurrentRow.Index;//obtengo indice selccionado del data grid
            Camarote auxCamarote = this.viaje.ListCamarotes.ElementAt(posicion);//obtengo el camarote del  indice seleccionado
                                                                                 // Viaje auxViaje = viajes[posicion];//obtengo el viaje en el indice seleccionado           
            if (auxCamarote is not null )
            {
                if (!auxCamarote.CamaroteLleno)
                {
                    this.indiceDelCamaroteSeleccionado = posicion;
                    this.DialogResult = DialogResult.OK;//para el subMenuVizualizaciones
                }
                else
                {
                    MessageBox.Show(" Camarote completo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
        }
        #endregion METODOS
      

    }
}
