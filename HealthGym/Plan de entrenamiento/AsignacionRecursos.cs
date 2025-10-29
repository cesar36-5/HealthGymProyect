using HealthGym.CapaEntidad.RecursosDeportivos;
using HealthGym.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthGym.Plan_de_entrenamiento
{
    public partial class AsignacionRecursos : Form
    {
        bool puedeBorrar = false;
        int diaRecurso = 0; TimeSpan ora; string estado = "";

        public EntRecurso recursoSeleccionado = null;
        public List<EntRecursoDisponibilidad> disponibilidad = new List<EntRecursoDisponibilidad>();
        public AsignacionRecursos()
        {
            InitializeComponent();
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
            DateTime lunes = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);

            var dias = Enumerable.Range(0, 7).Select(i => lunes.AddDays(i)).ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Hora", "Hora");

            foreach (var dia in dias)
                dataGridView1.Columns.Add(dia.ToString("ddd"), dia.ToString("ddd"));

            disponibilidad = LogRecurso.Instancia.ListarDisponibilidad(recurso);

            for (int hora = 8; hora <= 22; hora++)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = $"{hora:00}:00";

                foreach (var dia in dias)
                {
                    var celda = dataGridView1.Rows[rowIndex].Cells[dias.IndexOf(dia) + 1];

                    int diaSemana = (int)dia.DayOfWeek;

                    bool ocupado = false;

                    if (disponibilidad.Any(d =>
                        (d.Dia == diaSemana) &&
                        (d.Hora == TimeSpan.FromHours(hora))
                    ))
                    {
                        ocupado = true;
                    }

                    if (ocupado)
                    {
                        celda.Style.BackColor = Color.LightCoral;
                        celda.Value = "Ocupado";
                    }
                    else
                    {
                        celda.Style.BackColor = Color.LightGreen;
                        celda.Value = "Libre";
                    }
                }
            }
            puedeBorrar = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EntRecursoDisponibilidad disp = new EntRecursoDisponibilidad();

                disp.Recurso = recursoSeleccionado.Id;

                int dia = ((int)dateTimePicker1.Value.DayOfWeek + 6) % 7;
                disp.Dia = dia + 1;

                TimeSpan horaInicio = new TimeSpan(dateTimePicker2.Value.Hour, 0, 0);
                TimeSpan horaFin = new TimeSpan(dateTimePicker3.Value.Hour, 0, 0);

                bool solapa = disponibilidad.Any(d =>
                    d.Recurso == disp.Recurso &&
                    d.Dia == disp.Dia &&
                    d.Hora <= horaFin &&
                    d.Hora >= horaInicio
                );

                if (solapa)
                {
                    throw new Exception("El horario solapa");
                }

                int horas = (int)(horaFin - horaInicio).TotalHours;

                for (int i = 0; i <= horas; i++)
                {
                    disp.Hora = horaInicio;
                    if (LogRecurso.Instancia.SepararRecurso(disp))
                    {
                        horaInicio = horaInicio.Add(TimeSpan.FromHours(1));
                    }
                    else
                    {
                        throw new Exception("No se pudo separar");
                    }
                }

                CargarHorario(recursoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 1 || e.ColumnIndex < 1)
            {
                puedeBorrar = false;
                return;
            }

            puedeBorrar = true;


            string horaTexto = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (!TimeSpan.TryParse(horaTexto.Replace(":00", "") + ":00", out TimeSpan hora))
            {
                MessageBox.Show("No se pudo leer la hora.");
                return;
            }

            string diaTexto = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            string diaAbrev = diaTexto.Split(' ')[0].ToLower();

            diaRecurso = diaAbrev switch
            {
                "lun" => 1,
                "mar" => 2,
                "mié" or "mie" => 3,
                "jue" => 4,
                "vie" => 5,
                "sáb" or "sab" => 6,
                "dom" => 0,
                _ => -1
            };

            if (diaRecurso == -1)
            {
                MessageBox.Show("No se pudo determinar el día.");
                return;
            }

            var celda = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            estado = celda.Value?.ToString() ?? "Desconocido";

            ora = hora;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!puedeBorrar)
                {
                    throw new Exception("No se puede borrar");
                }

                if(estado == "Libre")
                {
                    throw new Exception("La hora ya esta libre");
                }

                if(estado == "Ocupado")
                {
                    LogRecurso.Instancia.BorrarSeparacion(recursoSeleccionado.Id, diaRecurso, ora);
                    CargarHorario(recursoSeleccionado);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
