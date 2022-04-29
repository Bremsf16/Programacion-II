namespace ListView
{
    public partial class PruebaListViewFrom : Form
    {
        string directorioActual = Directory.GetCurrentDirectory();

        public PruebaListViewFrom()
        {
            InitializeComponent();
        }

        private void exploradorListView_Click (object sender, EventArgs e)
        {
            if (exploradorListView.SeletedItem.Count != 0)
            {

            }
        }
        
    }
}