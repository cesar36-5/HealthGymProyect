using HealthGym.CapaEntidad;
using System;

public class LogMiembro
{
    #region Singleton

    public static readonly LogMiembro _instancia = new LogMiembro();

    public static LogMiembro Instancia
    {
        get { return LogMiembro._instancia; }
    }
    public List<EntMiembro> ListarMiembro()
    {
        return DatMiembro.Instancia.ListarMiembro();
    }


    public EntMiembro BuscarMiembro(string dni)
    {
        return DatMiembro.Instancia.BuscarMiembro(dni);
    }

    public bool AgregarMiembro(EntMiembro miembro)
    {
        return DatMiembro.Instancia.AgregarMiembro(miembro);
    }

    public bool EditarMiembro(EntMiembro miembro)
    {
        return DatMiembro.Instancia.EditarMiembro(miembro);
    }
    public bool EliminarMiembro(string dni)
    {
        try
        {
            return DatMiembro.Instancia.EliminarMiembro(dni);
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar miembro: " + ex.Message);
        }
    }
        #endregion
}
