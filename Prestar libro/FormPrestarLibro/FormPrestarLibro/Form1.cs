namespace FormPrestarLibro
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSolicitarPrestamo_Click(object sender, EventArgs e)
        {
            FormSolicitar fp = new FormSolicitar();
            this.Hide();
            fp.ShowDialog();
        }

        private void btnConsultarLibro_Click(object sender, EventArgs e)
        {
            Form3 fp = new Form3();
            this.Hide();
            fp.ShowDialog();
        }
    }
}