using System;
namespace HealthGym.CapaEntidad
{
    public class EntMiembro
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public int Sexo { get; set; }
        public string Seguro { get; set; }
        public string Correo { get; set; }
        public DateTime InicioMembresia { get; set; }
        public DateTime FinalMembresia { get; set; }
        public string GrupoSanguineo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}