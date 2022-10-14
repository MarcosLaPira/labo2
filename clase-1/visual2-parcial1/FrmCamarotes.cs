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
        private FrmCamarotes()
        {
            //viaje = new Viaje();
           // auxCamarotes = new List<Camarote>();
            InitializeComponent();
            
            
        }
        /*
        public FrmCamarotes(int viaje):this()
        {
            this.indiceViaje = viaje;
        }
        */
         public FrmCamarotes(Viaje viaje):this()
        {
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
        public void ActualizarListaCamarotes()
        {

            ///////////////////
            List<Camarote> aux = new List<Camarote>();
             aux =  this.viaje.Barco.ListCamarotes;//obtengo lisat de camarotes
                 
                       
            foreach (Camarote camarote in aux)
            {                      
                dtgCamarotes.Rows.Add(camarote.IdCamarote.ToString(), camarote.TipoDeClaseCamarote.ToString(), camarote.ContadorDelCamarote.ToString());                   
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
           


        }
       

    }
}
