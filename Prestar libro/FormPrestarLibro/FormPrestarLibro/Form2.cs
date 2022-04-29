using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrestarLibro
{
    public partial class FormSolicitar : Form
    {
        public FormSolicitar()
        {
            InitializeComponent();
        }

        private void FormSolicitar_Load(object sender, EventArgs e)
        {
            {
                cbCategoria.Items.Clear();
                cbCategoria.Items.Add("Matematicas");
                cbCategoria.Items.Add("Historia");
                cbCategoria.Items.Add("Literatura");
                cbCategoria.Items.Add("Biologia");
                cbCategoria.Items.Add("Programacion");
            }
        }
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == 0)
            {
                cbLibro.Items.Add("Geometria");
                cbLibro.Items.Add("Trigonometria");
                cbLibro.Items.Add("Algebra");
                cbLibro.Items.Add("Precalculo");
                cbLibro.Items.Add("Calculo diferencial");
                cbLibro.Items.Add("Calculo integral");
            }
            else if (cbCategoria.SelectedIndex == 1)
            {
                cbLibro.Items.Add("Historia Dominicana");
                cbLibro.Items.Add("Historia Universal");
                cbLibro.Items.Add("La dictadura de Trujillo");
                cbLibro.Items.Add("Enriquillo");
                cbLibro.Items.Add("Sapiens");
            }
            else if (cbCategoria.SelectedIndex == 2)
            {
                cbLibro.Items.Add("Don Quijote de la Mancha");
                cbLibro.Items.Add("El alquimista");
                cbLibro.Items.Add("El principito");
                cbLibro.Items.Add("Los Miserables");
                cbLibro.Items.Add("Iliada");
                cbLibro.Items.Add("Drácula");
            }
            else if (cbCategoria.SelectedIndex == 3)
            {
                cbLibro.Items.Add("El origen de las especies");
                cbLibro.Items.Add("Anatomia Humana");
                cbLibro.Items.Add("Biologia basica");
                cbLibro.Items.Add("Biologia Humana");
                cbLibro.Items.Add("Biologia Molecular del Gen");

            }
            else if (cbCategoria.SelectedIndex == 4)
            {
                cbLibro.Items.Add("Base de datos");
                cbLibro.Items.Add("Orientacion a Objetos");
                cbLibro.Items.Add("Como programar");
                cbLibro.Items.Add("Matematicas para la computacion");
                cbLibro.Items.Add("Introduccion a la programacion");
                cbLibro.Items.Add("Algoritmos");
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

            dtpFecha.Value = DateTime.Now;

            using (var db = new LiteDatabase(@"C:\Temp\PrestarLibros.db"))
            {
                var col1 = db.GetCollection<prestar_libros>("prestamo");

                prestar_libros B = new prestar_libros
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Matricula = Convert.ToInt32(txtMatricula.Text),
                    //Matricula = txtMatricula.Text,
                    Categoria = cbCategoria.Text,
                    Libro = cbLibro.Text,
                    FechaDeAdquisicion = dtpFecha.Value,
                };

                col1.Insert(B);
                txtNombres.Clear();
                txtApellidos.Clear();
                txtMatricula.Clear();
                //cbCategoria.Items.Clear();
                //cbLibro.Items.Clear();
                dtpFecha.Value = DateTime.Now;

            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormInicio form = new FormInicio();
            this.Hide();
            form.ShowDialog();
        }
    }
}
