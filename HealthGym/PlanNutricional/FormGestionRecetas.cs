using CapaLogicaHG.PlanNutricional;
using CapaEntidadHG.CapaEntidad.PlanNutricional;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HealthGym.PlanNutricional
{
    public partial class FormGestionRecetas : Form
    {
        // Variable global para guardar el ID de la receta que estamos editando
        private int recetaIDActual = 0;

        public FormGestionRecetas()
        {
            InitializeComponent();
            LimpiarYBloquearControles();
        }

        // Constructor sobrecargado: Permite abrir el formulario
        // pasándole un ID de receta desde otro formulario.
        public FormGestionRecetas(int recetaID)
        {
            InitializeComponent();
            this.recetaIDActual = recetaID;
            numRecetaID.Value = recetaID;
            CargarPasos();
            DesbloquearControles();
        }

        /// <summary>
        /// Carga los pasos de la receta actual en el ListBox
        /// </summary>
        private void CargarPasos()
        {
            if (recetaIDActual == 0) return;

            try
            {
                // Llama a la Capa Lógica para obtener los pasos
                List<entRecetaPaso> lista = logRecetaPaso.Instancia.ListarPasosPorReceta(recetaIDActual);

                // Configura el ListBox para que muestre el texto (Instruccion)
                // y guarde el ID (PasoID)
                lstPasos.DataSource = lista;
                lstPasos.DisplayMember = "Instruccion"; // Muestra la instrucción
                lstPasos.ValueMember = "PasoID";       // Guarda el PasoID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pasos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia todos los controles y los deshabilita
        /// </summary>
        private void LimpiarYBloquearControles()
        {
            lstPasos.DataSource = null;
            txtInstruccion.Clear();
            txtInstruccion.Enabled = false;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnSubir.Enabled = false;
            btnBajar.Enabled = false;
        }

        /// <summary>
        /// Habilita los controles para la edición
        /// </summary>
        private void DesbloquearControles()
        {
            txtInstruccion.Enabled = true;
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnSubir.Enabled = true;
            btnBajar.Enabled = true;
        }

        // --- EVENTOS DE LOS CONTROLES ---

        /// <summary>
        /// Evento del botón "Buscar": Carga los pasos de la RecetaID indicada
        /// </summary>
        private void btnBuscarReceta_Click(object sender, EventArgs e)
        {
            recetaIDActual = (int)numRecetaID.Value;
            if (recetaIDActual > 0)
            {
                CargarPasos();
                DesbloquearControles();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de receta válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarYBloquearControles();
            }
        }

        /// <summary>
        /// Evento del ListBox: Muestra la instrucción seleccionada en el TextBox
        /// </summary>
        private void lstPasos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya un item seleccionado
            if (lstPasos.SelectedItem != null)
            {
                // Convertimos el item seleccionado al tipo de entidad
                entRecetaPaso pasoSeleccionado = (entRecetaPaso)lstPasos.SelectedItem;
                txtInstruccion.Text = pasoSeleccionado.Instruccion;
            }
        }

        /// <summary>
        /// Evento del botón "Agregar": Añade un nuevo paso
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstruccion.Text))
            {
                MessageBox.Show("La instrucción no puede estar vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entRecetaPaso nuevoPaso = new entRecetaPaso
                {
                    RecetaID = recetaIDActual,
                    Instruccion = txtInstruccion.Text
                };

                // Llama a la Capa Lógica para insertar
                bool exito = logRecetaPaso.Instancia.InsertarPaso(nuevoPaso);

                if (exito)
                {
                    txtInstruccion.Clear();
                    CargarPasos(); // Recarga la lista
                }
                else
                {
                    MessageBox.Show("Error al agregar el paso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento del botón "Guardar": Actualiza la instrucción de un paso existente
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lstPasos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paso de la lista para guardarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInstruccion.Text))
            {
                MessageBox.Show("La instrucción no puede estar vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int pasoID = (int)lstPasos.SelectedValue;
                string nuevaInstruccion = txtInstruccion.Text;

                // Llama a la Capa Lógica para actualizar
                bool exito = logRecetaPaso.Instancia.ActualizarInstruccionPaso(pasoID, nuevaInstruccion);

                if (exito)
                {
                    CargarPasos(); // Recarga la lista
                }
                else
                {
                    MessageBox.Show("Error al guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento del botón "Eliminar": Borra un paso y reordena la lista
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPasos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paso de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación de seguridad
            DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar este paso?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            try
            {
                int pasoID = (int)lstPasos.SelectedValue;

                // Llama a la Capa Lógica para eliminar
                bool exito = logRecetaPaso.Instancia.EliminarPaso(pasoID);

                if (exito)
                {
                    // ¡Importante! Después de eliminar, hay que reordenar los números
                    logRecetaPaso.Instancia.ReordenarPasos(recetaIDActual);
                    CargarPasos(); // Recarga la lista
                    txtInstruccion.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el paso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento del botón "Subir": Mueve un paso hacia arriba en la lista
        /// </summary>
        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (lstPasos.SelectedItem == null) return;

            entRecetaPaso pasoActual = (entRecetaPaso)lstPasos.SelectedItem;
            int indiceActual = lstPasos.SelectedIndex;

            // Si es el primer item (índice 0), no puede subir más
            if (indiceActual == 0) return;

            try
            {
                int numeroPasoActual = pasoActual.NumeroPaso;
                int numeroPasoDestino = numeroPasoActual - 1;

                // Llama a la Capa Lógica para intercambiar
                bool exito = logRecetaPaso.Instancia.IntercambiarPasos(recetaIDActual, pasoActual.PasoID, numeroPasoActual, numeroPasoDestino);

                if (exito)
                {
                    CargarPasos();
                    // Mantiene seleccionado el item que movimos
                    lstPasos.SelectedIndex = indiceActual - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al subir el paso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento del botón "Bajar": Mueve un paso hacia abajo en la lista
        /// </summary>
        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (lstPasos.SelectedItem == null) return;

            entRecetaPaso pasoActual = (entRecetaPaso)lstPasos.SelectedItem;
            int indiceActual = lstPasos.SelectedIndex;

            // Si es el último item, no puede bajar más
            if (indiceActual == lstPasos.Items.Count - 1) return;

            try
            {
                int numeroPasoActual = pasoActual.NumeroPaso;
                int numeroPasoDestino = numeroPasoActual + 1;

                // Llama a la Capa Lógica para intercambiar
                bool exito = logRecetaPaso.Instancia.IntercambiarPasos(recetaIDActual, pasoActual.PasoID, numeroPasoActual, numeroPasoDestino);

                if (exito)
                {
                    CargarPasos();
                    // Mantiene seleccionado el item que movimos
                    lstPasos.SelectedIndex = indiceActual + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al bajar el paso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}