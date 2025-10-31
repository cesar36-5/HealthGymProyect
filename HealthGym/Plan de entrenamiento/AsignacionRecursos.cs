using HealthGym.CapaEntidad.RecursosDeportivos;
using HealthGym.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthGym.Plan_de_entrenamiento
{
    public partial class AsignacionRecursos : Form
    {
        public EntRecurso recursoSeleccionado = null;
        public EntRecursoDisponibilidad recursDispSeleccionado = null;
        public List<EntRecursoDisponibilidad> disponibilidad = new List<EntRecursoDisponibilidad>();
        public AsignacionRecursos()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EntRecurso> recursos = new List<EntRecurso>();
            recursos = LogRecurso.Instancia.ListarRecursos();
            comboBox1.DataSource = recursos;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
            recursoSeleccionado = (EntRecurso)comboBox1.SelectedItem;
            CargarHorario(recursoSeleccionado);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            recursoSeleccionado = (EntRecurso)comboBox1.SelectedItem;
            CargarHorario(recursoSeleccionado);
        }

        private void CargarHorario(EntRecurso recurso)
        {
            disponibilidad = LogRecurso.Instancia.ListarDisponibilidad(recursoSeleccionado);

            Dgv_Disponibilidad.DataSource = null;
            Dgv_Disponibilidad.DataSource = disponibilidad;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EntRecursoDisponibilidad disp = new EntRecursoDisponibilidad();

                disp.Recurso = recursoSeleccionado.Id;
                disp.Plan = long.Parse(Tbox_plan.Text);
                disp.Dia = dateTimePicker1.Value;

                TimeSpan horaInicio = new TimeSpan(dateTimePicker2.Value.Hour, 0, 0);
                disp.Hora = horaInicio;

                bool solapa = disponibilidad.Any(d =>
                    d.Recurso == disp.Recurso &&
                    d.Dia == disp.Dia.Date &&
                    d.Hora >= disp.Hora
                );

                if (solapa)
                {
                    throw new Exception("El horario solapa");
                }

                if (LogRecurso.Instancia.SepararRecurso(disp))
                {
                    MessageBox.Show("Se agrego la separacion");
                }
                else
                {
                    throw new Exception("No se pudo separar");
                }

                CargarHorario(recursoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(LogRecurso.Instancia.BorrarSeparacion(recursoSeleccionado.Id, recursDispSeleccionado.Dia, recursDispSeleccionado.Hora, long.Parse(Tbox_plan.Text)))
                {
                    CargarHorario(recursoSeleccionado);
                    button2.Enabled = true;
                    MessageBox.Show("Se borro correctamente");
                }
                else
                {
                    throw new Exception("No se pudo borrar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Dgv_Disponibilidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var item = Dgv_Disponibilidad.Rows[e.RowIndex].DataBoundItem as EntRecursoDisponibilidad;

                    if (item != null)
                    {
                        recursDispSeleccionado = item;
                        button2.Enabled = true;
                        dateTimePicker1.Value = item.Dia.Date;
                        var fecha = dateTimePicker2.Value.Date;
                        dateTimePicker2.Value = fecha.Add(item.Hora);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
