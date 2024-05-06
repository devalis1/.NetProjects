using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TrabajoIntegradorUnidad1_Devalis
{
    public partial class Form1 : Form
    {
        private AdministradorDePersonasYAutos administradorDePersonasYAutos;
        public Form1()
        {
            InitializeComponent();
            administradorDePersonasYAutos = new AdministradorDePersonasYAutos();
            dataGridViewPersonas.SelectionChanged += DataGridViewPersonas_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewPersonas.MultiSelect = false;
            dataGridViewAutos.MultiSelect = false;
            dataGridViewAutosPersona.MultiSelect = false;
            dataGridViewDetallesAuto.MultiSelect = false;

            dataGridViewPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAutosPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetallesAuto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Mostrar(DataGridView gridView, object pO)
        {
            gridView.DataSource = null;
            gridView.DataSource = pO;
        }


        private void DataGridViewPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPersonas.CurrentRow != null)
            {
                var personaSeleccionada = dataGridViewPersonas.CurrentRow.DataBoundItem as Persona;
                if (personaSeleccionada != null)
                {
                    dataGridViewAutosPersona.DataSource = null;
                    dataGridViewAutosPersona.DataSource = new BindingList<Auto>(personaSeleccionada.ListaDeAutos());
                }
            }
        }

        private void btn_AgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                var dni = Interaction.InputBox("Ingrese DNI:", "Agregar Persona");
                if (string.IsNullOrWhiteSpace(dni))
                {
                    MessageBox.Show("El DNI no puede estar vacio.");
                    return;
                }
                if (administradorDePersonasYAutos.ExisteDNI(dni))
                {
                    throw new Exception("El DNI que intenta dar de alta ya existe !!!");
                }

                var nombre = Interaction.InputBox("Ingrese Nombre:", "Agregar Persona");
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacío.");
                    return;
                }

                var apellido = Interaction.InputBox("Ingrese Apellido:", "Agregar Persona");
                if (string.IsNullOrWhiteSpace(apellido))
                {
                    MessageBox.Show("El apellido no puede estar vacío.");
                    return;
                }

                var persona = new Persona(dni, nombre, apellido); 
                administradorDePersonasYAutos.AgregarPersona(persona);
                Mostrar(dataGridViewPersonas, administradorDePersonasYAutos.ObtenerPersonas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btn_BorrarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPersonas.Rows.Count == 0) throw new Exception("No hay personas para borrar !!!");
                var persona = dataGridViewPersonas.SelectedRows[0].DataBoundItem as Persona;
                administradorDePersonasYAutos.EliminarPersona(persona.DNI);
                Mostrar(dataGridViewPersonas, administradorDePersonasYAutos.ObtenerPersonas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_EditarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPersonas.Rows.Count == 0) throw new Exception("No hay personas para modificar !!!");
                var persona = dataGridViewPersonas.SelectedRows[0].DataBoundItem as Persona;
                persona.Nombre = Interaction.InputBox("Nombre:", "editando el nombre...", persona.Nombre);
                persona.Apellido = Interaction.InputBox("Apellido: ", "editando el apellido...", persona.Apellido);
                administradorDePersonasYAutos.ModificarPersona(persona);
                Mostrar(dataGridViewPersonas, administradorDePersonasYAutos.ObtenerPersonas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_AgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                var patente = Interaction.InputBox("Ingrese Patente:", "Agregar Auto");
                if (string.IsNullOrWhiteSpace(patente))
                {
                    MessageBox.Show("El número de la patente no puede estar vacío.");
                    return;
                }
                if (administradorDePersonasYAutos.ExistePatente(patente))
                {
                    throw new Exception("La patente del auto que intenta agregar ya existe !!!");
                }

                var marca = Interaction.InputBox("Ingrese la marca", "Agregar Marca");
                if (string.IsNullOrWhiteSpace(marca))
                {
                    MessageBox.Show("El nombre de la marca no puede estar vacío");
                    return;
                }

                var modelo = Interaction.InputBox("Ingrese el modelo", "Agregar Modelo");
                if (string.IsNullOrWhiteSpace(modelo))
                {
                    MessageBox.Show("El modelo no puede estar vacío");
                    return;
                }

                var añoString = Interaction.InputBox("Ingrese el año", "Agregar Año");
                if (!int.TryParse(añoString, out int año) || año > DateTime.Now.Year)
                {
                    MessageBox.Show("Debe ingresar un año válido.");
                    return;
                }

                var precioString = Interaction.InputBox("Ingrese el precio", "Agregar Precio");
                if (!decimal.TryParse(precioString, out decimal precio) || precio < 0)
                {
                    MessageBox.Show("Debe ingresar un precio válido.");
                    return;
                }

                var auto = new Auto(patente, marca, modelo, año.ToString(), precio);
                administradorDePersonasYAutos.AgregarAuto(auto);
                Mostrar(dataGridViewAutos, administradorDePersonasYAutos.ObtenerAutos());
                ActualizarDetallesAutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_BorrarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAutos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar el auto para borrar.");
                    return;
                }

                var confirmResult = MessageBox.Show("Seguro de querer borrar el auto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var auto = dataGridViewAutos.CurrentRow.DataBoundItem as Auto;
                    administradorDePersonasYAutos.EliminarAuto(auto.Patente);
                    Mostrar(dataGridViewAutos, administradorDePersonasYAutos.ObtenerAutos());
                    ActualizarDetallesAutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el auto: " + ex.Message);
            }
        }


        private void btn_EditarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAutos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar el auto para editar.");
                    return;
                }

                var auto = dataGridViewAutos.CurrentRow.DataBoundItem as Auto;

                var nuevaMarca = Interaction.InputBox("Nueva marca:", "Editar Auto", auto.Marca);
                var nuevoModelo = Interaction.InputBox("Nuevo modelo:", "Editar Auto", auto.Modelo);
                var nuevoAño = Interaction.InputBox("Nuevo año:", "Editar Auto", auto.Año);
                var nuevoPrecio = Interaction.InputBox("Nuevo precio:", "Editar Auto", auto.Precio.ToString());

                if (!string.IsNullOrWhiteSpace(nuevaMarca)) auto.Marca = nuevaMarca;
                if (!string.IsNullOrWhiteSpace(nuevoModelo)) auto.Modelo = nuevoModelo;
                if (!string.IsNullOrWhiteSpace(nuevoAño)) auto.Año = nuevoAño;
                decimal precioDecimal;
                if (decimal.TryParse(nuevoPrecio, out precioDecimal) && precioDecimal >= 0)
                {
                    int precioInt = (int)precioDecimal;
                    administradorDePersonasYAutos.ModificarAuto(auto.Patente, nuevaMarca, nuevoModelo, nuevoAño, precioInt);
                }
                Mostrar(dataGridViewAutos, administradorDePersonasYAutos.ObtenerAutos());
                ActualizarDetallesAutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el auto: " + ex.Message);
            }
        }

        private void btn_AsignarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPersonas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar una persona.");
                    return;
                }
                if (dataGridViewAutos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un auto.");
                    return;
                }

                var personaSeleccionada = dataGridViewPersonas.CurrentRow.DataBoundItem as Persona;
                var autoSeleccionado = dataGridViewAutos.CurrentRow.DataBoundItem as Auto;

                if (autoSeleccionado.Dueño != null)
                {
                    MessageBox.Show("Este auto ya tiene un dueño !!!");
                    return;
                }

                personaSeleccionada.AgregarAuto(autoSeleccionado);

                Mostrar(dataGridViewAutosPersona, personaSeleccionada.ListaDeAutos());
                Mostrar(dataGridViewPersonas, administradorDePersonasYAutos.ObtenerPersonas());
                ActualizarDetallesAutos();
                MessageBox.Show("Auto asignado =)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar el auto: " + ex.Message);
            }
        }
        private void ActualizarDetallesAutos()
        {
            var detallesAutos = new BindingList<DetalleAuto>();

            foreach (Auto auto in administradorDePersonasYAutos.ObtenerAutos())
            {
                var detalle = new DetalleAuto
                {
                    Marca = auto.Marca,
                    Año = auto.Año,
                    Modelo = auto.Modelo,
                    Patente = auto.Patente,
                    DniDueño = auto.Dueño?.DNI ?? "Sin Dueño",
                    NombreCompletoDueño = auto.Dueño != null ? $"{auto.Dueño.Apellido}, {auto.Dueño.Nombre}" : "Sin Dueño"
                };
                detallesAutos.Add(detalle);
            }

            dataGridViewDetallesAuto.DataSource = detallesAutos;
        }


    }
}
