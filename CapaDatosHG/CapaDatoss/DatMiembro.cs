using HealthGym.CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

public class DatMiembro
{
    #region Singleton

    private static readonly DatMiembro _instancia = new DatMiembro();

    public static DatMiembro Instancia
    {
        get { return DatMiembro._instancia; }
    }
    //ACTUALIZAR
    #endregion

    #region Metodos
    public List<EntMiembro> ListarMiembro()
    {
        List<EntMiembro> lista = new List<EntMiembro>();

        using (SqlConnection cn = Conexion.Instancia.Conectar())
        using (SqlCommand cmd = new SqlCommand("spListarMiembro", cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntMiembro m = new EntMiembro
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    DNI = dr["DNI"].ToString(),
                    Nombres = dr["Nombres"].ToString(),
                    Apellidos = dr["Apellidos"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Sexo = Convert.ToInt32(dr["Sexo"]),    // ✅ int
                    Correo = dr["Correo"].ToString(),
                    InicioMembresia = Convert.ToDateTime(dr["MembresiaInicio"]),
                    FinalMembresia = Convert.ToDateTime(dr["MembresiaFin"]),
                    GrupoSanguineo = dr["GrupoSanguineo"].ToString(),
                    Seguro = dr["Seguro"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"])
                };
                lista.Add(m);
            }
            dr.Close();
        }

        return lista;
    }

    public EntMiembro BuscarMiembro(string dni)
    {
        using (SqlConnection cn = Conexion.Instancia.Conectar())
        using (SqlCommand cmd = new SqlCommand("spBuscarMiembro", cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DNI", dni);
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return new EntMiembro
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nombres = dr["Nombres"].ToString(),
                    Apellidos = dr["Apellidos"].ToString(),
                    DNI = dr["DNI"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Sexo = Convert.ToInt32(dr["Sexo"]),
                    Correo = dr["Correo"].ToString(),
                    InicioMembresia = Convert.ToDateTime(dr["MembresiaInicio"]),
                    FinalMembresia = Convert.ToDateTime(dr["MembresiaFin"]),
                    GrupoSanguineo = dr["GrupoSanguineo"].ToString(),
                    Seguro = dr["Seguro"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"])
                };
            }
        }

        return null;
    }

    public bool AgregarMiembro(EntMiembro miembro)
    {
        using (SqlConnection cn = Conexion.Instancia.Conectar())
        using (SqlCommand cmd = new SqlCommand("spAgregarMiembro", cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombres", miembro.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", miembro.Apellidos);
            cmd.Parameters.AddWithValue("@DNI", miembro.DNI);
            cmd.Parameters.AddWithValue("@Telefono", miembro.Telefono);
            cmd.Parameters.AddWithValue("@Sexo", miembro.Sexo);
            cmd.Parameters.AddWithValue("@Correo", miembro.Correo);
            cmd.Parameters.AddWithValue("@MembresiaInicio", miembro.InicioMembresia);
            cmd.Parameters.AddWithValue("@MembresiaFin", miembro.FinalMembresia);
            cmd.Parameters.AddWithValue("@GrupoSanguineo", miembro.GrupoSanguineo);
            cmd.Parameters.AddWithValue("@Seguro", miembro.Seguro);
            cmd.Parameters.AddWithValue("@FechaNacimiento", miembro.FechaNacimiento);

            try
            {
                cn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general: " + ex.Message);
            }
        }
    }

    public bool EditarMiembro(EntMiembro m)
    {
        using (SqlConnection cn = Conexion.Instancia.Conectar())
        using (SqlCommand cmd = new SqlCommand("spEditarMiembro", cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombres", m.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", m.Apellidos);
            cmd.Parameters.AddWithValue("@DNI", m.DNI);
            cmd.Parameters.AddWithValue("@Telefono", m.Telefono);
            cmd.Parameters.AddWithValue("@Sexo", m.Sexo);
            cmd.Parameters.AddWithValue("@Correo", m.Correo);
            cmd.Parameters.AddWithValue("@MembresiaInicio", m.InicioMembresia);
            cmd.Parameters.AddWithValue("@MembresiaFin", m.FinalMembresia);
            cmd.Parameters.AddWithValue("@GrupoSanguineo", m.GrupoSanguineo);
            cmd.Parameters.AddWithValue("@Seguro", m.Seguro);
            cmd.Parameters.AddWithValue("@FechaNacimiento", m.FechaNacimiento);

            try
            {
                cn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general: " + ex.Message);
            }
        }

    }
    public bool EliminarMiembro(string dni)
    {
        SqlCommand cmd = null;
        bool eliminado = false;

        try
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cmd = new SqlCommand("spEliminarMiembro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", dni);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                eliminado = filasAfectadas > 0;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar miembro: " + ex.Message);
        }
        finally
        {
            if (cmd != null) cmd.Dispose();
        }

        return eliminado;
    }


    #endregion
}
