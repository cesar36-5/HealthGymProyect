using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthGym.CapaEntidad
{
    public class EntEjercicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dificultad {  get; set; }
        public bool AtributoTecnico { get; set; }
        public string Descripcion {  get; set; }
    }
}
