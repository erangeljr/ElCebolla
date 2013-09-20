using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ElCebolla.Core.Services;
using ElCebolla.Core.Models;

namespace ElCebolla.Infrastructure.Stubs
{
    public class PersonFakeRepository : IPersonRepository
    {

        public IEnumerable<Person> GetByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Get(Expression<Func<Core.Models.Person, bool>> predicate)
        {
            return PersonObjectMother.CreatePeople().AsQueryable().Where(predicate);
        }

        public IEnumerable<Person> GetAll()
        {
            return PersonObjectMother.CreatePeople();
        }

        public void Create(Person entity)
        {
            var people = PersonObjectMother.CreatePeople().ToList();
            people.Add(entity);
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
