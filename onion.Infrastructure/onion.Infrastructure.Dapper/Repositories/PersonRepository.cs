using onion.Domain.Entities;
using onion.Domain.Interfaces.Repositories;

namespace onion.Infrastructure.Dapper.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public async Task CreateAsync(Person person)
        {
            await Task.Delay(1000);
            System.Console.WriteLine("Person Created By EF");
        }

        public async Task<Person> GetAsync(Guid personId)
        {
            await Task.Delay(1000);
            return new Person(1, "Deybson Ferreira");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}