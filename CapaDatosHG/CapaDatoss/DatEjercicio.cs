using HealthGym.CapaDatos.RecursosDeportivos;
using HealthGym.CapaEntidad;
using HealthGym.CapaEntidad.RecursosDeportivos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaDatos
{
    public class DatEjercicio
    {
        #region Singleton
        public static readonly DatEjercicio _instancia = new DatEjercicio();

        public static DatEjercicio Instancia
        {
            get { return DatEjercicio._instancia; }
        }
        #endregion

        public List<EntEjercicio> ListarEjercicios()
        {
            SqlCommand cmd = null;
            List<EntEjercicio> ejercicios = new List<EntEjercicio>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarEjercicios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntEjercicio ej = new EntEjercicio();
                    ej.Id = Convert.ToInt32(dr["ID"]);
                    ej.Nombre = dr["Nombre"].ToString();
                    ej.Dificultad = dr["Dificultad"].ToString();
                    ej.AtributoTecnico = Convert.ToBoolean(dr["AtributoTecnico"]);
                    ej.Descripcion = dr["DescripcionTecnica"].ToString();
                    ejercicios.Add(ej);
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
            return ejercicios;
        }

        public bool AgregarEjercicio(EntEjercicio ejercicio)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("AgregarEjercicio", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dif", ejercicio.Dificultad);
                    cmd.Parameters.AddWithValue("@att", ejercicio.AtributoTecnico);
                    cmd.Parameters.AddWithValue("@desc", ejercicio.Descripcion);
                    cmd.Parameters.AddWithValue("@Nombre", ejercicio.Nombre);

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

        public bool EditarEjercicio(EntEjercicio ejercicio)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("AgregarEjercicio", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", ejercicio.Id);
                    cmd.Parameters.AddWithValue("@dif", ejercicio.Dificultad);
                    cmd.Parameters.AddWithValue("@att", ejercicio.AtributoTecnico);
                    cmd.Parameters.AddWithValue("@desc", ejercicio.Descripcion);
                    cmd.Parameters.AddWithValue("@Nombre", ejercicio.Nombre);

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
