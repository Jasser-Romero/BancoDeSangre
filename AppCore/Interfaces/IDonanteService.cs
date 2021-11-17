using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IDonanteService:IService<Donante>
    {
        Donante GetDonanteById(int id);
        void Borrar(int id);
        void Actualizar(Donante t);
    }
}
