using HealthGym.CapaDatos.RecursosDeportivos;
using HealthGym.CapaEntidad.RecursosDeportivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaLogica
{
    internal class LogRecurso
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

        public bool BorrarSeparacion(int id, int dia, TimeSpan hora)
        {
            return DatRecurso.Instancia.BorrarSeparacion(id, dia, hora);
        }
    }
}
