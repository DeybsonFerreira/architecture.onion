using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onion.Domain.Entities
{
    public class Person
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
            Created = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime Created { get; private set; }

    }
}