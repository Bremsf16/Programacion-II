namespace TreeView
{
    partial class EstructuraDirectorioTreeView
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
            this.directorioTreeView = new System.Windows.Forms.TreeView();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorioTreeView
            // 
            this.directorioTreeView.Location = new System.Drawing.Point(12, 139);
            this.directorioTreeView.Name = "directorioTreeView";
            this.directorioTreeView.Size = new System.Drawing.Size(302, 237);
            this.directorioTreeView.TabIndex = 0;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(12, 62);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(302, 31);
            this.txtEntrada.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(12, 99);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(302, 34);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Intro";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escriba la ruta completa del direcctorio \r\nque desea ver:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(302, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EstructuraDirectorioTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 426);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.directorioTreeView);
            this.Name = "EstructuraDirectorioTreeView";
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directorioTreeView;
        private TextBox txtEntrada;
        private Button btnEntrar;
        private Label label1;
        private Button btnSalir;
    }
}