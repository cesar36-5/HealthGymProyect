using System;
using System.Drawing.Text;
using Microsoft.Data.SqlClient;


public class Conexion
{
    private static readonly Conexion _instancia = new Conexion();
    public static Conexion Instancia
    {
        get { return Conexion._instancia; }
    }

    public SqlConnection Conectar()
    {
        SqlConnection cn = new SqlConnection(
            "Server=localhost;" +
            "Database=HealthGym;" +
            "user=sa;" +
            "Password=12345678;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;");
        return cn;
    }
    public static string Cadena =
            "Server=localhost;Database=HealthGymDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public SqlConnection GetConexion()
    {
        return new SqlConnection(Cadena);
    }
}
