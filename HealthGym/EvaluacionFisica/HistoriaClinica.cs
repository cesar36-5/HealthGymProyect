using CapaEntidadHG.EvaluacionFisica;
using CapaLogicaHG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthGym.EvaluacionFisica
{
    public partial class HistoriaClinica : Form
    {
        LogHistoriaClinica logHistoria = new LogHistoriaClinica();

        public HistoriaClinica()
        {
            InitializeComponent();
            CargarMedicos();

        }
        private void CargarMedicos()
        {
            // Simulacion temporal luego se conectara con la Bd
            cbxResponsable.Items.Add("Dr. Juan Pérez");
            cbxResponsable.Items.Add("Dra. Ana Torres");
            cbxResponsable.Items.Add("Lic. Carlos Ramírez");
            cbxResponsable.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Ingrese el DNI del miembro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EntHistoriaClinica historia = new EntHistoriaClinica
                {
                    DniMiembro = txtDni.Text.Trim(),
                    Fecha = dtpFecha.Value,
                    Responsable = cbxResponsable.Text,
                    Observaciones = txtObservaciones.Text.Trim(),
                    Antecedentes = txtAntecedentes.Text.Trim(),
                    Diagnostico = txtDiagnostico.Text.Trim(),
                    Indicaciones = txtIndicaciones.Text.Trim()
                };

                string mensaje = logHistoria.Registrar(historia);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la historia clínica: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Ingrese el DNI del miembro para consultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime desde = DateTime.Now.AddMonths(-6); // Ejemplo: últimos 6 meses
                DateTime hasta = DateTime.Now;

                List<EntHistoriaClinica> lista = logHistoria.Consultar(txtDni.Text.Trim(), desde, hasta);

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron historias clínicas para el DNI indicado.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Se encontraron {lista.Count} registros para el DNI {txtDni.Text}", "Consulta exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdHistoria.Text))
                {
                    MessageBox.Show("Seleccione una historia clínica para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EntHistoriaClinica historia = new EntHistoriaClinica
                {
                    IdHistoriaClinica = int.Parse(txtIdHistoria.Text),
                    DniMiembro = txtDni.Text.Trim(),
                    Fecha = dtpFecha.Value,
                    Responsable = cbxResponsable.Text,
                    Observaciones = txtObservaciones.Text.Trim(),
                    Antecedentes = txtAntecedentes.Text.Trim(),
                    Diagnostico = txtDiagnostico.Text.Trim(),
                    Indicaciones = txtIndicaciones.Text.Trim()
                };


                MessageBox.Show("Historia clínica modificada correctamente (pendiente de lógica DB).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdHistoria.Text))
            {
                MessageBox.Show("Debe seleccionar una historia clínica para anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de anular esta historia clínica?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Historia clínica anulada correctamente (pendiente de implementación DB).");
                LimpiarCampos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
        private void LimpiarCampos()
        {
            txtIdHistoria.Clear();
            txtDni.Clear();
            txtObservaciones.Clear();
            txtAntecedentes.Clear();
            txtDiagnostico.Clear();
            txtIndicaciones.Clear();
            cbxResponsable.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Ingrese el DNI del miembro para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Búsqueda de miembro simulada (pendiente de integración con BD).");
        }
    }
}
        