using clase4_ejercicio2._1;
using System.Security.Cryptography;

namespace clase5_ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void frmMonedas()
        {
        }
        public static void Disposing(bool disposing)
        { 
        }
        #region BOTONES CONVERSORES
        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            double cantEuro;
            cantEuro = Convert.ToDouble(txtEuro.Text);


          

           //get cantidad del dolar es diferente de null
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            //obtengo cantidad
            bool confirm = double.TryParse(this.txtPeso.Text, out double auxPeso);
            if (confirm)
            {
                Peso nuevoPeso = (Peso)auxPeso;//new peso// seteamos cantidad que es aux Peso
                this.txtPesoAPeso.Text = nuevoPeso.GetCantidad().ToString();

                Dolar nuevoDolar = (Dolar)nuevoPeso;
                // Dolar nuevoDolar = new Dolar((Dolar)auxPeso);
                // Dolar nuevoDolar = new Dolar(auxPeso);
                this.txtPesoADolar.Text = nuevoDolar.GetCantidad().ToString();

                
                Euro nuevoEuro = (Euro)nuevoPeso;
                this.txtPesoAEuro.Text = nuevoEuro.GetCantidad().ToString();
                
                    
               

            }


        }

        private void btnLookCotizacion_Click(object sender, EventArgs e)
        {
            bool comprobarPeso=true;
            bool comprobarEuro = true;
            //validamos que sea diferente de null, vacio,y que sea double
            if (!double.TryParse(this.txtCotizacionPeso.Text, out double auxPeso))
            { 
                this.txtCotizacionPeso.Focus();
                 comprobarPeso = false;
            }
            if (!double.TryParse(this.txtCotizacionPeso.Text, out double auxEuro))
            {
                this.txtCotizacionEuro.Focus();
                comprobarEuro = false;
            }

            if (comprobarPeso && comprobarEuro)//las cotizaciones pasan a ser solo readonly y seteo cotizacion
            {
                this.txtCotizacionPeso.ReadOnly=true;               
                Peso.SetCotizacion(auxPeso);
                this.txtCotizacionEuro.ReadOnly=true;
                Euro.SetCotizacion(auxEuro);
                //la del dolar esta en uno por defeccto en la clase

            }





            // this.btnConvertirDolar.Focus
        }
        #endregion
        #region COTIZACION LEAVE

        // seteo
        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {

            bool confirm = double.TryParse(this.txtCotizacionPeso.Text, out double auxEuro);
            if (!confirm)
            {
                this.txtCotizacionPeso.Focus();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {

        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {

        }
        #endregion 

        

    }
}