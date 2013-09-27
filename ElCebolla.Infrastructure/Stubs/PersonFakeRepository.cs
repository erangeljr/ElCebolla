using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ElCebolla.Core.Services;
using ElCebolla.Core.Models;
using System.Collections;

namespace ElCebolla.Infrastructure.Stubs
{
    public class PersonFakeRepository : IPersonRepository
    {
        private readonly List<Person> _people;

        public PersonFakeRepository() : this(people: PersonObjectMother.CreatePeople())
        { 
        }

        public PersonFakeRepository(IEnumerable<Person> people)
        {
            _people = people.ToList();
        }

        public IEnumerable<Person> GetByLastName(string lastName)
        {
            return _people.Where(p => p.LastName == lastName);
        }

        public IEnumerable<Person> Get(Expression<Func<Core.Models.Person, bool>> predicate)
        {
            return PersonObjectMother.CreatePeople().AsQueryable().Where(predicate);
        }

        public IEnumerable<Person> GetAll()
        {
            return _people;
        }

        public void Create(Person entity)
        {
            entity.PersonId = _people.Max(p => p.PersonId) + 1;
            _people.Add(entity);
        }

        public void Update(Person entity)
        {
            var person = _people.Find(p => p.PersonId == entity.PersonId);
            person.DateOfBirth = entity.DateOfBirth;
            person.FirstName = entity.FirstName;
            person.LastName = entity.LastName;
            person.Locations = entity.Locations;
        }

        public void Delete(Person entity)
        {
            _people.Remove(entity);
        }

        public Person GetById(int Id)
        {
            return _people.FirstOrDefault(p => p.PersonId == Id);
 
        }
    }
}
