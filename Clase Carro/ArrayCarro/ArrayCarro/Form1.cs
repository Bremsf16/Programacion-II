namespace ArrayCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un programa para agregar carros.");
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listCarro.SelectedIndex != -1)
                listCarro.Items.RemoveAt(listCarro.SelectedIndex);
        }
        private void toyotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Toyota = Convert.ToString(toyotaToolStripMenuItem);
            listCarro.Items.Add(Toyota);
        }


    }
}