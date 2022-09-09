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

            string apellido;
            apellido = this.textBox2.Text;

            string materiaFav;
            materiaFav = this.cbxMateriaFav.Text;
            /*
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))//valido si lo ingresado es un nombre
            {
                //en caso de error muestro mensaje encapsulado de lo siguiente
                MessageBox.Show("Hay un errror, se deben completar nombre y appellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
            }
            */

            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(nombre))//valido si lo ingresado es un nombre y apellido
            {
                //en caso de error en ambos
                MessageBox.Show("Hay un errror, se deben completar nombre y appellido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(nombre))//en caso de error solo en nombre
                {
                    MessageBox.Show("Hay un errror, se debe completar nombre ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrEmpty(apellido))//caso de error solo en apellido
                    {
                        MessageBox.Show("Hay un errror, se debe completar apellido ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else//caso de que este ok
                    {
                        Form2 form2 = new Form2(nombre, materiaFav);//instancio form 2
                        form2.ShowDialog();//muestro form2
                    }

                   
                }

            }
        }
    }
}