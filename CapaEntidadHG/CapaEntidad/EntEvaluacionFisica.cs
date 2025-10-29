using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadHG.CapaEntidad
{
    public class EntEvaluacionFisica
    {
        public long Id { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public double IMC { get; set; }
        public double PorcentajeGrasa { get; set; }
        public double Flexibilidad {  get; set; }
        public double Fuerza { get; set; }
        public double Equilibrio { get; set; }
        public string Observacion { get; set; }
        public string Objetivo { get; set; }
    }
}
