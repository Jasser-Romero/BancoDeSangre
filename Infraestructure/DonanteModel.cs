using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Infraestructure
{
    public class DonanteModel
    {
        private List<Donante> donantes = new List<Donante>();

        public void Agregar(Donante donante)
        {
            donantes.Add(donante);
        }

        public void Borrar(int index)
        {
            donantes.RemoveAt(index);
        }
    }
}
