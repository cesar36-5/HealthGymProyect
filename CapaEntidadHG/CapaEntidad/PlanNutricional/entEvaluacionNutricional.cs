using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadHG.CapaEntidad.PlanNutricional
{
    public class entEvaluacionNutricional
    {
        public long Id { get; set; }
        public bool Saludable { get; set; }
        [Required]
        public string Observacion { get; set; } = string.Empty;
        [Required]
        public string Evolucion { get; set; } = string.Empty;
        public int ReqEnergetico { get; set; }
        [Required]
        public string ObjetivoNutri1 { get; set; } = string.Empty;
        [Required]
        public string ObjetivoNutri2 { get; set; } = string.Empty;
        [Required]
        public string ObjetivoNutri3 { get; set; } = string.Empty;
    }
}