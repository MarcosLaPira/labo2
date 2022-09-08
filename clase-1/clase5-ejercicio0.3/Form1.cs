namespace clase5_ejercicio0._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaludo_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.textBoxNombre.Text;//levanto mensaje tipo texto

            MessageBox.Show($"hola {nombre}");

        }

        private void buttonSaludar2_Click(object sender, EventArgs e)
        {

        }
    }
}