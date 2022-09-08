namespace clase5_ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre1.Text;
            string materiaFav;
            materiaFav = this.cbxMateriaFav.Text;

            if (string.IsNullOrEmpty(nombre))//valido si lo ingresado es un nombre
            {
                //en caso de error muestro mensaje encapsulado de lo siguiente
                MessageBox.Show("Hay un errror", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
               Form2 form2 = new Form2(nombre, materiaFav);//instancio form 2
                form2.ShowDialog();//muestro form2
            }
        }
    }
}