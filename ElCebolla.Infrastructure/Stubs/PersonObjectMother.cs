using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElCebolla.Core.Models;

namespace ElCebolla.Infrastructure.Stubs
{
    public class PersonObjectMother
    {
        public static IEnumerable<Person> CreatePeople()
        {
            var random = new Random();

            yield return new Person
            {
                DateOfBirth = new DateTime(1984,1,1),
                FirstName = "Harry",
                LastName = "Potter",
                PersonId = 1

            };

            yield return new Person
            {
                DateOfBirth = new DateTime(1984, 1, 1),
                FirstName = "Adam",
                LastName = "Ray",
                PersonId = 2

            };

            yield return new Person
            {
                DateOfBirth = new DateTime(1984, 1, 1),
                FirstName = "Joe",
                LastName = "Mamma",
                PersonId = 3

            };

            yield return new Person
            {
                DateOfBirth = new DateTime(1984, 1, 1),
                FirstName = "The Other",
                LastName = "Lebowski",
                PersonId = 4

            };

            yield return new Person
            {
                DateOfBirth = new DateTime(1984, 1, 1),
                FirstName = "Harry",
                LastName = "Potter",
                PersonId = 5

            };

        }
    }
}
