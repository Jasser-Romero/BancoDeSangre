using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        int Update(T t);
        T[] FindAll();
        bool Delete(T t);
        int GetLastId();
    }
}
