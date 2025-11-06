using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadHG.CapaEntidad.PlanNutricional
{
    public class entRecetaPaso
    {
        public int PasoID { get; set; }
        public int RecetaID { get; set; }
        public int NumeroPaso { get; set; }
        public string Instruccion { get; set; }

        // Esto es un truco para que el ListBox muestre el texto bonito
        public override string ToString()
        {
            return $"{NumeroPaso}. {Instruccion}";
        }
    }
}
