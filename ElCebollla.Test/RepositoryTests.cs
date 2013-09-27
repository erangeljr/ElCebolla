using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElCebolla.Core.Services;
using ElCebolla.Infrastructure.Stubs;
using ElCebolla.Core.Models;
using System.Linq;

namespace ElCebollla.Test
{
    [TestClass]
    public class RepositoryTests
    {

        private readonly IPersonRepository _personRepository;

        public RepositoryTests()
        {
            _personRepository = new PersonFakeRepository();
        }


        [TestMethod, TestCategory("Person Repository")]
        public void Can_Get_All_People()
        {
            var people = _personRepository.GetAll();

            Assert.IsNotNull(people.Any());
        }

        [TestMethod, TestCategory("Person Repository")]
        public void Can_Get()
        {
            var person = _personRepository.Get(p => p.FirstName == "Harry");

            Assert.IsNotNull(person.Any());
        }

        [TestMethod, TestCategory("Person Repository")]
        public void Can_Create()
        {
            var personCount = _personRepository.GetAll().Count();
            var lasId = _personRepository.GetAll().Max(p => p.PersonId);

            var person = new Person
            {
                DateOfBirth = DateTime.Now,
                FirstName = "Mini",
                LastName = "Me"
            };

            _personRepository.Create(person);

            Assert.IsTrue(_personRepository.GetAll().Count() == (personCount + 1));
            Assert.IsTrue(person.PersonId > lasId );

        }

        [TestMethod, TestCategory("Person Repository")]
        public void Can_Update()
        {
            const string newLastName = "Bomb";
            var person = _personRepository.GetById(2);

            if (person == null)
                Assert.Fail();
            person.LastName = newLastName;
            _personRepository.Update(person);

            Assert.IsTrue(_personRepository.GetByLastName(newLastName).Any());

        }
    }
}
