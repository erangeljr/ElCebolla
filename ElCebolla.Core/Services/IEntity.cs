using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCebolla.Core.Services
{
    public interface IEntity<T>
    {
        T GetById(int Id);
    }
}
