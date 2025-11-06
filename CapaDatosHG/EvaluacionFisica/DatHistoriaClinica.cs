using System.Data;
using Microsoft.Data.SqlClient;
using CapaEntidadHG;
using CapaEntidadHG.EvaluacionFisica;

namespace CapaDatoss
{
    public class DatHistoriaClinica
    {
        // NO DEBES instanciar la conexión aquí.
        // La línea "Conexion cn = new Conexion();" es un error porque
        // tu clase 'Conexion' es un Singleton y tiene un constructor privado.
        // BÓRRALA.

        public bool InsertarHistoria(EntHistoriaClinica h)
        {
            // Esta es la forma CORRECTA de llamar a tu conexión Singleton
            using (SqlConnection sqlCn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarHistoriaClinica", sqlCn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DniMiembro", h.DniMiembro);
                cmd.Parameters.AddWithValue("@Fecha", h.Fecha);
                cmd.Parameters.AddWithValue("@Responsable", h.Responsable);
                cmd.Parameters.AddWithValue("@Observaciones", h.Observaciones);
                cmd.Parameters.AddWithValue("@Antecedentes", h.Antecedentes);
                cmd.Parameters.AddWithValue("@Diagnostico", h.Diagnostico);
                cmd.Parameters.AddWithValue("@Indicaciones", h.Indicaciones);

                sqlCn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public List<EntHistoriaClinica> Consultar(string dni, DateTime desde, DateTime hasta)
        {
            var lista = new List<EntHistoriaClinica>();

            // Esta también es la forma CORRECTA
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ConsultarHistoriaClinica", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EntHistoriaClinica
                    {
                        IdHistoriaClinica = Convert.ToInt32(dr["IdHistoriaClinica"]),
                        DniMiembro = dr["DniMiembro"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Responsable = dr["Responsable"].ToString(),
                        Observaciones = dr["Observaciones"].ToString(),
                        Diagnostico = dr["Diagnostico"].ToString(),
                        Indicaciones = dr["Indicaciones"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}

