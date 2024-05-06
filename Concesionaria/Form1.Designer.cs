namespace TrabajoIntegradorUnidad1_Devalis
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
            this.dataGridViewPersonas = new System.Windows.Forms.DataGridView();
            this.dataGridViewAutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewAutosPersona = new System.Windows.Forms.DataGridView();
            this.btn_AgregarPersona = new System.Windows.Forms.Button();
            this.btn_BorrarPersona = new System.Windows.Forms.Button();
            this.btn_EditarPersona = new System.Windows.Forms.Button();
            this.dataGridViewDetallesAuto = new System.Windows.Forms.DataGridView();
            this.btn_AgregarAuto = new System.Windows.Forms.Button();
            this.btn_BorrarAuto = new System.Windows.Forms.Button();
            this.btn_EditarAuto = new System.Windows.Forms.Button();
            this.btn_AsignarAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutosPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallesAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonas
            // 
            this.dataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonas.Location = new System.Drawing.Point(31, 33);
            this.dataGridViewPersonas.Name = "dataGridViewPersonas";
            this.dataGridViewPersonas.RowHeadersWidth = 62;
            this.dataGridViewPersonas.RowTemplate.Height = 28;
            this.dataGridViewPersonas.Size = new System.Drawing.Size(441, 582);
            this.dataGridViewPersonas.TabIndex = 0;
            // 
            // dataGridViewAutos
            // 
            this.dataGridViewAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutos.Location = new System.Drawing.Point(488, 33);
            this.dataGridViewAutos.Name = "dataGridViewAutos";
            this.dataGridViewAutos.RowHeadersWidth = 62;
            this.dataGridViewAutos.RowTemplate.Height = 28;
            this.dataGridViewAutos.Size = new System.Drawing.Size(462, 582);
            this.dataGridViewAutos.TabIndex = 1;
            // 
            // dataGridViewAutosPersona
            // 
            this.dataGridViewAutosPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutosPersona.Location = new System.Drawing.Point(968, 33);
            this.dataGridViewAutosPersona.Name = "dataGridViewAutosPersona";
            this.dataGridViewAutosPersona.RowHeadersWidth = 62;
            this.dataGridViewAutosPersona.RowTemplate.Height = 28;
            this.dataGridViewAutosPersona.Size = new System.Drawing.Size(422, 582);
            this.dataGridViewAutosPersona.TabIndex = 2;
            // 
            // btn_AgregarPersona
            // 
            this.btn_AgregarPersona.Location = new System.Drawing.Point(31, 644);
            this.btn_AgregarPersona.Name = "btn_AgregarPersona";
            this.btn_AgregarPersona.Size = new System.Drawing.Size(441, 53);
            this.btn_AgregarPersona.TabIndex = 3;
            this.btn_AgregarPersona.Text = "Agregar Persona";
            this.btn_AgregarPersona.UseVisualStyleBackColor = true;
            this.btn_AgregarPersona.Click += new System.EventHandler(this.btn_AgregarPersona_Click);
            // 
            // btn_BorrarPersona
            // 
            this.btn_BorrarPersona.Location = new System.Drawing.Point(31, 703);
            this.btn_BorrarPersona.Name = "btn_BorrarPersona";
            this.btn_BorrarPersona.Size = new System.Drawing.Size(441, 57);
            this.btn_BorrarPersona.TabIndex = 4;
            this.btn_BorrarPersona.Text = "Borrar Persona";
            this.btn_BorrarPersona.UseVisualStyleBackColor = true;
            this.btn_BorrarPersona.Click += new System.EventHandler(this.btn_BorrarPersona_Click);
            // 
            // btn_EditarPersona
            // 
            this.btn_EditarPersona.Location = new System.Drawing.Point(31, 766);
            this.btn_EditarPersona.Name = "btn_EditarPersona";
            this.btn_EditarPersona.Size = new System.Drawing.Size(441, 56);
            this.btn_EditarPersona.TabIndex = 5;
            this.btn_EditarPersona.Text = "Editar Persona";
            this.btn_EditarPersona.UseVisualStyleBackColor = true;
            this.btn_EditarPersona.Click += new System.EventHandler(this.btn_EditarPersona_Click);
            // 
            // dataGridViewDetallesAuto
            // 
            this.dataGridViewDetallesAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallesAuto.Location = new System.Drawing.Point(1406, 33);
            this.dataGridViewDetallesAuto.Name = "dataGridViewDetallesAuto";
            this.dataGridViewDetallesAuto.RowHeadersWidth = 62;
            this.dataGridViewDetallesAuto.RowTemplate.Height = 28;
            this.dataGridViewDetallesAuto.Size = new System.Drawing.Size(459, 582);
            this.dataGridViewDetallesAuto.TabIndex = 6;
            // 
            // btn_AgregarAuto
            // 
            this.btn_AgregarAuto.Location = new System.Drawing.Point(488, 644);
            this.btn_AgregarAuto.Name = "btn_AgregarAuto";
            this.btn_AgregarAuto.Size = new System.Drawing.Size(462, 53);
            this.btn_AgregarAuto.TabIndex = 7;
            this.btn_AgregarAuto.Text = "Agregar Auto";
            this.btn_AgregarAuto.UseVisualStyleBackColor = true;
            this.btn_AgregarAuto.Click += new System.EventHandler(this.btn_AgregarAuto_Click);
            // 
            // btn_BorrarAuto
            // 
            this.btn_BorrarAuto.Location = new System.Drawing.Point(488, 703);
            this.btn_BorrarAuto.Name = "btn_BorrarAuto";
            this.btn_BorrarAuto.Size = new System.Drawing.Size(462, 57);
            this.btn_BorrarAuto.TabIndex = 8;
            this.btn_BorrarAuto.Text = "Borrar Auto";
            this.btn_BorrarAuto.UseVisualStyleBackColor = true;
            this.btn_BorrarAuto.Click += new System.EventHandler(this.btn_BorrarAuto_Click);
            // 
            // btn_EditarAuto
            // 
            this.btn_EditarAuto.Location = new System.Drawing.Point(488, 766);
            this.btn_EditarAuto.Name = "btn_EditarAuto";
            this.btn_EditarAuto.Size = new System.Drawing.Size(462, 56);
            this.btn_EditarAuto.TabIndex = 9;
            this.btn_EditarAuto.Text = "Editar Auto";
            this.btn_EditarAuto.UseVisualStyleBackColor = true;
            this.btn_EditarAuto.Click += new System.EventHandler(this.btn_EditarAuto_Click);
            // 
            // btn_AsignarAuto
            // 
            this.btn_AsignarAuto.Location = new System.Drawing.Point(968, 703);
            this.btn_AsignarAuto.Name = "btn_AsignarAuto";
            this.btn_AsignarAuto.Size = new System.Drawing.Size(422, 57);
            this.btn_AsignarAuto.TabIndex = 10;
            this.btn_AsignarAuto.Text = "Asignar Auto";
            this.btn_AsignarAuto.UseVisualStyleBackColor = true;
            this.btn_AsignarAuto.Click += new System.EventHandler(this.btn_AsignarAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1877, 871);
            this.Controls.Add(this.btn_AsignarAuto);
            this.Controls.Add(this.btn_EditarAuto);
            this.Controls.Add(this.btn_BorrarAuto);
            this.Controls.Add(this.btn_AgregarAuto);
            this.Controls.Add(this.dataGridViewDetallesAuto);
            this.Controls.Add(this.btn_EditarPersona);
            this.Controls.Add(this.btn_BorrarPersona);
            this.Controls.Add(this.btn_AgregarPersona);
            this.Controls.Add(this.dataGridViewAutosPersona);
            this.Controls.Add(this.dataGridViewAutos);
            this.Controls.Add(this.dataGridViewPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutosPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallesAuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonas;
        private System.Windows.Forms.DataGridView dataGridViewAutos;
        private System.Windows.Forms.DataGridView dataGridViewAutosPersona;
        private System.Windows.Forms.Button btn_AgregarPersona;
        private System.Windows.Forms.Button btn_BorrarPersona;
        private System.Windows.Forms.Button btn_EditarPersona;
        private System.Windows.Forms.DataGridView dataGridViewDetallesAuto;
        private System.Windows.Forms.Button btn_AgregarAuto;
        private System.Windows.Forms.Button btn_BorrarAuto;
        private System.Windows.Forms.Button btn_EditarAuto;
        private System.Windows.Forms.Button btn_AsignarAuto;
    }
}

