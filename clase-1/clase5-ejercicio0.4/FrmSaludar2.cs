using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase5_ejercicio0._4
{
    public partial class FrmSaludar2 : Form
    {
        public FrmSaludar2()
        {
            InitializeComponent();
        }

        public FrmSaludar2(string nombre) : this()//constructor del formulario 2,llamo a inicializar
        {
            this.lblSaludo.Text = $"hola {nombre} saludo de form 2";//le asigno al label el contenido de nombre
        }

        //asigno botones
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string equipo;
            equipo = this.cboEquipo.Text;
            MessageBox.Show("usted es de:"+equipo);
            // DialogResult = DialogResult.OK;//devuelvo lo que pasa 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;//devuelvo lo que pasa 
        }
    }
    
}
