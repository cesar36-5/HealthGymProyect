using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthGym.CapaLogica;
using HealthGym.CapaEntidad;

namespace HealthGym
{
    public partial class MantenedorTrabajador : Form
    {
        public MantenedorTrabajador()
        {
            InitializeComponent();
            listarTrabajador();
            grpDatosTrabajador.Enabled = false;
            txtDNI.Enabled = true;
        }
        public void listarTrabajador()
        {
            dgvTrabajador.DataSource = null;
            dgvTrabajador.DataSource = LogTrabajador.Instancia.ListarTrabajador();
        }

        private void dgvTrabajador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTrabajador.Rows[e.RowIndex];

                txtNombres.Text = fila.Cells["Nombres"].Value?.ToString();
                txtApellidos.Text = fila.Cells["Apellidos"].Value?.ToString();
                txtDNI.Text = fila.Cells["DNI"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                string sexoValor = fila.Cells["Sexo"].Value?.ToString();
                txtSexo.Text = sexoValor == "1" ? "Masculino" : "Femenino";
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString();
                txtCargo.Text = fila.Cells["Cargo"].Value?.ToString();
                txtSalario.Text = fila.Cells["Salario"].Value?.ToString();
                txtEspecialidad.Text = fila.Cells["Especialidad"].Value?.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            grpDatosTrabajador.Enabled = true;
            limpiarCampos();
            txtDNI.Enabled = true;

            btnGuardar.Visible = true;
            btnModificar.Visible = false;
        }
        private void limpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtSexo.Clear();
            txtCorreo.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            txtEspecialidad.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Seleccione un trabajador de la tabla");
                return;
            }
            grpDatosTrabajador.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    MessageBox.Show("Seleccione un trabajador primero.");
                    return;
                }


                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este trabajador?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.No)
                    return;

                EntTrabajador t = new EntTrabajador { DNI = txtDNI.Text.Trim() };

                bool ok = LogTrabajador.Instancia.EliminarTrabajador(txtDNI.Text.Trim());

                if (ok)
                    MessageBox.Show("✅ Trabajador eliminado correctamente");
                else
                    MessageBox.Show("⚠️ No se pudo eliminar el trabajador");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar: " + ex.Message);
            }

            listarTrabajador();
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpDatosTrabajador.Enabled = false;
            limpiarCampos();
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    MessageBox.Show("Seleccione un trabajador para modificar");
                    return;
                }


                int sexoInt = (txtSexo.Text.Trim() == "Masculino" || txtSexo.Text.Trim() == "1") ? 1 : 0;

                EntTrabajador t = new EntTrabajador
                {
                    DNI = txtDNI.Text.Trim(),
                    Nombres = txtNombres.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Sexo = sexoInt,
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Cargo = int.Parse(txtCargo.Text.Trim()),
                    Salario = double.Parse(txtSalario.Text.Trim()),
                    Especialidad = int.Parse(txtEspecialidad.Text.Trim())
                };

                bool ok = LogTrabajador.Instancia.EditarTrabajador(t);

                MessageBox.Show(ok
                    ? "✅ Trabajador actualizado correctamente"
                    : "⚠️ No se pudo actualizar el trabajador");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al editar: " + ex.Message);
            }

            listarTrabajador();
            grpDatosTrabajador.Enabled = false;
            limpiarCampos();
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtDNI.Text) ||
                    string.IsNullOrWhiteSpace(txtSalario.Text))
                {
                    MessageBox.Show("Complete los campos obligatorios.");
                    return;
                }

                if (!double.TryParse(txtSalario.Text.Trim(), out double salario))
                {
                    MessageBox.Show("Salario inválido.");
                    return;
                }


                int sexoInt = (txtSexo.Text.Trim() == "Masculino" || txtSexo.Text.Trim() == "1") ? 1 : 0;

                EntTrabajador t = new EntTrabajador
                {
                    Nombres = txtNombres.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    DNI = txtDNI.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Sexo = sexoInt,
                    Correo = txtCorreo.Text.Trim(),
                    Cargo = int.Parse(txtCargo.Text.Trim()),
                    Salario = salario,
                    Especialidad = int.Parse(txtEspecialidad.Text.Trim())
                };

                bool ok = LogTrabajador.Instancia.AgregarTrabajador(t);
                MessageBox.Show(ok ? "✅ Trabajador agregado correctamente" : "⚠️ No se pudo agregar el trabajador");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al agregar: " + ex.Message);
            }

            listarTrabajador();
            grpDatosTrabajador.Enabled = false;
            limpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtDNI.Enabled = true;
            txtDNI.Focus();

            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDNI.Focus();
                return;
            }

            var t = LogTrabajador.Instancia.BuscarTrabajador(dni);

            if (t != null)
            {
                dgvTrabajador.DataSource = new List<EntTrabajador> { t };

                grpDatosTrabajador.Enabled = true;

                txtNombres.Text = t.Nombres;
                txtApellidos.Text = t.Apellidos;
                txtDNI.Text = t.DNI;
                txtTelefono.Text = t.Telefono;
                txtCorreo.Text = t.Correo;
                txtSalario.Text = t.Salario.ToString("F2");
                txtSexo.Text = t.Sexo == 1 ? "Masculino" : "Femenino";

                txtCargo.Text = t.Cargo.ToString();
                txtEspecialidad.Text = t.Especialidad.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró ningún trabajador con ese DNI.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvTrabajador.DataSource = null;

                grpDatosTrabajador.Enabled = false;
                txtDNI.Enabled = true;
                txtDNI.Focus();

                txtNombres.Clear();
                txtApellidos.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtSalario.Clear();
                txtCargo.Clear();
                txtEspecialidad.Clear();
                txtSexo.Clear();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listarTrabajador();

            limpiarCampos();

            grpDatosTrabajador.Enabled = false;

            btnAgregar.Visible = true;
            btnModificar.Visible = false;

            MessageBox.Show("🔄 Datos actualizados correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
