namespace IntegradorCeleste
{
    partial class Form1
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
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.btn_AgregarAlumno = new System.Windows.Forms.Button();
            this.btn_EliminarAlumno = new System.Windows.Forms.Button();
            this.btn_EditarAlumno = new System.Windows.Forms.Button();
            this.antigüedad = new System.Windows.Forms.Label();
            this.materias_no_aprobadas = new System.Windows.Forms.Label();
            this.edad_de_ingreso = new System.Windows.Forms.Label();
            this.txt_Antiguedad = new System.Windows.Forms.TextBox();
            this.txt_MateriasNoAprobadas = new System.Windows.Forms.TextBox();
            this.txt_EdadIngreso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(44, 38);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowHeadersWidth = 62;
            this.dataGridViewAlumnos.RowTemplate.Height = 28;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(750, 531);
            this.dataGridViewAlumnos.TabIndex = 0;
            // 
            // btn_AgregarAlumno
            // 
            this.btn_AgregarAlumno.Location = new System.Drawing.Point(44, 593);
            this.btn_AgregarAlumno.Name = "btn_AgregarAlumno";
            this.btn_AgregarAlumno.Size = new System.Drawing.Size(202, 48);
            this.btn_AgregarAlumno.TabIndex = 1;
            this.btn_AgregarAlumno.Text = "Agregar Alumno";
            this.btn_AgregarAlumno.UseVisualStyleBackColor = true;
            this.btn_AgregarAlumno.Click += new System.EventHandler(this.btn_AgregarAlumno_Click);
            // 
            // btn_EliminarAlumno
            // 
            this.btn_EliminarAlumno.Location = new System.Drawing.Point(290, 593);
            this.btn_EliminarAlumno.Name = "btn_EliminarAlumno";
            this.btn_EliminarAlumno.Size = new System.Drawing.Size(224, 48);
            this.btn_EliminarAlumno.TabIndex = 2;
            this.btn_EliminarAlumno.Text = "Eliminar Alumno";
            this.btn_EliminarAlumno.UseVisualStyleBackColor = true;
            this.btn_EliminarAlumno.Click += new System.EventHandler(this.btn_EliminarAlumno_Click);
            // 
            // btn_EditarAlumno
            // 
            this.btn_EditarAlumno.Location = new System.Drawing.Point(560, 593);
            this.btn_EditarAlumno.Name = "btn_EditarAlumno";
            this.btn_EditarAlumno.Size = new System.Drawing.Size(234, 48);
            this.btn_EditarAlumno.TabIndex = 3;
            this.btn_EditarAlumno.Text = "Editar Alumno";
            this.btn_EditarAlumno.UseVisualStyleBackColor = true;
            this.btn_EditarAlumno.Click += new System.EventHandler(this.btn_EditarAlumno_Click);
            // 
            // antigüedad
            // 
            this.antigüedad.AutoSize = true;
            this.antigüedad.Location = new System.Drawing.Point(862, 82);
            this.antigüedad.Name = "antigüedad";
            this.antigüedad.Size = new System.Drawing.Size(91, 20);
            this.antigüedad.TabIndex = 4;
            this.antigüedad.Text = "Antigüedad";
            // 
            // materias_no_aprobadas
            // 
            this.materias_no_aprobadas.AutoSize = true;
            this.materias_no_aprobadas.Location = new System.Drawing.Point(866, 261);
            this.materias_no_aprobadas.Name = "materias_no_aprobadas";
            this.materias_no_aprobadas.Size = new System.Drawing.Size(172, 20);
            this.materias_no_aprobadas.TabIndex = 5;
            this.materias_no_aprobadas.Text = "Materias no aprobadas";
            // 
            // edad_de_ingreso
            // 
            this.edad_de_ingreso.AutoSize = true;
            this.edad_de_ingreso.Location = new System.Drawing.Point(866, 452);
            this.edad_de_ingreso.Name = "edad_de_ingreso";
            this.edad_de_ingreso.Size = new System.Drawing.Size(125, 20);
            this.edad_de_ingreso.TabIndex = 6;
            this.edad_de_ingreso.Text = "Edad de ingreso";
            // 
            // txt_Antiguedad
            // 
            this.txt_Antiguedad.Location = new System.Drawing.Point(866, 122);
            this.txt_Antiguedad.Name = "txt_Antiguedad";
            this.txt_Antiguedad.Size = new System.Drawing.Size(206, 26);
            this.txt_Antiguedad.TabIndex = 7;
            // 
            // txt_MateriasNoAprobadas
            // 
            this.txt_MateriasNoAprobadas.Location = new System.Drawing.Point(866, 332);
            this.txt_MateriasNoAprobadas.Name = "txt_MateriasNoAprobadas";
            this.txt_MateriasNoAprobadas.Size = new System.Drawing.Size(206, 26);
            this.txt_MateriasNoAprobadas.TabIndex = 8;
            // 
            // txt_EdadIngreso
            // 
            this.txt_EdadIngreso.Location = new System.Drawing.Point(866, 519);
            this.txt_EdadIngreso.Name = "txt_EdadIngreso";
            this.txt_EdadIngreso.Size = new System.Drawing.Size(206, 26);
            this.txt_EdadIngreso.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 705);
            this.Controls.Add(this.txt_EdadIngreso);
            this.Controls.Add(this.txt_MateriasNoAprobadas);
            this.Controls.Add(this.txt_Antiguedad);
            this.Controls.Add(this.edad_de_ingreso);
            this.Controls.Add(this.materias_no_aprobadas);
            this.Controls.Add(this.antigüedad);
            this.Controls.Add(this.btn_EditarAlumno);
            this.Controls.Add(this.btn_EliminarAlumno);
            this.Controls.Add(this.btn_AgregarAlumno);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.Button btn_AgregarAlumno;
        private System.Windows.Forms.Button btn_EliminarAlumno;
        private System.Windows.Forms.Button btn_EditarAlumno;
        private System.Windows.Forms.Label antigüedad;
        private System.Windows.Forms.Label materias_no_aprobadas;
        private System.Windows.Forms.Label edad_de_ingreso;
        private System.Windows.Forms.TextBox txt_Antiguedad;
        private System.Windows.Forms.TextBox txt_MateriasNoAprobadas;
        private System.Windows.Forms.TextBox txt_EdadIngreso;
    }
}

