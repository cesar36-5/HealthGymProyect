using HealthGym.CapaDatos;
using HealthGym.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaLogica
{
    public class LogEjercicio
    {
        #region Singleton
        public static readonly LogEjercicio _instancia = new LogEjercicio();

        public static LogEjercicio Instancia
        {
            get { return LogEjercicio._instancia; }
        }
        #endregion

        public List<EntEjercicio> ListarEjercicios()
        {
            return DatEjercicio.Instancia.ListarEjercicios();
        }

        public bool AgregarEjercicio(EntEjercicio e)
        {
            return DatEjercicio.Instancia.AgregarEjercicio(e);
        }

        public bool EditarEjercicio(EntEjercicio e)
        {
            return DatEjercicio.Instancia.EditarEjercicio(e);
        }

        public EntEjercicio BuscarEjercicio(int id)
        {
            return DatEjercicio.Instancia.BuscarEjercicios(id);
        }
    }
}
