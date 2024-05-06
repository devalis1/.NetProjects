using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradorCeleste
{
    public partial class Form1 : Form
    {

        private BindingList<Alumno> alumnos = new BindingList<Alumno>();

        public Form1()
        {
            InitializeComponent();
            dataGridViewAlumnos.DataSource = alumnos;
            dataGridViewAlumnos.SelectionChanged += DataGridViewAlumnos_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewAlumnos.MultiSelect = false;
            dataGridViewAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DataGridViewAlumnos_SelectionChanged (object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.CurrentRow != null)
            {
                Alumno alumnoSeleccionado = dataGridViewAlumnos.CurrentRow.DataBoundItem as Alumno;
                if (alumnoSeleccionado != null)
                {
                    txt_Antiguedad.Text = alumnoSeleccionado.Antiguedad("años").ToString();
                    txt_EdadIngreso.Text = alumnoSeleccionado.EdadDeIngreso().ToString();
                    txt_MateriasNoAprobadas.Text = alumnoSeleccionado.MateriasNoAprobadas().ToString();
                }
               
            }
        }

        private void btn_AgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                var legajo = Interaction.InputBox("Ingrese el legajo:", "Agregar Alumno");
                if (string.IsNullOrWhiteSpace(legajo))
                {
                    MessageBox.Show("El legajo no puede estar vacio !!!");
                    return;
                }
                int parsedLegajo;
                if (!int.TryParse(legajo, out parsedLegajo))
                {
                    MessageBox.Show("El legajo debe ser un número !!!");
                    return;
                }

                var nombre = Interaction.InputBox("Ingrese el nombre:", "Agregar Alumno");
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacio !!!");
                    return;
                }

                var apellido = Interaction.InputBox("Ingrese el apellido:", "Agregar Alumno");
                if (string.IsNullOrWhiteSpace(apellido))
                {
                    MessageBox.Show("El apellido no puede estar vacio !!!");
                    return;
                }

                var fechaNacimiento = Interaction.InputBox("Ingrese la fecha de nacimiento:", "Agregar Alumno");
                DateTime parsedFechaNacimiento;
                if (!DateTime.TryParseExact(fechaNacimiento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedFechaNacimiento))
                {
                    MessageBox.Show("Fecha de nacimiento incorrecto !!!");
                    return;
                }

                var fechaIngreso = Interaction.InputBox("Ingrese la fecha de ingreso:", "Agregar Alumno");
                DateTime parsedFechaIngreso;
                if (!DateTime.TryParseExact(fechaIngreso, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedFechaIngreso))
                {
                    MessageBox.Show("Fecha de ingreso incorrecto !!!");
                    return;
                }

                var activo = Interaction.InputBox("El alumno esta activo? (si/no):", "Agregar Alumno");
                bool parsedActivo = activo.ToLower() == "si";

                var cantMateriasAprobadas = Interaction.InputBox("Ingrese el numero de materias aprobadas:", "Agregar Alumno");
                int parsedCantMateriasAprobadas;
                if (!int.TryParse(cantMateriasAprobadas, out parsedCantMateriasAprobadas))
                {
                    MessageBox.Show("Ingrese un número !!!");
                    return;
                }

            
                Alumno nuevoAlumno = new Alumno(parsedLegajo, nombre, apellido, parsedFechaNacimiento, parsedFechaIngreso, parsedActivo, parsedCantMateriasAprobadas);
                alumnos.Add(nuevoAlumno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el alumno: " + ex.Message);
            }
        }


        private void btn_EliminarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAlumnos.Rows.Count == 0 || dataGridViewAlumnos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Ningun Alumno seleccionado para eliminar !!!");
                    return;
                }

                var confirmarEliminar = MessageBox.Show("Eliminar al alumno seleccionado?", "Confirmar Eliminar", MessageBoxButtons.YesNo);
                if (confirmarEliminar == DialogResult.Yes)
                {
                    var alumno = dataGridViewAlumnos.SelectedRows[0].DataBoundItem as Alumno;
                    if (alumno != null)
                    {
                        alumnos.Remove(alumno);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el alumno !!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar al alumno: " + ex.Message);
            }
        }


        private void btn_EditarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAlumnos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccionar un alumno para editar !!!");
                    return;
                }

                Alumno alumnoSeleccionado = dataGridViewAlumnos.SelectedRows[0].DataBoundItem as Alumno;
                if (alumnoSeleccionado == null)
                {
                    MessageBox.Show("Error al obtener el alumno !!!");
                    return;
                }

                var legajo = Interaction.InputBox("Editar legajo:", "Editar Alumno", alumnoSeleccionado.Legajo.ToString());
                if (!int.TryParse(legajo, out int parsedLegajo))
                {
                    MessageBox.Show("El legajo debe ser un número !!!");
                    return;
                }
                alumnoSeleccionado.Legajo = parsedLegajo;

                var nombre = Interaction.InputBox("Editar nombre:", "Editar Alumno", alumnoSeleccionado.Nombre);
                if (!string.IsNullOrEmpty(nombre))
                    alumnoSeleccionado.Nombre = nombre;

                var apellido = Interaction.InputBox("Editar apellido:", "Editar Alumno", alumnoSeleccionado.Apellido);
                if (!string.IsNullOrEmpty(apellido))
                    alumnoSeleccionado.Apellido = apellido;

                var fechaNacimiento = Interaction.InputBox("Editar fecha de nacimiento:", "Editar Alumno", alumnoSeleccionado.GetFechaNacimiento().ToString("dd/MM/yyyy"));
                if (!DateTime.TryParseExact(fechaNacimiento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedFechaNacimiento))
                {
                    MessageBox.Show("Fecha de nacimiento incorrecta !!!");
                    return;
                }
                alumnoSeleccionado.FechaNacimiento = parsedFechaNacimiento;

                var fechaIngreso = Interaction.InputBox("Editar fecha de ingreso:", "Editar Alumno", alumnoSeleccionado.GetFechaIngreso().ToString("dd/MM/yyyy"));
                if (!DateTime.TryParseExact(fechaIngreso, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedFechaIngreso))
                {
                    MessageBox.Show("Fecha de ingreso incorrecta !!!");
                    return;
                }
                alumnoSeleccionado.FechaIngreso = parsedFechaIngreso;

                var activo = Interaction.InputBox("El alumno esta activo? (si/no):", "Editar Alumno", alumnoSeleccionado.Activo ? "si" : "no");
                alumnoSeleccionado.Activo = activo.ToLower() == "si";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar al alumno: " + ex.Message);
            }
        }

    }
}
