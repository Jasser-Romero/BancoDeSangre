using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Infraestructure.Donantes
{
    public class DonanteRepository:IDonanteRepository
    {
        private List<Donante> donantes;
        private List<Donante> donantesborrados;

        public DonanteRepository()
        {
            donantes = new List<Donante>();
            donantesborrados = new List<Donante>();
        }

        public void Create(Donante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            donantes.Add(t);
        }

        public void Borrar(int id)
        {
            Donante d = GetDonanteById(id);
            if(d == null)
            {
                throw new ArgumentException($"Error, el donante con id {id} no se pudo borrar");
            }
            donantes.Remove(d);
            donantesborrados.Add(d);
        }

        public bool Delete(Donante t)
        {
           if(t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (donantes == null)
            {
                throw new ArgumentNullException(nameof(donantes));
            }

            return donantes.Remove(t);
        }

        public Donante[] FindAll()
        {
            return donantes.ToArray();
        }

        public List<Donante> GetAll()
        {
            return donantes;
        }

        public Donante GetDonanteById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"Error, el id {id} es invalido");
            }
            if (donantes == null)
            {
                throw new ArgumentException("La lista de donantes esta vacia");
            }
            return donantes.Find(o => o.Id == id);
        }

        public int GetLastId()
        {
            Donante dnt;
            Donante dnt1;

            if(donantes.Count==0 && donantesborrados.Count == 0)
            {
                return 0;
            }
            if (donantesborrados.Count == 0)
            {
                dnt = donantes.FindLast(D => D.Id>0);
                return dnt.Id;
            }
            if (donantes.Count == 0)
            {
                dnt1 = donantesborrados.FindLast(D => D.Id > 0);
                return dnt1.Id;
            }
            dnt = donantes.FindLast(D => D.Id > 0);
            dnt1 = donantesborrados.FindLast(D => D.Id > 0);

            return dnt.Id > dnt1.Id ? dnt.Id : dnt1.Id;
        }

        public int Update(Donante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (donantes == null)
            {
                throw new ArgumentNullException(nameof(donantes));
            }
            int index = donantes.FindIndex(d => d.Id==t.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El donante con id {t.Id} no existe");
            }
            donantes.Remove(donantes[index]);
            donantes.Add(t);
            return index;
        }

    }

}
