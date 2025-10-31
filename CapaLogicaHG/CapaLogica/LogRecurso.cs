using HealthGym.CapaDatos.RecursosDeportivos;
using HealthGym.CapaEntidad;
using HealthGym.CapaEntidad.RecursosDeportivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaLogica
{
    public class LogRecurso
    {
        #region Singleton
        public static readonly LogRecurso _instancia = new LogRecurso();

        public static LogRecurso Instancia
        {
            get { return LogRecurso._instancia; }
        }
        #endregion

        public List<EntRecurso> ListarRecursos()
        {
            return DatRecurso.Instancia.ListarRecursos();
        }

        public List<EntRecursoDisponibilidad> ListarDisponibilidad(EntRecurso r)
        {
            return DatRecurso.Instancia.ListarDisponibilidad(r);
        }

        public bool SepararRecurso(EntRecursoDisponibilidad r)
        {
            return DatRecurso.Instancia.SepararRecurso(r);
        }

        public bool BorrarSeparacion(int id, DateTime dia, TimeSpan hora, long plan)
        {
            return DatRecurso.Instancia.BorrarSeparacion(id, dia, hora, plan);
        }

        public bool AgregarRecursoDeportivo(EntRecurso e)
        {
            return DatRecurso.Instancia.AgregarRecursoDeportivo(e);
        }

        public bool EditarRecursoDeportivo(EntRecurso e)
        {
            return DatRecurso.Instancia.EditarRecursoDeportivo(e);
        }
    }
}
