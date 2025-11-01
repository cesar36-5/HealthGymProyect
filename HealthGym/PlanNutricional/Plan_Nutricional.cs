using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidadHG.CapaEntidad.PlanNutricional;
using CapaLogicaHG.CapaLogica.PlanNutricional;

namespace HealthGym.PlanNutricional
{
    public partial class Plan_Nutricional : Form
    {
        public Plan_Nutricional()
        {
            InitializeComponent();
            listarDatos();
            gbPlanNutri.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void Limpiar()
        {
            txtEvaluacionNutricional.Text = "";
            cboDia.Text = "";
            cboComida.Text = "";
            txtTipo.Text = "";
            txtAlimento.Text = "";
            txtValorNutricional.Text = "";
        }

        public void listarDatos()
        {
            dgvPlanNutri.DataSource = logPlan_Nutricional.Instancia.ListarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbPlanNutri.Enabled = true;
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlan_Nutricional n = new entPlan_Nutricional();
                n.EvaluacionNutricional = int.Parse(txtEvaluacionNutricional.Text.Trim());
                n.Comida = cboComida.Text.Trim();
                n.Dia = cboDia.Text.Trim();
                n.Tipo = txtTipo.Text.Trim();
                n.Alimento = txtAlimento.Text.Trim();
                n.ValorNutricional = txtValorNutricional.Text.Trim();

                bool resultado = logPlan_Nutricional.Instancia.InserPlan(n);

                if (resultado)
                {
                    MessageBox.Show("Plan nutricional registrado correctamente");

                    Limpiar();
                    gbPlanNutri.Enabled = false;
                    listarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el plan nutricional");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al agregar valores" + ex);
            }
            Limpiar();
            gbPlanNutri.Enabled = false;
            listarDatos();
        }

        private void dgvPlanNutri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPlanNutri.Rows[e.RowIndex];
            txtEvaluacionNutricional.Text = filaActual.Cells[1].Value.ToString();
            cboComida.Text = filaActual.Cells[2].Value.ToString();
            cboDia.Text = filaActual.Cells[3].Value.ToString();
            txtTipo.Text = filaActual.Cells[4].Value.ToString();
            txtAlimento.Text = filaActual.Cells[5].Value.ToString();
            txtValorNutricional.Text = filaActual.Cells[6].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbPlanNutri.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlan_Nutricional n = new entPlan_Nutricional();
                n.Id = Convert.ToInt64(dgvPlanNutri.CurrentRow.Cells["Id"].Value);
                n.EvaluacionNutricional = Convert.ToInt64(dgvPlanNutri.CurrentRow.Cells["EvaluacionNutricional"].Value);
                n.Comida = cboComida.Text.Trim();
                n.Dia = cboDia.Text.Trim();
                n.Tipo = txtTipo.Text.Trim();
                n.Alimento = txtAlimento.Text.Trim();
                n.ValorNutricional = txtValorNutricional.Text.Trim();

                bool resultado = logPlan_Nutricional.Instancia.EditPlan(n);

                if (resultado)
                {
                    MessageBox.Show("Plan nutricional editado correctamente");
                    listarDatos();
                    Limpiar();
                    gbPlanNutri.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo editar el plan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al agregar valores" + ex);
            }
        }

        private void btnDeshabilitarAlim_Click(object sender, EventArgs e)
        {
            if (dgvPlanNutri.CurrentRow != null)
            {
                DataGridViewRow fila = dgvPlanNutri.CurrentRow;
                // Cambiar color de fondo
                fila.Cells["Alimento"].Style.BackColor = Color.LightGray;
                fila.Cells["ValorNutricional"].Style.BackColor = Color.LightGray;
                // Cambiar color del texto
                fila.Cells["Alimento"].Style.ForeColor = Color.DarkGray;
                fila.Cells["ValorNutricional"].Style.ForeColor = Color.DarkGray;

                // No aceptar edición
                fila.Cells["Alimento"].ReadOnly = true;
                fila.Cells["ValorNutricional"].ReadOnly = true;

                MessageBox.Show("Alimentos deshabilitados");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila primero");
            }
        }
    }
}
