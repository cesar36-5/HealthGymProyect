using HealthGym.CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthGym
{
    public partial class MantenedorMiembro : Form
    {
        public MantenedorMiembro()
        {
            InitializeComponent();
            listarMiembros();
            groupMiembro.Enabled = false;
            txtDNI.Enabled = true;
        }
        private void listarMiembros()
        {
            dgvMiembros.DataSource = null;
            dgvMiembros.DataSource = LogMiembro.Instancia.ListarMiembro();
        }
        private void limpiarCampos()
        {
            txtId.Clear();
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtSexo.Clear();
            txtCorreo.Clear();
            txtSanguineo.Clear();
            txtSeguro.Clear();

            dtpFecha.Value = DateTime.Now;
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
        }
        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EntMiembro m = (EntMiembro)dgvMiembros.Rows[e.RowIndex].DataBoundItem;

                txtId.Text = m.Id.ToString();
                txtDNI.Text = m.DNI;
                txtNombres.Text = m.Nombres;
                txtApellidos.Text = m.Apellidos;
                txtTelefono.Text = m.Telefono;
                txtSexo.Text = m.Sexo.ToString();
                txtCorreo.Text = m.Correo;
                txtSanguineo.Text = m.GrupoSanguineo;
                txtSeguro.Text = m.Seguro;
                dtpFecha.Value = m.FechaNacimiento;
                dtpInicio.Value = m.InicioMembresia;
                dtpFin.Value = m.FinalMembresia;

                groupMiembro.Enabled = true;
                btnModificar.Visible = true;
                btnGuardar.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Trim() == "" || txtNombres.Text.Trim() == "" || txtApellidos.Text.Trim() == "")
            {
                MessageBox.Show("Complete los campos obligatorios");
                return;
            }

            int sexo = (txtSexo.Text.Trim().ToLower() == "masculino" || txtSexo.Text.Trim() == "1") ? 1 : 0;

            EntMiembro m = new EntMiembro()
            {
                DNI = txtDNI.Text.Trim(),
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Sexo = sexo,
                Correo = txtCorreo.Text.Trim(),
                GrupoSanguineo = txtSanguineo.Text.Trim(),
                Seguro = txtSeguro.Text.Trim(),
                FechaNacimiento = dtpFecha.Value,
                InicioMembresia = dtpInicio.Value,
                FinalMembresia = dtpFin.Value
            };

            try
            {
                bool ok = LogMiembro.Instancia.AgregarMiembro(m);
                MessageBox.Show(ok ? "✅ Miembro registrado correctamente" : "⚠ No se pudo registrar");

                listarMiembros();
                groupMiembro.Enabled = false;
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            groupMiembro.Enabled = true;
            limpiarCampos();
            txtDNI.Enabled = true;

            btnGuardar.Visible = true;
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                MessageBox.Show("Seleccione un miembro para editar");
                return;
            }

            groupMiembro.Enabled = true;
            btnModificar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int sexo = (txtSexo.Text.Trim().ToLower() == "masculino" || txtSexo.Text.Trim() == "1") ? 1 : 0;

                EntMiembro m = new EntMiembro()
                {
                    Id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                    DNI = txtDNI.Text.Trim(),
                    Nombres = txtNombres.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Sexo = sexo,
                    Correo = txtCorreo.Text.Trim(),
                    GrupoSanguineo = txtSanguineo.Text.Trim(),
                    Seguro = txtSeguro.Text.Trim(),
                    FechaNacimiento = dtpFecha.Value,
                    InicioMembresia = dtpInicio.Value,
                    FinalMembresia = dtpFin.Value
                };

                bool ok = LogMiembro.Instancia.EditarMiembro(m);
                MessageBox.Show(ok ? "✅ Miembro actualizado correctamente" : "⚠️ No se pudo actualizar");

                listarMiembros();
                groupMiembro.Enabled = false;
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                MessageBox.Show("Seleccione un miembro");
                return;
            }

            if (MessageBox.Show("¿Eliminar este miembro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                bool ok = LogMiembro.Instancia.EliminarMiembro(txtDNI.Text.Trim());
                MessageBox.Show(ok ? "🗑️ Miembro eliminado correctamente" : "⚠️ No se pudo eliminar");
                listarMiembros();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listarMiembros();
            limpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI para buscar");
                return;
            }

            EntMiembro m = LogMiembro.Instancia.BuscarMiembro(dni);

            if (m != null)
            {
                txtId.Text = m.Id.ToString();
                txtNombres.Text = m.Nombres;
                txtApellidos.Text = m.Apellidos;
                txtTelefono.Text = m.Telefono;
                txtSexo.Text = m.Sexo.ToString();
                txtCorreo.Text = m.Correo;
                dtpInicio.Value = m.InicioMembresia;
                dtpFin.Value = m.FinalMembresia;
                txtSanguineo.Text = m.GrupoSanguineo;
                txtSeguro.Text = m.Seguro;
                dtpFecha.Value = m.FechaNacimiento;
            }
            else
            {
                MessageBox.Show("Miembro no encontrado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtSexo.Clear();
            txtCorreo.Clear();
            txtSanguineo.Clear();
            txtSeguro.Clear();
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            dtpFecha.Value = DateTime.Now;

            txtDNI.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
