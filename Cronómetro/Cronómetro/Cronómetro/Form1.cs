using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronómetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Tiempo.Start(); //Iniciando cronometro
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Tiempo.Stop(); //Detener objeto timer
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Horas.Text = "00"; //Reiniciando horas
            Minuto.Text = "00"; //Reiniciando minutos
            Segundo.Text = "00"; //Reniciando segundos 
            Miliseg.Text = "00"; //Reiniciando milisegundos
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            int aux1 = Convert.ToInt32(Miliseg.Text); 
            int aux2 = Convert.ToInt32(Segundo.Text);
            int aux3 = Convert.ToInt32(Minuto.Text);
            int aux4 = Convert.ToInt32(Horas.Text);
            
            aux1 = aux1 + 1;
            Miliseg.Text = aux1.ToString();
            
            if(aux1 > 99) //Para los milisegundos
            {
                aux2 = aux2 + 1;
                Segundo.Text = aux2.ToString();

                aux1 = 0;
                Miliseg.Text = aux1.ToString();
            }
            if (aux2 > 59) //Para los segundos 
            {
                aux3 = aux3 + 1;
                Minuto.Text = aux3.ToString();

                aux2 = 0;
                Segundo.Text = aux2.ToString(); 
            }
            if (aux3 > 59) //Para los minutos 
            {
                aux4 = aux4 + 1;
                Horas.Text = aux4.ToString();

                aux3 = 0;
                Minuto.Text = aux3.ToString();
            }
     
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
