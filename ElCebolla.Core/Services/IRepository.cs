using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ElCebolla.Core.Services
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
