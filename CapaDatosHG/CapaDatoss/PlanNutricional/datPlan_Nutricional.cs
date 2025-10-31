using CapaEntidadHG.CapaEntidad.PlanNutricional;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosHG.CapaDatoss.PlanNutricional
{
    public class datPlan_Nutricional
    {
        #region singleton
        private static readonly datPlan_Nutricional _instancia = new datPlan_Nutricional();
        public static datPlan_Nutricional Instancia
        {
            get
            {
                return datPlan_Nutricional._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Cargar Datos
        public List<entPlan_Nutricional> ListarDatos() {
            SqlCommand? cmd = null; //Puede ser nulo
            List<entPlan_Nutricional> lista = new List<entPlan_Nutricional>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPlanNutricional", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlan_Nutricional Nutri = new entPlan_Nutricional();
                    Nutri.Id = Convert.ToInt64(dr["Id"]);
                    Nutri.EvaluacionNutricional = Convert.ToInt64(dr["EvaluacionNutricional"]);
                    Nutri.Comida = dr["Comida"]?.ToString() ?? string.Empty;
                    Nutri.Dia = dr["Dia"]?.ToString() ?? string.Empty;
                    Nutri.Tipo = dr["Tipo"]?.ToString() ?? string.Empty;
                    Nutri.Alimento = dr["Alimento"]?.ToString() ?? string.Empty;
                    Nutri.ValorNutricional = dr["ValorNutricional"]?.ToString() ?? string.Empty;
                    lista.Add(Nutri);
                }
            }
            catch (Exception)
            {
                throw; //Stack traza el error original
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }
            return lista;
        }
        //Insertar Plan
        public Boolean InserPlan(entPlan_Nutricional evNutri)
        {
            Boolean inserta = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("spInsertarPlanNutricional", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EvaluacionNutricional", evNutri.EvaluacionNutricional);
                    cmd.Parameters.AddWithValue("@Comida", evNutri.Comida);
                    cmd.Parameters.AddWithValue("@Dia", evNutri.Dia);
                    cmd.Parameters.AddWithValue("@Tipo", evNutri.Tipo);
                    cmd.Parameters.AddWithValue("@Alimento", evNutri.Alimento);
                    cmd.Parameters.AddWithValue("@ValorNutricional", evNutri.ValorNutricional);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Plan Nutricional" + ex.Message, ex);
            }
            return inserta;
        }
        //Editar Plan
        public Boolean EditPlan(entPlan_Nutricional evNutri)
        {
            Boolean edita = false;
            try{
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("spEditarPlanNutricional", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", evNutri.Id);
                    cmd.Parameters.AddWithValue("@EvaluacionNutricional", evNutri.EvaluacionNutricional);
                    cmd.Parameters.AddWithValue("@Comida", evNutri.Comida);
                    cmd.Parameters.AddWithValue("@Dia", evNutri.Dia);
                    cmd.Parameters.AddWithValue("@Tipo", evNutri.Tipo);
                    cmd.Parameters.AddWithValue("@Alimento", evNutri.Alimento);
                    cmd.Parameters.AddWithValue("@ValorNutricional", evNutri.ValorNutricional);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    edita = true;
                }
            }catch (Exception ex)
            {throw new Exception("Error al editar Evaluación Nutricional" + ex.Message, ex);
            }
            return edita;
        }
        #endregion metodos
    }
}
