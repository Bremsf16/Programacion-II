namespace Menú
{
    public partial class MenuPrueba : Form
    {
        public MenuPrueba()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Éste es un ejemplo\n del uso de menús.", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BorrarColor()
        {
            negroToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
            rojoToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
            moradoToolStripMenuItem.Checked = false; 
            amarilloToolStripMenuItem.Checked = false;
            naranjaToolStripMenuItem.Checked = false;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();
            MostrarLabel.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();            
            MostrarLabel.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();
            MostrarLabel.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();
            MostrarLabel.ForeColor = Color.Green;
            verdeToolStripMenuItem.Checked = true;
        }
        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();
            MostrarLabel.ForeColor = Color.Yellow;
            amarilloToolStripMenuItem.Checked = true;
        }
        private void moradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();
            MostrarLabel.ForeColor = Color.Purple;
            moradoToolStripMenuItem.Checked = true;
        }
        private void naranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarColor();
            MostrarLabel.ForeColor = Color.Orange;
            naranjaToolStripMenuItem.Checked = true;
        }

        private void BorrarFuente()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();
            timesNewRomanToolStripMenuItem.Checked = true;
            MostrarLabel.Font = new Font("Times New Roman",14,MostrarLabel.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();
            courierToolStripMenuItem.Checked = true;
            MostrarLabel.Font = new Font("Courier", 14, MostrarLabel.Font.Style);
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();
            comicSansToolStripMenuItem.Checked = true;
            MostrarLabel.Font = new Font("Comic Sans", 14, MostrarLabel.Font.Style);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();
            arialToolStripMenuItem.Checked = true;
            MostrarLabel.Font = new Font("Arial", 14, MostrarLabel.Font.Style);
        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarFuente();
            calibriToolStripMenuItem.Checked = true;
            MostrarLabel.Font = new Font("Calibri", 14, MostrarLabel.Font.Style);
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negritaToolStripMenuItem.Checked = !negritaToolStripMenuItem.Checked;
            MostrarLabel.Font = new Font(MostrarLabel.Font.FontFamily,14, MostrarLabel.Font.Style ^ FontStyle.Bold);
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cursivaToolStripMenuItem.Checked = !cursivaToolStripMenuItem.Checked;
            MostrarLabel.Font = new Font(MostrarLabel.Font.FontFamily,14, MostrarLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}