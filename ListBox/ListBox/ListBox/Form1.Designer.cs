namespace ListBox
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
            this.mostrarListBox = new System.Windows.Forms.ListBox();
            this.entradaTextBox = new System.Windows.Forms.TextBox();
            this.agregarButtom = new System.Windows.Forms.Button();
            this.quitarButton = new System.Windows.Forms.Button();
            this.borrarButtom = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrarListBox
            // 
            this.mostrarListBox.FormattingEnabled = true;
            this.mostrarListBox.ItemHeight = 25;
            this.mostrarListBox.Location = new System.Drawing.Point(12, 12);
            this.mostrarListBox.Name = "mostrarListBox";
            this.mostrarListBox.Size = new System.Drawing.Size(180, 304);
            this.mostrarListBox.TabIndex = 0;
            // 
            // entradaTextBox
            // 
            this.entradaTextBox.Location = new System.Drawing.Point(198, 12);
            this.entradaTextBox.Name = "entradaTextBox";
            this.entradaTextBox.Size = new System.Drawing.Size(150, 31);
            this.entradaTextBox.TabIndex = 1;
            // 
            // agregarButtom
            // 
            this.agregarButtom.Location = new System.Drawing.Point(198, 49);
            this.agregarButtom.Name = "agregarButtom";
            this.agregarButtom.Size = new System.Drawing.Size(150, 62);
            this.agregarButtom.TabIndex = 2;
            this.agregarButtom.Text = "Agregar";
            this.agregarButtom.UseVisualStyleBackColor = true;
            this.agregarButtom.Click += new System.EventHandler(this.agregarButtom_Click);
            // 
            // quitarButton
            // 
            this.quitarButton.Location = new System.Drawing.Point(198, 117);
            this.quitarButton.Name = "quitarButton";
            this.quitarButton.Size = new System.Drawing.Size(150, 62);
            this.quitarButton.TabIndex = 3;
            this.quitarButton.Text = "Quitar";
            this.quitarButton.UseVisualStyleBackColor = true;
            this.quitarButton.Click += new System.EventHandler(this.quitarButton_Click);
            // 
            // borrarButtom
            // 
            this.borrarButtom.Location = new System.Drawing.Point(198, 185);
            this.borrarButtom.Name = "borrarButtom";
            this.borrarButtom.Size = new System.Drawing.Size(150, 62);
            this.borrarButtom.TabIndex = 4;
            this.borrarButtom.Text = "Borrar";
            this.borrarButtom.UseVisualStyleBackColor = true;
            this.borrarButtom.Click += new System.EventHandler(this.borrarButtom_Click);
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(198, 253);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(150, 62);
            this.salirButton.TabIndex = 5;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 323);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.borrarButtom);
            this.Controls.Add(this.quitarButton);
            this.Controls.Add(this.agregarButtom);
            this.Controls.Add(this.entradaTextBox);
            this.Controls.Add(this.mostrarListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mostrarListBox;
        private TextBox entradaTextBox;
        private Button agregarButtom;
        private Button quitarButton;
        private Button borrarButtom;
        private Button salirButton;
    }
}