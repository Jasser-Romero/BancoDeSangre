using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IDonanteRepository:IModel<Donante>
    {
        Donante GetDonanteById(int id);
        void Borrar(int id);
        void Actualizar(Donante donante);
    }
}
