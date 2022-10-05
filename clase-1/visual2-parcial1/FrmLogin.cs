using Bibliotca_parcial1;

namespace visual2_parcial1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLoguearse_Click(object sender, EventArgs e)
        {
            if (this.txtContrasena is not null && this.txtUsuario is not null)
            {
                string usuario = this.txtContrasena.Text;
                string contrasena = this.txtContrasena.Text;

                Empleado auxEmpleado = CoreDelSistema.LogearUsuario(usuario, contrasena);
                if (auxEmpleado != null)
                {
                   
                    this.Hide();//escondo login

                    FrmMenu menu = new FrmMenu();
                    menu.Show();//llamo a nuevo form

                }
                else
                {
                    MessageBox.Show("vamos mal");
                }


                /*
                if (auxEmpleado is not null)
                {
                    
                }
                */
            }
            
           
        }
    }
}