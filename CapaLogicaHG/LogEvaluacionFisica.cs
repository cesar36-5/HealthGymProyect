using CapaDatosHG.CapaDatoss;
using CapaEntidadHG.CapaEntidad;
using HealthGym.CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaHG
{
    public class LogEvaluacionFisica
    {
        #region Singleton
        public static readonly LogEvaluacionFisica _instancia = new LogEvaluacionFisica();

        public static LogEvaluacionFisica Instancia
        {
            get { return LogEvaluacionFisica._instancia; }
        }
        #endregion

        public long AgregarEvaluacionFisica(EntEvaluacionFisica e)
        {
            return DatEvaluacionFisica.Instancia.AgregarEvaluacionFisica(e);
        }
    }
}
