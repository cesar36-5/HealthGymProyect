using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidadHG.EvaluacionFisica;

namespace CapaDatosHG.EvaluacionFisica
{
    public class DatEvaluacionFisica
    {
        private readonly string connectionString = "Data Source=(localdb)\\Nicolas;Initial Catalog=MOANSO;Integrated Security=True;";

        public bool ValidarCita(string dni)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Citas WHERE DNI = @DNI AND Estado = 'Activa'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DNI", dni);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool InsertarEvaluacion(EntEvaluacionFisica evaluacion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO EvaluacionFisica 
                                (DniMiembro, FechaEvaluacion, Peso, Altura, FrecuenciaCardiaca, PresionSistolica, 
                                 PresionDiastolica, IMC, Postura, ValoracionFuncional, Diagnostico, Indicaciones, MedicoResponsable, Activo)
                                 VALUES (@DniMiembro, @FechaEvaluacion, @Peso, @Altura, @FrecuenciaCardiaca, @PresionSistolica, 
                                 @PresionDiastolica, @IMC, @Postura, @ValoracionFuncional, @Diagnostico, @Indicaciones, @MedicoResponsable, @Activo)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@DniMiembro", evaluacion.DniMiembro);
                cmd.Parameters.AddWithValue("@FechaEvaluacion", evaluacion.FechaEvaluacion);
                cmd.Parameters.AddWithValue("@Peso", evaluacion.Peso);
                cmd.Parameters.AddWithValue("@Altura", evaluacion.Altura);
                cmd.Parameters.AddWithValue("@FrecuenciaCardiaca", evaluacion.FrecuenciaCardiaca);
                cmd.Parameters.AddWithValue("@PresionSistolica", evaluacion.PresionSistolica);
                cmd.Parameters.AddWithValue("@PresionDiastolica", evaluacion.PresionDiastolica);
                cmd.Parameters.AddWithValue("@IMC", evaluacion.IMC);
                cmd.Parameters.AddWithValue("@Postura", evaluacion.Postura);
                cmd.Parameters.AddWithValue("@ValoracionFuncional", evaluacion.ValoracionFuncional);
                cmd.Parameters.AddWithValue("@Diagnostico", evaluacion.Diagnostico);
                cmd.Parameters.AddWithValue("@Indicaciones", evaluacion.Indicaciones);
                cmd.Parameters.AddWithValue("@MedicoResponsable", evaluacion.MedicoResponsable);
                cmd.Parameters.AddWithValue("@Activo", evaluacion.Activo);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public DataTable ListarEvaluacionesPorDni(string dni)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM EvaluacionFisica WHERE DniMiembro = @DNI";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DNI", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarEvaluaciones()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM EvaluacionFisica", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataRow ObtenerDatosMiembroPorDni(string dni)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT TOP 1 Nombre, Apellido, DNI 
                         FROM Miembros
                         WHERE DNI = @DNI";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DNI", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
                else
                    return null;
            }
        }
    }
}
