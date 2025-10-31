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
    public class datEvaluacionNutricional
    {
        #region singleton
        private static readonly datEvaluacionNutricional _instancia = new datEvaluacionNutricional();
        public static datEvaluacionNutricional Instancia{
            get {
                return datEvaluacionNutricional._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Cargar los datos
        public List<entEvaluacionNutricional> ListarDatos() {
            SqlCommand? cmd = null; //Puede ser nulo
            List<entEvaluacionNutricional> lista = new List<entEvaluacionNutricional>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEvaNutricional", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    entEvaluacionNutricional Nutri = new entEvaluacionNutricional();
                    Nutri.Id = Convert.ToInt64(dr["Id"]);
                    Nutri.Saludable = Convert.ToBoolean(dr["Saludable"]);
                    Nutri.Observacion = dr["Observacion"]?.ToString() ?? string.Empty;
                    Nutri.Evolucion = dr["Evolucion"]?.ToString() ?? string.Empty;
                    Nutri.ReqEnergetico = Convert.ToInt32(dr["ReqEnergetico"]);
                    Nutri.ObjetivoNutri1 = dr["ObjetivoNutri1"]?.ToString() ?? string.Empty;
                    Nutri.ObjetivoNutri2 = dr["ObjetivoNutri2"]?.ToString() ?? string.Empty;
                    Nutri.ObjetivoNutri3 = dr["ObjetivoNutri3"]?.ToString() ?? string.Empty;
                    lista.Add(Nutri);
                }
            } catch (Exception) {
                throw; //Stack traza el error original
            } finally {
                if (cmd != null)
                    cmd.Connection.Close();
            }
            return lista;
        }
        //Insertar Eva
        public Boolean InserEvaluacion(entEvaluacionNutricional evNutri)
        {
            Boolean inserta = false;
            try{
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("spInsertarEvaNutricional", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Saludable", evNutri.Saludable);
                    cmd.Parameters.AddWithValue("@Observacion", evNutri.Observacion);
                    cmd.Parameters.AddWithValue("@Evolucion", evNutri.Evolucion);
                    cmd.Parameters.AddWithValue("@ReqEnergetico", evNutri.ReqEnergetico);
                    cmd.Parameters.AddWithValue("@ObjetivoNutri1", evNutri.ObjetivoNutri1);
                    cmd.Parameters.AddWithValue("@ObjetivoNutri2", evNutri.ObjetivoNutri2);
                    cmd.Parameters.AddWithValue("@ObjetivoNutri3", evNutri.ObjetivoNutri3);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    inserta = true;
                }
            }catch (Exception ex){
                throw new Exception("Error al insertar Evaluación Nutricional" + ex.Message, ex);
            }
            return inserta;
        }
        //Editar Eva
        public Boolean EditEvaluacion(entEvaluacionNutricional evNutri) {
            Boolean edita = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("spEditarEvaNutricional", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", evNutri.Id);
                    cmd.Parameters.AddWithValue("@Saludable", evNutri.Saludable);
                    cmd.Parameters.AddWithValue("@Observacion", evNutri.Observacion);
                    cmd.Parameters.AddWithValue("@Evolucion", evNutri.Evolucion);
                    cmd.Parameters.AddWithValue("@ReqEnergetico", evNutri.ReqEnergetico);
                    cmd.Parameters.AddWithValue("@ObjetivoNutri1", evNutri.ObjetivoNutri1);
                    cmd.Parameters.AddWithValue("@ObjetivoNutri2", evNutri.ObjetivoNutri2);
                    cmd.Parameters.AddWithValue("@ObjetivoNutri3", evNutri.ObjetivoNutri3);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    edita = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar Evaluación Nutricional" + ex.Message, ex);
            }
            return edita;
        }
        #endregion metodos
    }
}
