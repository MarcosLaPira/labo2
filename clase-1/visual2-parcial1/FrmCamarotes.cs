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
       
        List<Camarote> auxCamarotes;
        int indiceViaje;
        private FrmCamarotes()
        {
            auxCamarotes = new List<Camarote>();
            InitializeComponent();
            ActualizarListaCamarotes();
            
        }
        public FrmCamarotes(int viaje):this()
        {
            this.indiceViaje = viaje;
        }

        public void ActualizarListaCamarotes()
        {
            Viaje viaje = CoreDelSistema.Viajes[this.indiceViaje];//obtengo viaje 

            auxCamarotes = viaje.Barco.ListCamarotes;//obtengo listado de camarotes del viaje 
            foreach (var item in auxCamarotes)
            {
                if (!item.CamaroteLleno)//muestro solo los camarotes que estan disponibles
                {
                    dtgCamarotes.Rows.Add(item.IdCamarote.ToString(), item.TipoDeClaseCamarote.ToString(), item.ContadorDelCamarote.ToString());

                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }
       

    }
}
