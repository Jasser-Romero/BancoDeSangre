using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Donante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public Genero Genero { get; set; }
        public string Ocupacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public FactorRH FactorRH { get; set; }
        public GrupoSanguineo GrupoSanguineo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string Correo { get; set; }

    }
}
