using System;
using System.Collections.Generic;
using System.Text;

namespace RestSkeleton.Repository
{
    public interface IGenericRepository<T>
    {
        T Create(T obj);
        T FindById(long id);
        List<T> FindAll();
        T Update(T person);
        void Delete(long id);
    }
}
