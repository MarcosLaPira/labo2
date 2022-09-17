using System.Text;
using clase5_Entidades;
namespace clase5_ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)//al hacer click en ingresar
        {
            StringBuilder sbCursos = new StringBuilder();
            string nombre;
            string direccion;
            decimal edad;
            string[] cursos;
            string genero;
            string pais;

            nombre = this.tbNombre.Text;
            direccion = this.tbApellido.Text;
            edad = nUpDownEdad.Value;

            //validacion de detalles usuario
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(direccion))//valido si lo ingresado es un nombre y apellido
            {

            }
            else
            {
                //validacion de check box
                if (this.cbC.Checked == true)//si elige C#
                {
                    sbCursos.AppendLine("C#");
                }
                if (this.cbCmas.Checked == true)//si elige C++
                {
                    sbCursos.AppendLine("C++");
                }
                if (this.cbJavaScript.Checked == true)//si elige javascript
                {
                    sbCursos.AppendLine("Java script");
                }

                //validacion redio button de genero
                if (this.rbMasculino.Checked == true)
                {
                    genero = "masculino";
                }
                else
                {
                    if (this.rbFemenino.Checked == true)
                    {
                        genero = "femenino";
                    }
                    else
                    {
                        if (this.rbNoBinario.Checked == true)
                        {
                            genero = "no binario";
                        }
                        
                        else
                        {
                            genero = null;
                        }
                        
                    }
                }
                if (string.IsNullOrEmpty(this.tbPais.Text))
                {
                   // pais = null;
                }
                else
                {
                    pais = (string)tbPais.Items[tbPais.SelectedIndex];
                    Ingresante alumno1 = new Ingresante(sbCursos.ToString(), direccion, (int)edad, genero, nombre, pais);
                    string textoAMostrar=alumno1.Mostrar();
                    MessageBox.Show(textoAMostrar,"alumno");

                }
            }
          




            MessageBox.Show("Hay un errror, se debe completar apellido ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
    }
}