using RestSkeleton.Model;
using RestSkeleton.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApi.ServiceImpl
{
    public class GenericServiceImpl<T> : IGenericService<T>
    {
        private MySqlContext _context;

        public GenericServiceImpl(MySqlContext context)
        {
            _context = context;
        }

        public T Create(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();

            return obj;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public T FindById(long id)
        {
            throw new NotImplementedException();
        }

        public T Update(T person)
        {
            throw new NotImplementedException();
        }
    }
}
