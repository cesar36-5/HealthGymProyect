using HealthGym.CapaEntidad.RecursosDeportivos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaDatos.RecursosDeportivos
{
    public class DatRecurso
    {
        #region Singleton
        public static readonly DatRecurso _instancia = new DatRecurso();

        public static DatRecurso Instancia
        {
            get { return DatRecurso._instancia; }
        }
        #endregion

        public List<EntRecurso> ListarRecursos()
        {
            SqlCommand cmd = null;
            List<EntRecurso> recursos = new List<EntRecurso>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarRecursosDeportivos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntRecurso rec = new EntRecurso();
                    rec.Id = Convert.ToInt32(dr["ID"]);
                    rec.Nombre = dr["Nombre"].ToString();
                    recursos.Add(rec);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return recursos;
        }

        public List<EntRecursoDisponibilidad> ListarDisponibilidad(EntRecurso recurso)
        {
            List<EntRecursoDisponibilidad> disponibilidad = new List<EntRecursoDisponibilidad>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("ListarDisponibilidadRecurso", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", recurso.Id);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        EntRecursoDisponibilidad disp = new EntRecursoDisponibilidad();
                        disp.Recurso = recurso.Id;

                        DateTime diaSemana = (DateTime)(dr["Fecha"]);
                        TimeSpan horaInicio = (TimeSpan)dr["Hora"];

                        disp.Dia = diaSemana.Date;
                        disp.Hora = horaInicio;

                        disponibilidad.Add(disp);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return disponibilidad;
        }

        public bool SepararRecurso(EntRecursoDisponibilidad disp)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("SepararRecurso", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", disp.Recurso);
                    cmd.Parameters.AddWithValue("@Fecha", disp.Dia);
                    cmd.Parameters.AddWithValue("@HoraInicio", disp.Hora);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    inserta = i > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return inserta;
        }

        public bool BorrarSeparacion(int id, DateTime dia, TimeSpan hora)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("BorrarSeparacion", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Fecha", dia);
                    cmd.Parameters.AddWithValue("@Hora", hora);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    inserta = i > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return inserta;
        }
    }
}
