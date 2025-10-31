using CapaDatosHG;
using CapaDatoss;
using CapaEntidadHG;
using CapaEntidadHG.EvaluacionFisica;
using System.Collections.Generic;

namespace CapaLogicaHG
{
    public class LogHistoriaClinica
    {
        DatHistoriaClinica datos = new DatHistoriaClinica();

        public string Registrar(EntHistoriaClinica h)
        {
            bool resultado = datos.InsertarHistoria(h);
            return resultado ? "Historia clínica registrada correctamente." : "Error al registrar historia clínica.";
        }

        public List<EntHistoriaClinica> Consultar(string dni, DateTime desde, DateTime hasta)
        {
            return datos.Consultar(dni, desde, hasta);
        }
    }
}
