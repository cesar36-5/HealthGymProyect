using System;
using System.Collections.Generic;
using System.Data;
using CapaDatosHG.EvaluacionFisica;
using CapaEntidadHG.EvaluacionFisica;

namespace CapaLogicaHG.EvaluacionFisica
{
    public class LogEvaluacionFisica
    {
        private readonly DatEvaluacionFisica datosEvaluacion = new DatEvaluacionFisica();

      
        public string GuardarEvaluacion(EntEvaluacionFisica evaluacion)
        {
            try
            {
                if (evaluacion == null)
                    return "La evaluación no puede ser nula.";

                if (evaluacion.Peso <= 0 || evaluacion.Altura <= 0)
                    return "Los valores de peso o altura no son válidos.";

                bool resultado = datosEvaluacion.InsertarEvaluacion(evaluacion);

                return resultado
                    ? "Evaluación guardada correctamente."
                    : "Error al guardar la evaluación.";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public DataTable ListarEvaluacionesPorDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI no puede estar vacío.", nameof(dni));

            return datosEvaluacion.ListarEvaluacionesPorDni(dni);
        }
        public bool ValidarCitaActiva(string dni)
        {
            return datosEvaluacion.ValidarCita(dni);
        }

        public bool RegistrarEvaluacion(EntEvaluacionFisica evaluacion)
        {
            return datosEvaluacion.InsertarEvaluacion(evaluacion);
        }
        public DataTable ListarEvaluaciones()
        {
            return datosEvaluacion.ListarEvaluaciones();
        }
        public DataRow ObtenerDatosMiembro(string dni)
        {
            DatEvaluacionFisica datos = new DatEvaluacionFisica();
            return datos.ObtenerDatosMiembroPorDni(dni);
        }




    }
}
