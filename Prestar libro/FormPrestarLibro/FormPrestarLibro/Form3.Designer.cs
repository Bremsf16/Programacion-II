namespace FormPrestarLibro
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRegresar1 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.prestarlibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDevolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.formSolicitarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestarlibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSolicitarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar1
            // 
            this.btnRegresar1.Location = new System.Drawing.Point(12, 357);
            this.btnRegresar1.Name = "btnRegresar1";
            this.btnRegresar1.Size = new System.Drawing.Size(112, 34);
            this.btnRegresar1.TabIndex = 0;
            this.btnRegresar1.Text = "Regresar";
            this.btnRegresar1.UseVisualStyleBackColor = true;
            this.btnRegresar1.Click += new System.EventHandler(this.btnRegresar1_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(465, 357);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 34);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Location = new System.Drawing.Point(12, 126);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.RowHeadersWidth = 62;
            this.dgvConsultar.RowTemplate.Height = 33;
            this.dgvConsultar.Size = new System.Drawing.Size(565, 225);
            this.dgvConsultar.TabIndex = 2;
            // 
            // prestarlibrosBindingSource
            // 
            this.prestarlibrosBindingSource.DataSource = typeof(FormPrestarLibro.prestar_libros);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(310, 357);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(149, 34);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text = "Devolver libro";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(111, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "CONSULTAR LIBROS ";
            // 
            // formSolicitarBindingSource
            // 
            this.formSolicitarBindingSource.DataSource = typeof(FormPrestarLibro.FormSolicitar);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(111, 86);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(193, 31);
            this.txtCategoria.TabIndex = 9;
            this.txtCategoria.TextChanged += new System.EventHandler(this.CargarDatos);
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(375, 86);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(202, 31);
            this.txtLibro.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Categoría:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(587, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegresar1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestarlibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSolicitarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegresar1;
        private Button btnConsultar;
        private DataGridView dgvConsultar;
        private Button btnDevolver;
        private Label label3;
        private BindingSource prestarlibrosBindingSource;
        private BindingSource formSolicitarBindingSource;
        private TextBox txtCategoria;
        private TextBox txtLibro;
        private Label label1;
        private Label label2;
    }
}