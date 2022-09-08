namespace clase5_ejercicio0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
              MessageBox.Show("hola desde el eventoo click");//es un mensaje tipo alert

        }

        private void buttonSaludar_Click(object sender, EventArgs e)//lo que ocurrira al hacer clich en boton
        {
            string nombre;
            nombre = textBox1.Text;//obtengo nombre ingresado

            MessageBox.Show($"hola{nombre}");//es un mensaje tipo alert

        }
    }
}