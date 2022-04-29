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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            FormInicio form = new FormInicio();
            this.Hide();
            form.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\Temp\PrestarLibros.db"))
            {
                var col1 = db.GetCollection<prestar_libros>("prestamo");

                var results = col1.Query()
                                            .Where(x => x.Categoria == txtCategoria.Text || x.Libro == txtLibro.Text)
                                            .OrderBy(x => x.Libro)
                                            .Select(x => new { x.ID, x.Nombres, x.Apellidos, x.Matricula, x.Categoria, x.Libro, x.FechaDeAdquisicion })
                                            .ToList();

                dgvConsultar.DataSource = results;

                txtCategoria.Clear();
                txtLibro.Clear();

            }
        }
        private void CargarDatos(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\Temp\PrestarLibros.db"))
            {
                var col1 = db.GetCollection<prestar_libros>("prestamo");

                var results = col1.Query()
                                            .OrderBy(x => x.Libro)
                                            .Select(x => new { x.ID, x.Nombres, x.Apellidos, x.Matricula, x.Categoria, x.Libro, x.FechaDeAdquisicion })
                                            .ToList();

                dgvConsultar.DataSource = results;
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var idv = dgvConsultar.CurrentRow.Cells[0].Value.ToString();


            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                var col1 = db.GetCollection<prestar_libros>("prestamo");
                try
                {
                    col1.Delete(Convert.ToInt32(idv));
                    MessageBox.Show("El prestamo ha sido devuelto con éxito");
                }
                catch { MessageBox.Show("El libro no se pudo devolver, inténtelo nuevamente"); }

                var results = col1.Query()
                                            .OrderBy(x => x.ID)
                                            .Select(x => new { x.ID, x.Nombres, x.Apellidos, x.Matricula, x.Categoria, x.Libro, x.FechaDeAdquisicion })
                                            .ToList();

                dgvConsultar.DataSource = results;
            }
        }
    }              
}