using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class DonanteService : IDonanteService
    {
        private IDonanteRepository donanteRepository;

        public DonanteService(IDonanteRepository donanteRepository)
        {
            this.donanteRepository = donanteRepository;
        }

        public void Borrar(int id)
        {
            donanteRepository.Borrar(id);
        }

        public void Create(Donante t)
        {
            donanteRepository.Create(t);
        }

        public bool Delete(Donante t)
        {
            return donanteRepository.Delete(t);
        }

        public Donante[] FindAll()
        {
            return donanteRepository.FindAll();
        }

        public List<Donante> GetAll()
        {
            return donanteRepository.GetAll();
        }

        public Donante GetDonanteById(int id)
        {
            return donanteRepository.GetDonanteById(id);
        }

        public int GetLastId()
        {
            return donanteRepository.GetLastId();
        }

        public int Update(Donante t)
        {
            return donanteRepository.Update(t);
        }
    }
}
