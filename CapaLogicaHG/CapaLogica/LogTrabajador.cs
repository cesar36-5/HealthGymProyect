using HealthGym.CapaEntidad;
using HealthGym.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaLogica
{
    public class LogTrabajador
    {
        #region Singleton

        public static readonly LogTrabajador _instancia = new LogTrabajador();

        public static LogTrabajador Instancia
        {
            get { return LogTrabajador._instancia; }
        }
        public List<EntTrabajador> ListarTrabajador()
        {
            try
            {
                return DatTrabajador.Instancia.ListarTrabajador();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar trabajadores: " + ex.Message);
            }
        }
        public EntTrabajador BuscarTrabajador(string dni)
        {
            try
            {
                return DatTrabajador.Instancia.BuscarTrabajador(dni);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar trabajador: " + ex.Message);
            }
        }

        public bool AgregarTrabajador(EntTrabajador t)
        {
            try
            {
                return DatTrabajador.Instancia.AgregarTrabajador(t);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar trabajador: " + ex.Message);
            }
        }

        public bool EditarTrabajador(EntTrabajador t)
        {
            try
            {
                return DatTrabajador.Instancia.EditarTrabajador(t);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar trabajador: " + ex.Message);
            }
        }

        public bool EliminarTrabajador(string dni)
        {
            return DatTrabajador.Instancia.EliminarTrabajador(dni);
        }

        public List<EntMiembro> ListarMiembro()
        {
            try
            {
                return DatMiembro.Instancia.ListarMiembro();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar miembros: " + ex.Message);
            }
        }

        public EntMiembro BuscarMiembro(string dni)
        {
            try
            {
                return DatMiembro.Instancia.BuscarMiembro(dni);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar miembro: " + ex.Message);
            }
        }

        public bool AgregarMiembro(EntMiembro m)
        {
            try
            {
                return DatMiembro.Instancia.AgregarMiembro(m);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar miembro: " + ex.Message);
            }
        }

        public bool EditarMiembro(EntMiembro m)
        {
            try
            {
                return DatMiembro.Instancia.EditarMiembro(m);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar miembro: " + ex.Message);
            }
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
}
