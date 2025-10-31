using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaDatos
{
    public class DatTrabajador
    {
        #region Singleton

        private static readonly DatTrabajador _instancia = new DatTrabajador();

        public static DatTrabajador Instancia
        {
            get { return DatTrabajador._instancia; }
        }

        #endregion

        #region Metodos

        public List<EntTrabajador> ListarTrabajador()
        {
            List<EntTrabajador> lista = new List<EntTrabajador>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarTrabajador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        EntTrabajador tra = new EntTrabajador
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            DNI = dr["DNI"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Sexo = Convert.ToBoolean(dr["Sexo"]) ? 1 : 0,
                            Correo = dr["Correo"].ToString(),
                            Salario = Convert.ToDouble(dr["Salario"]),
                            Cargo = dr["Cargo"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Cargo"]),
                            Especialidad = dr["Especialidad"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Especialidad"])
                        };
                        lista.Add(tra);
                    }
                }
            }

            return lista;
        }

        public EntTrabajador BuscarTrabajador(string dni)
        {
            EntTrabajador tra = null;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spBuscarTrabajador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", dni);
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        tra = new EntTrabajador
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            DNI = dr["DNI"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Sexo = Convert.ToBoolean(dr["Sexo"]) ? 1 : 0,
                            Correo = dr["Correo"].ToString(),
                            Salario = Convert.ToDouble(dr["Salario"]),
                            Cargo = dr["Cargo"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Cargo"]),
                            Especialidad = dr["Especialidad"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Especialidad"])
                        };
                    }
                }
            }

            return tra;
        }

        public bool AgregarTrabajador(EntTrabajador tra)
        {
            bool inserta = false;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spAgregarTrabajador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombres", tra.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", tra.Apellidos);
                cmd.Parameters.AddWithValue("@DNI", tra.DNI);
                cmd.Parameters.AddWithValue("@Telefono", tra.Telefono);
                cmd.Parameters.AddWithValue("@Sexo", tra.Sexo == 1);
                cmd.Parameters.AddWithValue("@Correo", tra.Correo);
                cmd.Parameters.AddWithValue("@Cargo", tra.Cargo);
                cmd.Parameters.AddWithValue("@Salario", tra.Salario);
                cmd.Parameters.AddWithValue("@Especialidad", (object)tra.Especialidad ?? DBNull.Value);

                cn.Open();
                inserta = cmd.ExecuteNonQuery() > 0;
            }

            return inserta;
        }

        public bool EditarTrabajador(EntTrabajador tra)
        {
            bool edita = false;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarTrabajador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DNI", tra.DNI);
                cmd.Parameters.AddWithValue("@Nombres", tra.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", tra.Apellidos);
                cmd.Parameters.AddWithValue("@Sexo", tra.Sexo == 1);
                cmd.Parameters.AddWithValue("@Telefono", tra.Telefono);
                cmd.Parameters.AddWithValue("@Correo", tra.Correo);
                cmd.Parameters.AddWithValue("@Cargo", tra.Cargo);
                cmd.Parameters.AddWithValue("@Salario", tra.Salario);

                if (tra.Especialidad == 0)
                    cmd.Parameters.AddWithValue("@Especialidad", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Especialidad", tra.Especialidad);

                cn.Open();
                edita = cmd.ExecuteNonQuery() > 0;
            }

            return edita;
        }

        public bool EliminarTrabajador(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI no puede estar vacío.", nameof(dni));

            bool elimina = false;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEliminarTrabajador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", dni);

                cn.Open();
                elimina = cmd.ExecuteNonQuery() > 0;
            }

            return elimina;
        }

        #endregion
    }
}
