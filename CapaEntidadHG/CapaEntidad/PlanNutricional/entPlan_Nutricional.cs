using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadHG.CapaEntidad.PlanNutricional
{
    public class entPlan_Nutricional
    {
        public long Id { get; set; }
        public long EvaluacionNutricional { get; set; }
        [Required]
        public string Comida { get; set; } = string.Empty;
        [Required]
        public string Dia { get; set; } = string.Empty;
        [Required]
        public string Tipo { get; set; } = string.Empty;
        [Required]
        public string Alimento { get; set; } = string.Empty;
        [Required]
        public string ValorNutricional { get; set; } = string.Empty;
    }
}
