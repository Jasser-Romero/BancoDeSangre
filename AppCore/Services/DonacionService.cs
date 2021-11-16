using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class DonacionService : IDonacionService
    {
        private IDonacionRepository donacionRepository;
        public DonacionService(IDonacionRepository donacionRepository)
        {
            this.donacionRepository = donacionRepository;
        }
        public void Create(Donacion t)
        {
            donacionRepository.Create(t);
        }

        public bool Delete(Donacion t)
        {
            return donacionRepository.Delete(t);
        }

        public Donacion[] FindAll()
        {
            return donacionRepository.FindAll();
        }

        public List<Donacion> GetAll()
        {
            return donacionRepository.GetAll();
        }

        public int GetLastId()
        {
            return donacionRepository.GetLastId();
        }

        public int Update(Donacion t)
        {
            return donacionRepository.Update(t);
        }
    }
}
