using System;

namespace CapaEntidadHG.EvaluacionFisica
{
    public class EntEvaluacionFisica
    {
        public int IdEvaluacion { get; set; }

        public string DniMiembro { get; set; }
        public DateTime FechaEvaluacion { get; set; }

        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public int PresionSistolica { get; set; }
        public int PresionDiastolica { get; set; }
        public decimal IMC { get; set; }

        public string SignosVitales { get; set; }
        public string Antropometria { get; set; }
        public string Postura { get; set; }
        public string ValoracionFuncional { get; set; }
        public string Diagnostico { get; set; }
        public string Indicaciones { get; set; }
        public string MedicoResponsable { get; set; }

        public bool Activo { get; set; }

        public EntEvaluacionFisica()
        {
            FechaEvaluacion = DateTime.Now;
            Activo = true;
        }

        public string DNI
        {
            get => DniMiembro;
            set => DniMiembro = value;
        }

        public DateTime Fecha
        {
            get => FechaEvaluacion;
            set => FechaEvaluacion = value;
        }

        public string Valoracion
        {
            get => ValoracionFuncional;
            set => ValoracionFuncional = value;
        }
    }
}
