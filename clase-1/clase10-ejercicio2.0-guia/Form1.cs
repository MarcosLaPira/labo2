namespace clase10_ejercicio2._0_guia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double kilometros;
            double litros;
            double resultado;
            //verifico que no esten vacios. Hay formas mas efeicaces
            try
            {
                if (
                    this.txtKilometros.Text == "" ||
                      this.txtKilometros.Text == "" 

                    // string.IsNullOrEmpty(this.txtKilometros.Text) ||
                    // string.IsNullOrEmpty(this.txtLitros.Text)
                  )
                {
                    //lanzo excepcion de parametros vacios
                    throw new ParametrosVaciosException("Parametros vacios");
                }
                //parseo numeros
                kilometros = double.Parse(this.txtKilometros.Text);
                litros = double.Parse(this.txtKilometros.Text);

                resultado = Calculador.Calcular(kilometros, litros);
                rtxResultado.Text = resultado.ToString();

            }
            catch (ParametrosVaciosException ex)//atrapo excepcion de tipo parametros vacios
            {
                MessageBox.Show(ex.Message);
            }
            
            catch (FormatException)
            {
                MessageBox.Show("el formato de entrada no es el correcto");
            }
            
            catch (DivideByZeroException )//atrapo excepcion que puede ocurrir al calcular, dividir
            {
                MessageBox.Show("No es posible dividir por 0");
            }
            
            catch (Exception ex)//excepcion generica por si ocurre algo fuera de lo esperado
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}