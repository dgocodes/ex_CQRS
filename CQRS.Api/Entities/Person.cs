using System;

namespace CQRS.Api.Entities
{
    public class Person : BaseEntity
    {
        public Person(string name, DateTime birthdate, string email)
        {
            Name = name;
            Birthdate = birthdate;
            Email = email;
        }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public string Email { get; set; }
    }
}
