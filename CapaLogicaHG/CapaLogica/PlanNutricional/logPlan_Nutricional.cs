using CapaDatosHG.CapaDatoss.PlanNutricional;
using CapaEntidadHG.CapaEntidad.PlanNutricional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaHG.CapaLogica.PlanNutricional
{
    public class logPlan_Nutricional
    {
        #region singleton
        private static readonly logPlan_Nutricional _instancia = new logPlan_Nutricional();

        public static logPlan_Nutricional Instancia
        {
            get
            {
                return logPlan_Nutricional._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entPlan_Nutricional> ListarDatos(){
            return datPlan_Nutricional.Instancia.ListarDatos();
        }

        public bool InserPlan(entPlan_Nutricional evNutri)
        {
            return datPlan_Nutricional.Instancia.InserPlan(evNutri);
        }
        public bool EditPlan(entPlan_Nutricional evNutri)
        {
            return datPlan_Nutricional.Instancia.EditPlan(evNutri);
        }
        #endregion metodos
    }
}
