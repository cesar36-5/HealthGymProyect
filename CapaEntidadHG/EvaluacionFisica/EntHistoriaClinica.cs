using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidadHG;


namespace CapaEntidadHG.EvaluacionFisica
{

    public class EntHistoriaClinica
    {
        public string DniMiembro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Responsable { get; set; }
        public string Observaciones { get; set; }

        public EntHistoriaClinica()
        {
            FechaRegistro = DateTime.Now;
        }
        public int IdHistoriaClinica { get; set; }
        public DateTime Fecha { get; set; }
        public string Antecedentes { get; set; }
        public string Diagnostico { get; set; }
        public string Indicaciones { get; set; }
    }
}

    
 
