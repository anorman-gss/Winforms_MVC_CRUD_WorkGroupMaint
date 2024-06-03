using System.Collections.Generic;
using System.Linq;
using Winforms_MVC_CRUD.Models;

namespace Winforms_MVC_CRUD.Services
{
    internal class PersonRepository : IPersonRepository
    {
        private List<Person> Persons = new List<Person>();

        public List<Person> GetAll()
        {
            return Persons;
        }

        public Person GetById(int id)
        {
            var existingPerson = Persons.FirstOrDefault(s => s.Id == id);
            if (existingPerson == null)
            {
                throw new KeyNotFoundException("Person not found for given ID");
            }

            return existingPerson;
        }

        public bool Add(Person person)
        {
            person.Id = Persons.Count + 1;
            Persons.Add(person);

            return true;
        }

        public bool Update(Person person)
        {
            var existingPerson = Persons.FirstOrDefault(s => s.Id == person.Id);
            if (existingPerson == null)
            {
                return false;
            }

            existingPerson.Name = person.Name;
            existingPerson.Age = person.Age;

            return true;
        }

        public bool Delete(int PersonId)
        {
            var PersonToRemove = Persons.FirstOrDefault(s => s.Id == PersonId);
            if (PersonToRemove == null)
            {
                return false;
            }

            Persons.Remove(PersonToRemove);
            return true;
        }
    }
}
