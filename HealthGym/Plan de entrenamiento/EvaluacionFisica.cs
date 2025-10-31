using CapaEntidadHG.CapaEntidad;
using CapaLogicaHG;
using HealthGym.EvaluacionFisica;
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
    public partial class EvaluacionFisica : Form
    {
        private Utilidades.Utilidades u = new Utilidades.Utilidades();
        public EvaluacionFisica()
        {
            InitializeComponent();
        }

        private void EvaluacionFisica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    !(double.TryParse(Tbox_Peso.Text, out double AAA)) ||
                    !(double.TryParse(Tbox_Estatura.Text, out double AAB)) ||
                    !(double.TryParse(Tbox_PGrasa.Text, out double AAC)) ||
                    !(double.TryParse(Tbox_Equlibrio.Text, out double AAD)) ||
                    !(double.TryParse(Tbox_Fuerza.Text, out double AAE)) ||
                    !(double.TryParse(Tbox_Flexibilidad.Text, out double AAF))
                    )
                {
                    throw new Exception("Hay al menos un campo de numero invalido");
                }

                if (Tbox_Objetivo.Text.Length > 128)
                {
                    throw new Exception("El objetivo tiene muchos caracteres (MAX:128)");
                }

                if (Tbox_Observacion.Text.Length > 512)
                {
                    throw new Exception("La observacion tiene muchos caracteres (MAX:512");
                }

                if (
                    !Utilidades.Utilidades.Instancia.ValidarPorcentaje(double.Parse(Tbox_PGrasa.Text)) ||
                    !Utilidades.Utilidades.Instancia.ValidarPorcentaje(double.Parse(Tbox_Equlibrio.Text)) ||
                    !Utilidades.Utilidades.Instancia.ValidarPorcentaje(double.Parse(Tbox_Fuerza.Text)) ||
                    !Utilidades.Utilidades.Instancia.ValidarPorcentaje(double.Parse(Tbox_Flexibilidad.Text))
                    )
                {
                    throw new Exception("Los porcentajes deben ser mayores a 0 y como maximo 100");
                }

                EntEvaluacionFisica ev = new EntEvaluacionFisica();

                ev.Estatura = double.Parse(Tbox_Estatura.Text);
                ev.Peso = double.Parse(Tbox_Peso.Text);
                ev.PorcentajeGrasa = double.Parse(Tbox_PGrasa.Text);
                ev.Fuerza = double.Parse(Tbox_Fuerza.Text);
                ev.Flexibilidad = double.Parse(Tbox_Flexibilidad.Text);
                ev.Equilibrio = double.Parse(Tbox_Equlibrio.Text);
                ev.Observacion = Tbox_Observacion.Text;
                ev.Objetivo = Tbox_Objetivo.Text;

                long id = LogEvaluacionFisica.Instancia.AgregarEvaluacionFisica(ev);

                if (id == -1)
                {
                    throw new Exception("No se pudo agregar la evaluacion fisica");
                }
                else
                {
                    Btn_CopiarId.Text = id.ToString();
                    MessageBox.Show("Se agrego la evaluacion fisica");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_CopiarId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Btn_CopiarId.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HistoriaClinica formulario = new HistoriaClinica();

            formulario.Show();

            this.Hide();
        }
    }
    
}
