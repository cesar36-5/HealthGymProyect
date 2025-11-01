using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosHG.CapaDatoss.PlanNutricional;
using CapaEntidadHG.CapaEntidad.PlanNutricional;
using CapaLogicaHG.CapaLogica.PlanNutricional;

namespace HealthGym.PlanNutricional
{
    public partial class EvaluacionNutricional : Form
    {
        public EvaluacionNutricional()
        {
            InitializeComponent();
            listarDatos();
            gbDatos.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void Limpiar()
        {
            txtObservaciones.Text = "";
            txtEvolucion.Text = "";
            txtReqEnergetico.Text = "";
            txtObjetivo1.Text = "";
            txtObjetivo2.Text = "";
            txtObjetivo3.Text = "";
            chkSaludable.Checked = false;
        }

        public void listarDatos()
        {
            dgvEvaNutricional.DataSource = logEvaluacionNutricional.Instancia.ListarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEvaluacionNutricional n = new entEvaluacionNutricional();
                n.Saludable = chkSaludable.Checked;
                n.Observacion = txtObservaciones.Text.Trim();
                n.Evolucion = txtEvolucion.Text.Trim();

                int reqEnergetico;
                if (!int.TryParse(txtReqEnergetico.Text.Trim(), out reqEnergetico))
                {
                    reqEnergetico = 0; // Control de versiones
                }
                n.ReqEnergetico = reqEnergetico;
                n.ObjetivoNutri1 = txtObjetivo1.Text.Trim();
                n.ObjetivoNutri2 = txtObjetivo2.Text.Trim();
                n.ObjetivoNutri3 = txtObjetivo3.Text.Trim();

                bool resultado = logEvaluacionNutricional.Instancia.InsertarEvaluacion(n);

                if (resultado)
                {
                    MessageBox.Show("Evaluación nutricional registrada correctamente");

                    Limpiar();
                    gbDatos.Enabled = false;
                    listarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la evaluación");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al agregar valores" + ex);
            }
            Limpiar();
            gbDatos.Enabled = false;
            listarDatos();
        }

        private void dgvEvaNutricional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEvaNutricional.Rows[e.RowIndex]; //
            chkSaludable.Checked = Convert.ToBoolean(filaActual.Cells[1].Value);
            txtObservaciones.Text = filaActual.Cells[2].Value.ToString();
            txtEvolucion.Text = filaActual.Cells[3].Value.ToString();
            txtReqEnergetico.Text = filaActual.Cells[4].Value.ToString();
            txtObjetivo1.Text = filaActual.Cells[5].Value.ToString();
            txtObjetivo2.Text = filaActual.Cells[6].Value.ToString();
            txtObjetivo3.Text = filaActual.Cells[7].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (dgvEvaNutricional.CurrentRow != null)
            {
                DataGridViewRow fila = dgvEvaNutricional.CurrentRow;
                // Cambiar color de fondo
                fila.Cells["ObjetivoNutri1"].Style.BackColor = Color.LightGray;
                fila.Cells["ObjetivoNutri2"].Style.BackColor = Color.LightGray;
                fila.Cells["ObjetivoNutri3"].Style.BackColor = Color.LightGray;
                // Cambiar color del texto
                fila.Cells["ObjetivoNutri1"].Style.ForeColor = Color.DarkGray;
                fila.Cells["ObjetivoNutri2"].Style.ForeColor = Color.DarkGray;
                fila.Cells["ObjetivoNutri3"].Style.ForeColor = Color.DarkGray;

                // No aceptar edición
                fila.Cells["ObjetivoNutri1"].ReadOnly = true;
                fila.Cells["ObjetivoNutri2"].ReadOnly = true;
                fila.Cells["ObjetivoNutri3"].ReadOnly = true;

                MessageBox.Show("Objetivos deshabilitados");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila primero");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEvaluacionNutricional n = new entEvaluacionNutricional();
                n.Id = Convert.ToInt64(dgvEvaNutricional.CurrentRow.Cells["Id"].Value);
                n.Saludable = chkSaludable.Checked;
                n.Observacion = txtObservaciones.Text.Trim();
                n.Evolucion = txtEvolucion.Text.Trim();

                int reqEnergetico;
                if (!int.TryParse(txtReqEnergetico.Text.Trim(), out reqEnergetico))
                {
                    reqEnergetico = 0; // Control de versiones
                }
                n.ReqEnergetico = reqEnergetico;
                n.ObjetivoNutri1 = txtObjetivo1.Text.Trim();
                n.ObjetivoNutri2 = txtObjetivo2.Text.Trim();
                n.ObjetivoNutri3 = txtObjetivo3.Text.Trim();

                bool resultado = logEvaluacionNutricional.Instancia.EditarEvaluacion(n);

                if (resultado)
                {
                    MessageBox.Show("Evaluación nutricional editada correctamente");
                    listarDatos();
                    Limpiar();
                    gbDatos.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo editar la evaluación");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al agregar valores" + ex);
            }
        }
    }
}
