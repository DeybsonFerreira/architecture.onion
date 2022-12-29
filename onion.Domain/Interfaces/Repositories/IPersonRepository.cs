using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onion.Domain.Entities;

namespace onion.Domain.Interfaces.Repositories
{
    public interface IPersonRepository : IDisposable
    {
        Task CreateAsync(Person person);
        Task<Person> GetAsync(Guid personId);
    }
}