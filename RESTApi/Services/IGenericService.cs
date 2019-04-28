using System;
using System.Collections.Generic;
using System.Text;

namespace RestSkeleton.Service
{
    public interface IGenericService<T>
    {
        T Create(T obj);
        T FindById(long id);
        List<T> FindAll();
        T Update(T person);
        void Delete(long id);
    }
}
