using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Donacion : Donante
    {
        public Donacion(string nombre, string apellidos, GrupoSanguineo grupoSanguineo, FactorRH factorRH):base(nombre, apellidos, grupoSanguineo, factorRH)
        {
        
        }

        public int CantidadDonada { get; set; }


    }
}
