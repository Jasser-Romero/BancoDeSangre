using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Donacion : Donante
    {
        public Donacion()
        {
        }

        public decimal CantidadDonada { get; set; }

    }
}
