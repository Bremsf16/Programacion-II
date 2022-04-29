using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace RegistroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void Main(string[] args)
        {
            private void btnSalir_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            public class Persona
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Lastname { get; set; }
                public string Email { get; set; }
                public bool IsActive { get; set; }
            }
        }
    }
       
       
    }
}
