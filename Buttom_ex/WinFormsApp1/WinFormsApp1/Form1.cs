namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviado_Click(object sender, EventArgs e)
        {
            btnEnviado.Text = "ENVIADO HANDLE";
        }

        private void btnRecibido_Click(object sender, EventArgs e)
        {
            btnRecibido.Text = "RECIBIDO HANDLE";
        }
    }
}