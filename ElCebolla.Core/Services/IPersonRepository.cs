using ElCebolla.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCebolla.Core.Services
{
    public interface IPersonRepository : IEntity<Person>, IRepository<Person>
    {
        IEnumerable<Person> GetByLastName(string lastName);
    }
}
