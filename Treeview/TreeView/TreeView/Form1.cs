namespace TreeView
{
    public partial class EstructuraDirectorioTreeView : Form
    {
        string subcadenaDirectorio;

        public EstructuraDirectorioTreeView()
        {
            InitializeComponent();
        }
        public void LlenarTreeView(string valorDirectorio, TreeNode nodoPadre)
        {
            string[] arregloDirectorios = Directory.GetDirectories(valorDirectorio);

            try
            {
                if (arregloDirectorios.Length != 0)
                {
                    foreach (string directorio in arregloDirectorios)
                    {
                        subcadenaDirectorio = directorio.Substring(directorio.LastIndexOf('\\') + 1, directorio.Length - directorio.LastIndexOf('\\') - 1);

                        TreeNode miNodo = new TreeNode(subcadenaDirectorio);
                        nodoPadre.Nodes.Add(miNodo);
                        LlenarTreeView(directorio, miNodo);
                    }
                }
            }

            catch (UnauthorizedAccessException)
            {
                nodoPadre.Nodes.Add("Acceso denegado");
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            directorioTreeView.Nodes.Clear();

            if(Directory.Exists(txtEntrada.Text))
            {
                directorioTreeView.Nodes.Add(txtEntrada.Text);
                LlenarTreeView(txtEntrada.Text, directorioTreeView.Nodes[0]);
            }
            else
            {
                MessageBox.Show(txtEntrada.Text + " no se pudo encontrar.", "No se encontro el directorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}