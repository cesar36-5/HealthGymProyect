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
            Cbox_Enfoque.SelectedIndex = 0;
            Btn_Editar.Enabled = false;
            CargarEjercicios();
        }

        private void MantenedorEjercicios_Load(object sender, EventArgs e)
        {

        }

        private void CargarEjercicios()
        {
            Btn_Editar.Enabled = false;

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

        private void Tbox_Id_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;

                    int id = int.Parse(Tbox_Id.Text);
                    CargarEjercicio(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Dgv_Ejercicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var fila = Dgv_Ejercicios.Rows[e.RowIndex];

            EntEjercicio ejercicioSeleccionado = fila.DataBoundItem as EntEjercicio;

            if (ejercicioSeleccionado != null)
            {
                Tbox_Id.Enabled = false;
                CargarEjercicio(ejercicioSeleccionado.Id);
            }
        }

        private void CargarEjercicio(int id)
        {
            try
            {
                EntEjercicio e = null;
                e = LogEjercicio.Instancia.BuscarEjercicio(id);

                if (e == null)
                {
                    throw new Exception("No se encontro un ejercicio con ese id");
                }

                Tbox_Id.Text = e.Id.ToString();

                Btn_Agregar.Enabled = false;
                Btn_Editar.Enabled = true;

                Tbox_Nombre.Text = e.Nombre;
                Tbox_Desc.Text = e.Descripcion;

                if (e.AtributoTecnico)
                {
                    Cbox_Enfoque.SelectedIndex = 1;
                }
                else if (!e.AtributoTecnico)
                {
                    Cbox_Enfoque.SelectedIndex = 0;
                }

                if (e.Dificultad == "1")
                {
                    Cbox_Enfoque.SelectedIndex = -1;
                }
                else if (e.Dificultad == "2")
                {
                    Cbox_Enfoque.SelectedIndex = 0;
                }
                else
                {
                    Cbox_Enfoque.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Btn_Agregar.Enabled = true;
            Btn_Editar.Enabled = false;
            LimpiarCuadros();
        }
        private void LimpiarCuadros()
        {
            Tbox_Nombre.Text = "";
            Tbox_Desc.Text = "";
            Cbox_Enfoque.SelectedItem = 0;
            Cbox_Enfoque.SelectedIndex = 0;
        }

        private void Cbox_Dificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Cbox_Dificultad.SelectedIndex.ToString());
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntEjercicio ej = new EntEjercicio();
                if (string.IsNullOrWhiteSpace(Tbox_Desc.Text) || string.IsNullOrWhiteSpace(Tbox_Nombre.Text))
                {
                    throw new Exception("Debe colocar un nombre y descripcion");
                }
                if (Tbox_Nombre.Text.Length > 512)
                {
                    throw new Exception("El nombre es demasiado largo");
                }
                if (Tbox_Desc.Text.Length > 1024)
                {
                    throw new Exception("La descripcion es demasiado larga");
                }

                ej.Nombre = Tbox_Nombre.Text;
                ej.Descripcion = Tbox_Desc.Text;
                ej.Dificultad = (Cbox_Dificultad.SelectedIndex + 1).ToString();
                if (Cbox_Enfoque.SelectedIndex == 0)
                {
                    ej.AtributoTecnico = false;
                }
                else
                {
                    ej.AtributoTecnico = true;
                }
                if (LogEjercicio.Instancia.AgregarEjercicio(ej))
                {
                    MessageBox.Show("El ejercicio se agrego");
                }
                else
                {
                    MessageBox.Show("El ejercicio no se pudo agregar");
                }
                CargarEjercicios();
                LimpiarCuadros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                EntEjercicio ej = new EntEjercicio();
                if (int.TryParse(Tbox_Id.Text, out int salida))
                {
                    ej.Id = int.Parse(Tbox_Id.Text);

                    if (string.IsNullOrWhiteSpace(Tbox_Desc.Text) || string.IsNullOrWhiteSpace(Tbox_Nombre.Text))
                    {
                        throw new Exception("Debe colocar un nombre y descripcion");
                    }
                    if (Tbox_Nombre.Text.Length > 512)
                    {
                        throw new Exception("El nombre es demasiado largo");
                    }
                    if (Tbox_Desc.Text.Length > 1024)
                    {
                        throw new Exception("La descripcion es demasiado larga");
                    }

                    ej.Nombre = Tbox_Nombre.Text;
                    ej.Descripcion = Tbox_Desc.Text;
                    ej.Dificultad = (Cbox_Dificultad.SelectedIndex + 1).ToString();
                    if (Cbox_Enfoque.SelectedIndex == 0)
                    {
                        ej.AtributoTecnico = false;
                    }
                    else
                    {
                        ej.AtributoTecnico = true;
                    }
                    if (LogEjercicio.Instancia.EditarEjercicio(ej))
                    {
                        MessageBox.Show("Se edito el ejercicio");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el ejercicio");
                    }
                    CargarEjercicios();
                    Btn_Agregar.Enabled = true;
                    Btn_Editar.Enabled = false;
                    LimpiarCuadros();
                }
                else
                {
                    throw new Exception("El id es invalido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!int.TryParse(Tbox_Id.Text, out int i))
                {
                    throw new Exception("El id no es valido");
                }
                int id = int.Parse(Tbox_Id.Text);

                if (LogEjercicio.Instancia.EliminarEjercicio(id))
                {
                    MessageBox.Show("Se elimino el ejercicio");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el ejercicio");
                }
                CargarEjercicios();
                Btn_Agregar.Enabled = true;
                Btn_Editar.Enabled = false;
                LimpiarCuadros();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
