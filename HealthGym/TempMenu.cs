using HealthGym.Plan_de_entrenamiento;
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
    public partial class TempMenu : Form
    {
        public TempMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorMiembro m = new MantenedorMiembro();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorTrabajador m = new MantenedorTrabajador();
            m.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MantenedorEjercicios m = new MantenedorEjercicios();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Plan_de_entrenamiento.AsignacionRecursos m = new Plan_de_entrenamiento.AsignacionRecursos();
            m.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EvaluacionFisica.EvaluacionFisica_2 m = new EvaluacionFisica.EvaluacionFisica_2();
            m.Show();
        }
    }
}
