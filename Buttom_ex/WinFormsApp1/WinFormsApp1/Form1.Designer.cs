namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviado = new System.Windows.Forms.Button();
            this.btnRecibido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviado
            // 
            this.btnEnviado.Location = new System.Drawing.Point(242, 49);
            this.btnEnviado.Name = "btnEnviado";
            this.btnEnviado.Size = new System.Drawing.Size(267, 150);
            this.btnEnviado.TabIndex = 0;
            this.btnEnviado.Text = "Enviar";
            this.btnEnviado.UseVisualStyleBackColor = true;
            this.btnEnviado.Click += new System.EventHandler(this.btnEnviado_Click);
            // 
            // btnRecibido
            // 
            this.btnRecibido.Location = new System.Drawing.Point(242, 220);
            this.btnRecibido.Name = "btnRecibido";
            this.btnRecibido.Size = new System.Drawing.Size(267, 133);
            this.btnRecibido.TabIndex = 1;
            this.btnRecibido.Text = "Recibir ";
            this.btnRecibido.UseVisualStyleBackColor = true;
            this.btnRecibido.Click += new System.EventHandler(this.btnRecibido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecibido);
            this.Controls.Add(this.btnEnviado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEnviado;
        private Button btnRecibido;
    }
}