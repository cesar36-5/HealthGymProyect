using HealthGym.CapaEntidad;
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
    public partial class MantenedorEjercicios : Form
    {
        public MantenedorEjercicios()
        {
            InitializeComponent();
            Cbox_Dificultad.SelectedIndex = 0;
            Btn_Editar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            CargarEjercicios();
        }

        private void MantenedorEjercicios_Load(object sender, EventArgs e)
        {

        }

        private void CargarEjercicios()
        {
            Btn_Editar.Enabled = false;
            Btn_Eliminar.Enabled = false;

            List<EntEjercicio> ejercicios = LogEjercicio.Instancia.ListarEjercicios();

            Dgv_Ejercicios.DataSource = null;
            Dgv_Ejercicios.AutoGenerateColumns = false;
            Dgv_Ejercicios.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "Id";
            colId.DataPropertyName = "id";
            colId.Width = 50;
            Dgv_Ejercicios.Columns.Add(colId);

            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre";
            Dgv_Ejercicios.Columns.Add(colNombre);

            var colDificultad = new DataGridViewTextBoxColumn();
            colDificultad.HeaderText = "Dificultad";
            colDificultad.DataPropertyName = "Dificultad";
            Dgv_Ejercicios.Columns.Add(colDificultad);

            var colAtributo = new DataGridViewTextBoxColumn();
            colAtributo.HeaderText = "Enfoque";
            colAtributo.DataPropertyName = "AtributoTecnico";
            Dgv_Ejercicios.Columns.Add(colAtributo);

            var colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.DataPropertyName = "Descripcion";
            colDescripcion.Width = 400;
            Dgv_Ejercicios.Columns.Add(colDescripcion);

            Dgv_Ejercicios.DataSource = ejercicios;

            Dgv_Ejercicios.CellFormatting -= Dgv_Ejercicios_CellFormatting;
            Dgv_Ejercicios.CellFormatting += Dgv_Ejercicios_CellFormatting;
        }



        private void Dgv_Ejercicios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Dgv_Ejercicios.Columns[e.ColumnIndex].DataPropertyName == "Dificultad" && e.Value != null)
            {
                switch (e.Value.ToString())
                {
                    case "1": e.Value = "Fácil"; break;
                    case "2": e.Value = "Medio"; break;
                    case "3": e.Value = "Difícil"; break;
                }
                e.FormattingApplied = true;
            }

            if (Dgv_Ejercicios.Columns[e.ColumnIndex].DataPropertyName == "AtributoTecnico" && e.Value is bool b)
            {
                e.Value = b ? "Tren superior" : "Tren inferior";
                e.FormattingApplied = true;
            }
        }
    }
}
