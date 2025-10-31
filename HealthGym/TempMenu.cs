using HealthGym.EvaluacionFisica;
using HealthGym.Plan_de_entrenamiento;
using HealthGym.PlanNutricional;
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

        private void button5_Click(object sender, EventArgs e)
        {
            Plan_Nutricional m = new Plan_Nutricional();
            m.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MantenedorRecursosDeportivos m = new MantenedorRecursosDeportivos();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            HistoriaClinica m = new HistoriaClinica();
            m.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            EvaluacionNutricional m = new EvaluacionNutricional();
            m.Show();
        }
    }
}
