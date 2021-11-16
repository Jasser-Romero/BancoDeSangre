using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Donantes
{
    public class DonacionRepository : IDonacionRepository
    {
        private List<Donacion> donacion;
        private List<Donacion> donacionesBorradas;

        public DonacionRepository()
        {
            donacion = new List<Donacion>();
            donacionesBorradas = new List<Donacion>();
        }

        public void Create(Donacion t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            donacion.Add(t);
        }

        public bool Delete(Donacion t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (donacion == null)
            {
                throw new ArgumentNullException(nameof(donacion));
            }

            return donacion.Remove(t);
        }

        public Donacion[] FindAll()
        {

            return donacion.ToArray();
        }

        public List<Donacion> GetAll()
        {
            return donacion;
        }

        public Donacion GetDonacionById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"Error, el id {id} es invalido");
            }
            if (donacion == null)
            {
                throw new ArgumentException("La lista de donantes esta vacia");
            }
            return donacion.Find(o => o.Id == id);
        }

        public int GetLastId()
        {
            Donacion dnt;
            Donacion dnt1;

            if (donacion.Count == 0 && donacionesBorradas.Count == 0)
            {
                return 0;
            }
            if (donacionesBorradas.Count == 0)
            {
                dnt = donacion.FindLast(D => D.Id > 0);
                return dnt.Id;
            }
            if (donacion.Count == 0)
            {
                dnt1 = donacionesBorradas.FindLast(D => D.Id > 0);
                return dnt1.Id;
            }
            dnt = donacion.FindLast(D => D.Id > 0);
            dnt1 = donacionesBorradas.FindLast(D => D.Id > 0);

            return dnt.Id > dnt1.Id ? dnt.Id : dnt1.Id;
        }

        public int Update(Donacion t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (donacion == null)
            {
                throw new ArgumentNullException(nameof(donacion));
            }
            int index = donacion.FindIndex(d => d.Id == t.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El donante con id {t.Id} no existe");
            }
            donacion.Remove(donacion[index]);
            donacion.Add(t);
            return index;
        }
    }
}
