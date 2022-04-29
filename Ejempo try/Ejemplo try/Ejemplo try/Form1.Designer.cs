namespace Ejemplo_try
{
    partial class DivisionEntreCeroForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtDenominador = new System.Windows.Forms.TextBox();
            this.txtNumerador = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(182, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Escriba el numerador:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 61);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(202, 25);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Escriba el denominador:";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(12, 95);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(186, 34);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "Haga clic para dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // txtDenominador
            // 
            this.txtDenominador.Location = new System.Drawing.Point(220, 58);
            this.txtDenominador.Name = "txtDenominador";
            this.txtDenominador.Size = new System.Drawing.Size(150, 31);
            this.txtDenominador.TabIndex = 5;
            // 
            // txtNumerador
            // 
            this.txtNumerador.Location = new System.Drawing.Point(220, 21);
            this.txtNumerador.Name = "txtNumerador";
            this.txtNumerador.Size = new System.Drawing.Size(150, 31);
            this.txtNumerador.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(220, 98);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(150, 31);
            this.txtResultado.TabIndex = 7;
            // 
            // DivisionEntreCeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 152);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumerador);
            this.Controls.Add(this.txtDenominador);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "DivisionEntreCeroForm";
            this.Text = "DivisionEntreCero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label lbl1;
        private Label lbl2;
        private Button btnDividir;
        private TextBox txtDenominador;
        private TextBox txtNumerador;
        private TextBox txtResultado;
    }
}