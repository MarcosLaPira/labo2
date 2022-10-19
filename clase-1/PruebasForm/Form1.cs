namespace PruebasForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmenu_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            this.Hide();
          

            if (f2.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }


            
        }
    }
}