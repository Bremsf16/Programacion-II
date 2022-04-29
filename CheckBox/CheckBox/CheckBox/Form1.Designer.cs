namespace CheckBox
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
            this.negritaCheckBox = new System.Windows.Forms.CheckBox();
            this.salidaLabel = new System.Windows.Forms.Label();
            this.cursivaCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // negritaCheckBox
            // 
            this.negritaCheckBox.AutoSize = true;
            this.negritaCheckBox.Location = new System.Drawing.Point(86, 47);
            this.negritaCheckBox.Name = "negritaCheckBox";
            this.negritaCheckBox.Size = new System.Drawing.Size(96, 29);
            this.negritaCheckBox.TabIndex = 0;
            this.negritaCheckBox.Text = "Negrita";
            this.negritaCheckBox.UseVisualStyleBackColor = true;
            this.negritaCheckBox.CheckedChanged += new System.EventHandler(this.negritaCheckBox_CheckedChanged);
            // 
            // salidaLabel
            // 
            this.salidaLabel.AutoSize = true;
            this.salidaLabel.Location = new System.Drawing.Point(12, 9);
            this.salidaLabel.Name = "salidaLabel";
            this.salidaLabel.Size = new System.Drawing.Size(354, 25);
            this.salidaLabel.TabIndex = 1;
            this.salidaLabel.Text = "Observe cómo cambia el estilo de la fuente";
            // 
            // cursivaCheckBox
            // 
            this.cursivaCheckBox.AutoSize = true;
            this.cursivaCheckBox.Location = new System.Drawing.Point(188, 47);
            this.cursivaCheckBox.Name = "cursivaCheckBox";
            this.cursivaCheckBox.Size = new System.Drawing.Size(95, 29);
            this.cursivaCheckBox.TabIndex = 2;
            this.cursivaCheckBox.Text = "Cursiva";
            this.cursivaCheckBox.UseVisualStyleBackColor = true;
            this.cursivaCheckBox.CheckedChanged += new System.EventHandler(this.cursivaCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 90);
            this.Controls.Add(this.cursivaCheckBox);
            this.Controls.Add(this.salidaLabel);
            this.Controls.Add(this.negritaCheckBox);
            this.Name = "Form1";
            this.Text = "PruebaCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox negritaCheckBox;
        private Label salidaLabel;
        private System.Windows.Forms.CheckBox cursivaCheckBox;
    }
}