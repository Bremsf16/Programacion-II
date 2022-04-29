namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;//Se declaran dos variables de tipo double para desarrollar las operaciones
        char Operador;//Se declara una vairable de tipo char llamada Operador

        public Form1()//Se abre clase publica 
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)//Se crea clase privada para agregar numero 
        {
            var boton = ((Button)sender);//Sender recibe un dato de tipo buttom, lo castea y se envia a una variable que se crea en ese lugar

            if (txtUno.Text == "0")//Se crea una condición 
                txtUno.Text = "";//La acción a realizar si se cumple la condición 

            if (Operador == 0)//Se crea una condición 
                txtUno.Text += boton.Text;//Se asigna el boton al cuadro de texto 1 

            else if (Operador != 0)//Se crea una condición 
            {
                txtDos.Text += boton.Text; //Se asigna el boton al cuadro de texto 2
            }

            if (txtResultado.Text == "0")//Se crea una condición 
                txtResultado.Text = "";//Se deja simbolo alguno a txtResultado.Text si se cumple la condición 

            txtResultado.Text += boton.Text;//Se asigna el boton al cuadro de texto de resultado
        }

        private void btnResultado_Click(object sender, EventArgs e)//Se crea una clase privada para el evento del boton de resultado
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en el cuadro de texto de resultado de tipo string se convierte a double y se asigna a la variable Numero2
            txtDos.Text = txtResultado.Text;//Se asigna lo que se encuentra en txtResultado a txtDos.Text

            if (Operador == '+')//Se crea una condicion para la suma
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();//Se ordena como se efecturá la suma y se asigna a txtResultado
                Numero1 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en txtResultado se convierte en double y se asigna a la variable Numero1
            }
            else if (Operador == '-')//Se crea una condición para la resta
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();//Se ordena como se efecturá la resta y se asigna a txtResultado
                Numero1 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en txtResultado se convierte en double y se asigna a la variable Numero1
            }
            else if (Operador == 'X')//Se crea la condicion para la multiplicación
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();//Se ordena como se efecturá la multiplicación y se asigna a txtResultado
                Numero1 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en txtResultado se convierte en double y se asigna a la variable Numero1
            }
            else if (Operador == '/')//Se crea la condicion para la división
            {
                if (txtResultado.Text != "0")//Se crea una condición de que si txtResuldado no es igual a cero se efectuará la división
                {
                    txtResultado.Text = (Numero1 / Numero2).ToString();//Se ordena como se efecturá la división y se asigna a txtResultado
                    Numero1 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en txtResultado se convierte en double y se asigna a la variable Numero1
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");//Mediante este se presenta un aviso de que no se puede dividir por cero 
                }
            }
            else if (Operador == 'H')
            {
                double hipotenusa = Math.Sqrt((Numero1 * Numero1) + (Numero2 * Numero2));
                txtResultado.Text = hipotenusa.ToString();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)//Se crea una clase privada para el evento del boton quitar 
        {
            if (txtResultado.Text.Length > 1)//Se crea una condición para quitar un digito
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);//Se le sustrae un digito a lo que se introdujo en txtResultado, se agrega a una cadena de caracteres y se asigna a txtResultado.Text
            }
            else//Se crea una contracondición
            {
                txtResultado.Text = "0";//Se le asigna el simbolo 0 a txtResultado.Text
            }
            
            if (Operador == 0)//Se crea una condición para la variable Operador 
            {
                if (txtUno.Text.Length > 1)//Se crea una condición para txtUno.Text donde cumplirá siempre y cuando tenga más de un digito 
                {
                    txtUno.Text = txtUno.Text.Substring(0, txtUno.Text.Length - 1);//Se le sustrae un digito a lo que se introdujo en txtUno, se agrega a una cadena de caracteres y se asigna a txtUno.Text
                }
                else//Se crea una contracondición
                {
                    txtUno.Text = "";////Se deja sin simbolo a txtUno.Text
                }
            }

            if (Operador != 0)//Se crea una condicion para la variable Operador 
            {
                if (txtDos.Text.Length > 1)//Se crea una condición para txtDos.Text donde cumplirá siempre y cuando tenga más de un digito 
                {
                    txtDos.Text = txtDos.Text.Substring(0, txtDos.Text.Length - 1);//Se le sustrae un digito a lo que se introdujo en txtDos, se agrega a una cadena de caracteres y se asigna a txtDos.Text
                }
                else//Se crea una contracondición
                {
                    txtDos.Text = " ";//Se asigna el simbolo espacio a txt.Dos.Text
                }
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)//Se crea una clase privada para el evento del boton borrar todo
        {
            Numero1 = 0;//Se le asigna el valor de 0 a la variable Numero1
            Numero2 = 0;//Se le asigna el valor de 0 a la variable Numero2
            Operador = '\0';//Se iguaña la variable Operador a 
            txtUno.Text = "";//Se deja sin simbolo alguno a txtUno.Text
            txtOperador.Text = "";//Se asigna el simbolo espacio a txtOperador.Text
            txtDos.Text = "";//Se asigna el simbolo espacio a txtDos.Text
            txtResultado.Text = "0";//Se le asigna el simbolo 0 a txtResultado.Text
        }

        private void btnBorrar_Click(object sender, EventArgs e)//Se crea una clase privada para el boton borrar
        {
            txtResultado.Text = "0";//Se le asigna el simbolo 0 a txtResultado.Text

            if (Operador ==0)//Se crea una condición para la variable Operador
            {
                txtUno.Text = "";//Se asigna el simbolo espacio a txt.Uno.Text
            }

            if(Operador != 0)//Se crea una condición a la variable Operador
            {
                txtDos.Text = "";//Se asigna el simbolo espacio a txt.Dos.Text
            }

        }

        private void btnPunto_Click(object sender, EventArgs e)//Se crea una clase privada para el evento del boton Punto
        {
            if (!txtResultado.Text.Contains("."))//Se crea una condición para saber si en txtResultado.Text contiene el simbolo "." 
            {
                txtResultado.Text += ".";//Se le asigna el simbolo "." a txtRresultado.Text
            }

            if (!txtUno.Text.Contains("."))//Se crea una condición para saber si en txtUno.Text contiene el simbolo "." 
            {
                txtUno.Text += ".";//Se le asigna el simbolo "." a txtUno.Text
            }

            else if (!txtDos.Text.Contains("."))//Se crea una condición para saber si en txtResultado.Text contiene el simbolo "." 
            {
                txtDos.Text += ".";//Se le asigna el simbolo "." a txtDos.Text
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)//Se crea una privada para el evento del boton signo
        {
            if(Operador == '\0')//Se crea una condión para signo del textbox 1 
            {
                Numero1 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en txtResultado se con double y se asigna a la variable Numero1
                Numero1 *= -1;//Se multiplica por -1 para cambiar signo y se asigna a la variable Numero1
                txtResultado.Text = Numero1.ToString();//Se asigna la cadena de caracteres a txtResultado.Text
            }

            if (Operador != '\0')//Se crea una condción para signo del textbox 2
            {
                Numero2 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en txtResultado se con double y se asigna a la variable Numero2
                Numero2 *= -1;//Se multiplica por -1 para cambiar signo y se asigna a la variable Numero2
                txtResultado.Text =Numero2.ToString(); //Se asigna la cadena de caracteres a txtResultado.Text
            }
        }

        private void ClickOperador(object sender, EventArgs e)//Se crea una clase privada para el evento de ClickOperador 
        {
            var boton = (Button)sender;//Sender recibe un dato de tipo buttom, lo castea y se envia a una variable que se crea en ese lugar

            Numero1 = Convert.ToDouble(txtResultado.Text);//Lo que se encuentra en txtResultado.Text se convierte a double y se asigna ala variable Numero1
            Operador = Convert.ToChar(boton.Tag);//La varaible boton que se creó en esta clase con extensión de Tag se convierte a tipo char y se asigna a Operador
            txtOperador.Text = Operador.ToString();//La cadena de caracteres de la variable Operador se asigna al textbox txtOperador.Text

            if (Operador != 0)//Se crea una condición a la variable Operador
            {
                txtUno.Text = Numero1.ToString();//La cadena de caracteres de la variable Numero1 se asigna al textbox txtUno.Text
                txtDos.Text = " ";////Se asigna el simbolo espacio a txt.Dos.Text
            }

            if (Operador == '²')//Se crea condcicion para la variable Operador cuya funcion es elevar al cuadrado 
            {
                Numero1 = Math.Pow(Numero1, 2);//Se utiliza la librería Math para ejecutar un método de elevar al cuadrado a la variable Numero1 y se asigna a la misma
                txtResultado.Text = Numero1.ToString();//La cadena de caracteres de la variable Numero1 se asigna al textbox txtResultado.Text
            }

            else if (Operador == '√')//Se crea condición adicionalpara la variable Operadador, cuya función es la radicación 
            {
                Numero1 = Math.Sqrt(Numero1);//Se utiliza la librería Math para ejecutar un método de raiz cuadrada a la variable Numero1 y se asigna a la misma
                txtResultado.Text = Numero1.ToString();//La cadena de caracteres de la variable Numero1 se asigna al textbox txtResultado.Text
            }
            else//Se crea una contracodición
            {
                txtResultado.Text = "0";//El textbox txtResultado.Text se le asigna el simbolo 0
            }
            if (Operador == 'L')
            {
                double logaritmo = Math.Log10(Numero1);
                txtResultado.Text = logaritmo.ToString();
            }
        }

    }
}