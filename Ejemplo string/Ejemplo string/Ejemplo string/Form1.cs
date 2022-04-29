namespace Ejemplo_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string nombre, apellido;

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            nombre = new string(nombre.ToCharArray());
            apellido = new string(apellido.ToCharArray());

            txtCompleto.Text = nombre + " " + apellido;
        }

        private void txtCompleto_TextChanged(object sender, EventArgs e)
        {
            string nombre, apellido;

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            nombre = new string(nombre.ToCharArray());
            apellido = new string(apellido.ToCharArray());

            txtCompleto.Text = nombre + " " + apellido;
        }
    }
}