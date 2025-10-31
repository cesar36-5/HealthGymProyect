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
    public partial class MantenedorRecursosDeportivos : Form
    {
        List<EntRecurso> recursos = new List<EntRecurso>();
        EntRecurso rSeleccionado = null;
        public MantenedorRecursosDeportivos()
        {
            InitializeComponent();
            CargarRecursos();
            Btn_Editar.Enabled = false;
        }

        public void CargarRecursos()
        {
            Dgv_Recursos.DataSource = null;
            recursos = LogRecurso.Instancia.ListarRecursos();
            Dgv_Recursos.DataSource = recursos;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Tbox_Nombre.Text;

                EntRecurso r = new EntRecurso();
                r.Nombre = nombre;

                if (LogRecurso.Instancia.AgregarRecursoDeportivo(r))
                {
                    CargarRecursos();
                    MessageBox.Show("Se agrego el recurso");
                    Tbox_Nombre.Text = "";
                }
                else
                {
                    throw new Exception("No se pudo agregar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_Recursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var item = Dgv_Recursos.Rows[e.RowIndex].DataBoundItem as EntRecurso;

                    if (item != null)
                    {
                        rSeleccionado = item;
                        Btn_Agregar.Enabled = false;
                        Btn_Editar.Enabled = true;
                        Tbox_Nombre.Text = rSeleccionado.Nombre;
                    }
                }
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
                rSeleccionado.Nombre = Tbox_Nombre.Text;
                if (LogRecurso.Instancia.EditarRecursoDeportivo(rSeleccionado))
                {
                    CargarRecursos();
                    MessageBox.Show("Se edito el recurso");
                    Tbox_Nombre.Text = "";
                    Btn_Editar.Enabled = false;
                    Btn_Agregar.Enabled = true;
                }
                else
                {
                    throw new Exception("No se pudo editar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            rSeleccionado = null;
            Btn_Agregar.Enabled = true;
            Btn_Editar.Enabled = false;
        }
    }
}
