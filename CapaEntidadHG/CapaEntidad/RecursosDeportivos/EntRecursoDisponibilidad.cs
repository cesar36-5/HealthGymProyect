using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaEntidad.RecursosDeportivos
{
    public class EntRecursoDisponibilidad
    {
        public int Recurso {  get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Hora {  get; set; }
    }
}
