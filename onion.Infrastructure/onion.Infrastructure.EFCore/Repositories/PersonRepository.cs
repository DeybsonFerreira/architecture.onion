using onion.Domain.Entities;
using onion.Domain.Interfaces.Repositories;

namespace onion.Infrastructure.EFCore.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public async Task CreateAsync(Person person)
        {
            await Task.Delay(1000);
            Console.WriteLine("Person Created By EF");
        }

        public async Task<Person> GetAsync(Guid personId)
        {
            Console.WriteLine("Get Person By EF");
            await Task.Delay(1000);
            return new Person(1, "Deybson Ferreira");
        }

        public void Dispose() => Console.WriteLine("Dispose By EF");

    }
}