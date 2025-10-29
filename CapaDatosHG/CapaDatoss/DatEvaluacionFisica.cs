using CapaEntidadHG.CapaEntidad;
using HealthGym.CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosHG.CapaDatoss
{
    public class DatEvaluacionFisica
    {
        #region Singleton
        public static readonly DatEvaluacionFisica _instancia = new DatEvaluacionFisica();

        public static DatEvaluacionFisica Instancia
        {
            get { return DatEvaluacionFisica._instancia; }
        }
        #endregion

        public long AgregarEvaluacionFisica(EntEvaluacionFisica ev)
        {
            long id = -1;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("AgregarEvaluacionFisica", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Peso", ev.Peso);
                cmd.Parameters.AddWithValue("@Estatura", ev.Estatura);
                cmd.Parameters.AddWithValue("@PorcentajeGrasa", ev.PorcentajeGrasa);
                cmd.Parameters.AddWithValue("@Flexibilidad", ev.Flexibilidad);
                cmd.Parameters.AddWithValue("@Fuerza", ev.Fuerza);
                cmd.Parameters.AddWithValue("@Equilibrio", ev.Equilibrio);
                cmd.Parameters.AddWithValue("@Observacion", ev.Observacion);
                cmd.Parameters.AddWithValue("@Objetivo", ev.Objetivo);

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        id = Convert.ToInt64(dr["NuevoId"]);
                }
            }

            return id;
        }

    }
}
