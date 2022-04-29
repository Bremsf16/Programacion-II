namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarButtom_Click(object sender, EventArgs e)
        {
            mostrarListBox.Items.Add(entradaTextBox.Text);
            entradaTextBox.Clear();
        }

        private void quitarButton_Click(object sender, EventArgs e)
        {
            if (mostrarListBox.SelectedIndex != -1)
                mostrarListBox.Items.RemoveAt(mostrarListBox.SelectedIndex);
        }

        private void borrarButtom_Click(object sender, EventArgs e)
        {
            mostrarListBox.Items.Clear();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}