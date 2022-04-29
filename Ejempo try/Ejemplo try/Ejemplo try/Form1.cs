namespace Ejemplo_try
{
    public partial class DivisionEntreCeroForm : Form
    {
        public DivisionEntreCeroForm()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            try
            {
                int numerador = Convert.ToInt32(txtNumerador.Text);
                int denominador = Convert.ToInt32(txtDenominador.Text);
                double resultado = numerador / denominador;
                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe escribir dos enteros.");
            }
            catch (DivideByZeroException divideByZeroExceptionParameter)
            {
                MessageBox.Show(divideByZeroExceptionParameter.Message, "Intento de división por cero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}