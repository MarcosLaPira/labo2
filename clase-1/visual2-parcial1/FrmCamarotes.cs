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
       
       //// List<Camarote> auxCamarotes;
        //  int indiceViaje;
        Viaje viaje;
        int indiceDelCamaroteSeleccionado;
       
         public FrmCamarotes(Viaje viaje)
        {
            InitializeComponent();
            this.viaje =  viaje;

            ActualizarListaCamarotes();
        }
        /*
        public void ActualizarListaCamarotes()
        {
            Viaje viaje = CoreDelSistema.Viajes[this.indiceViaje];//obtengo viaje 
            
            auxCamarotes = viaje.Barco.ListCamarotes;//obtengo listado de camarotes del viaje 
            foreach (var item in auxCamarotes)
            {
               // if (!item.CamaroteLleno)//muestro solo los camarotes que estan disponibles
               // {
                    dtgCamarotes.Rows.Add(item.IdCamarote.ToString(), item.TipoDeClaseCamarote.ToString(), item.ContadorDelCamarote.ToString());

               // }
            }
        }
        */
        private void ActualizarListaCamarotes()
        {

            ///////////////////
            List<Camarote> aux = new List<Camarote>();//instancio lista de camarotes
             aux =  this.viaje.Barco.ListCamarotes;//obtengo lisat de camarotes de la base de datos
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
                dtgCamarotes.Rows.Add(camarote.IdCamarote.ToString(), claseCamarote.ToString(), camarote.ContadorDelCamarote.ToString());                   
            }

                
          
            /*
            foreach (var item in CoreDelSistema.Viajes)
            {

                viaje.Barco.ListCamarotes
                // if (!item.CamaroteLleno)//muestro solo los camarotes que estan disponibles
                // {
                dtgCamarotes.Rows.Add(item.IdCamarote.ToString(), item.TipoDeClaseCamarote.ToString(), item.ContadorDelCamarote.ToString());

                // }
            }
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int posicion;

            posicion = dtgCamarotes.CurrentRow.Index;//obtengo indice selccionado del data grid
            Camarote auxCamarote = viaje.Barco.ListCamarotes.ElementAt(posicion);//obtengo el camarote del  indice seleccionado
                                                                                 // Viaje auxViaje = viajes[posicion];//obtengo el viaje en el indice seleccionado           
            if (auxCamarote is not null)
            {
                indiceDelCamaroteSeleccionado = posicion;
                this.DialogResult = DialogResult.OK;//para el subMenuVizualizaciones
            }


        }

        public Camarote GetCamarote
        {
            get { return viaje.Barco.ListCamarotes[indiceDelCamaroteSeleccionado]; }
        }

    }
}
