using CapaEntidadHG.EvaluacionFisica;
using CapaLogicaHG.EvaluacionFisica; 
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
    public partial class EvaluacionFisica_2 : Form
    {
        private readonly LogEvaluacionFisica logEvaluacion = new LogEvaluacionFisica();

        public EvaluacionFisica_2()
        {
            InitializeComponent();
        }

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese el DNI del miembro.");
                return;
            }

            bool citaActiva = logEvaluacion.ValidarCitaActiva(dni);

            if (citaActiva)
            {
                lblEstadoCita.Text = "Estado: Cita activa";
                grpDatMiembro.Enabled = true;

                // Obtener datos del miembro y mostrar el nombre
                DataRow miembro = logEvaluacion.ObtenerDatosMiembro(dni);
                if (miembro != null)
                {
                    txtNombre.Text = $"{miembro["Nombre"]} {miembro["Apellido"]}";
                }
                else
                {
                    txtNombre.Text = "";
                    MessageBox.Show("No se encontraron datos del miembro con ese DNI.");
                }
            }
            else
            {
                lblEstadoCita.Text = "Estado: Sin cita activa";
                grpDatMiembro.Enabled = false;
                txtNombre.Text = "";
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntEvaluacionFisica evaluacion = new EntEvaluacionFisica
            {
                DNI = txtDNI.Text.Trim(),
                Fecha = dtpFecha.Value,
                SignosVitales = txtSignosVitales.Text,
                Antropometria = txtAntropometria.Text,
                Postura = txtPostura.Text,
                Valoracion = txtValoracion.Text
            };

            bool exito = logEvaluacion.RegistrarEvaluacion(evaluacion);

            if (exito)
                MessageBox.Show("Evaluación física registrada correctamente.");
            else
                MessageBox.Show("Error al registrar la evaluación.");
        }
        private void CargarEvaluaciones()
        {
            try
            {
                DataTable datos = logEvaluacion.ListarEvaluaciones();
                dgvEvaluaciones.DataSource = datos;
                dgvEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las evaluaciones: " + ex.Message);
            }
        }
    }
}

