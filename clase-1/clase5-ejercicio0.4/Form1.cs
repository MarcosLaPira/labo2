namespace clase5_ejercicio0._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//inicializo para que arrnque
        }

        private void btnSaludar_Click(object sender, EventArgs e)//metodo al hacer doble click en saludar
        {
            string nombre;
            nombre = this.textBoxNombre.Text;//a nombre le asigno el atributo de texte box

            if (string.IsNullOrEmpty(nombre))//valido si lo ingresado es un nombre
            {
                //en caso de error muestro mensaje encapsulado de lo siguiente
                MessageBox.Show("Hay un errror","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {
                //en caso ok, muestro mensaje
                MessageBox.Show($"hola {nombre}");
            }

          
        }

        private void btnSaludarForm2_Click(object sender, EventArgs e)//metodo al hacer doble click para saludar desde form2
        {
            string nombre;
            nombre = this.textBoxNombre.Text;//a nombre le asigno el atributo de text box

            FrmSaludar2 frmSaludar2 = new FrmSaludar2(nombre);//inicializo form 2, lo cargo en memoraia
          
            // llamo y muestro formulario2 necesita de la ejecucuion de aceptar cancelar, devuelve valores
            if (frmSaludar2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("usted acepto su nombre");
            }
            else
            {
                MessageBox.Show("usted no acepto su nombre");
            }
        }
    }
}