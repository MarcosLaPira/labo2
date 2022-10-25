using Bibliotca_parcial1;

namespace visual2_parcial1
{
    public partial class FrmLogin : Form
    {
        #region CONSTRUCTOR
        public FrmLogin()
        {
            InitializeComponent();
          
        }
        #endregion CONSTRUCTOR

        #region METODOS
        /// <summary>
        /// Evento boton loguearse, vaslida que el usuario y constrasena correspondan a un empleado o administrador, de ser asi ingresa al sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoguearse_Click(object sender, EventArgs e)
        {
            if (this.txtContrasena is not null && this.txtUsuario is not null)
            {
                string usuario = this.txtContrasena.Text;
                string contrasena = this.txtContrasena.Text;

                object aux = CoreDelSistema.LogearUsuario(usuario, contrasena);
                if (aux is not null)
                {
                    if (aux is Empleado)
                    {
                        Empleado auxEmpleado = (Empleado)aux;
                        FrmMenu menu = new FrmMenu(auxEmpleado);
                        this.Hide();
                        menu.Show();//llamo a nuevo form                        
                    }
                    else
                    {
                        if (aux is Empresa)
                        {
                            Empresa auxEmpresa= (Empresa)aux;
                            FrmMenu menu = new FrmMenu(auxEmpresa);
                            this.Hide();
                            menu.Show();//llamo a nuevo form                            
                        }
                    }
                }              
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos","Error");
                }



            }


        }
        #endregion CONSTRUCTOR
    }
}