using CapaDatosHG.CapaDatoss.PlanNutricional;
using CapaEntidadHG.CapaEntidad.PlanNutricional;
using HealthGym.CapaDatos;
using HealthGym.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaHG.CapaLogica.PlanNutricional
{
    public class logEvaluacionNutricional
    {
        #region singleton
        private static readonly logEvaluacionNutricional _instancia = new logEvaluacionNutricional();
        
        public static logEvaluacionNutricional Instancia {
            get {
                return logEvaluacionNutricional._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entEvaluacionNutricional> ListarDatos() {
            return datEvaluacionNutricional.Instancia.ListarDatos();
        }

        public bool InsertarEvaluacion(entEvaluacionNutricional evNutri) {
            return datEvaluacionNutricional.Instancia.InserEvaluacion(evNutri);
        }
        public bool EditarEvaluacion(entEvaluacionNutricional evNutri) {
            return datEvaluacionNutricional.Instancia.EditEvaluacion(evNutri);
        }
        #endregion metodos
    }
}
