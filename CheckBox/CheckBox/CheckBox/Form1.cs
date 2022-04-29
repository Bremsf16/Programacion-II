namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void negritaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            salidaLabel.Font = new Font(salidaLabel.Font.Name,salidaLabel.Font.Size,salidaLabel.Font.Style ^ FontStyle.Bold );
        }
        private void cursivaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            salidaLabel.Font = new Font(salidaLabel.Font.Name, salidaLabel.Font.Size,salidaLabel.Font.Style ^ FontStyle.Italic );
        }
    }
}