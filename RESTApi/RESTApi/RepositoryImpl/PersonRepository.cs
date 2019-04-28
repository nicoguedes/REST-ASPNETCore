using RestSkeleton.Model;
using RestSkeleton.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApi.RepositoryImpl
{
    public class PersonRepository : IPersonRepository
    {
        private MySqlContext _context;

        public PersonRepository(MySqlContext context)
        {
            _context = context;
        }


        public Person Create(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();

            return person;
        }

        public void Delete(long id)
        {
            var result = FindById(id);
            _context.Persons.Remove(result);
            _context.SaveChanges();
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id == id);
        }

        public Person Update(Person person)
        {
            var result = FindById(person.Id);
            _context.Entry(result).CurrentValues.SetValues(person);
            _context.SaveChanges();
            return person;
        }
    }
}
