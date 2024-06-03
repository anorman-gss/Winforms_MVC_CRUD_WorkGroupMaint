using System.Collections.Generic;
using System.Linq;
using Winforms_MVC_CRUD.Models;
using Winforms_MVC_CRUD.Services;

namespace Winforms_MVC_CRUD.Controllers
{
    internal class PersonController
    {
        private IPersonRepository _repository;
        private ILogger _logger;

        public PersonController(IPersonRepository personRepository, ILogger logger)
        {
            _repository = personRepository;
            _logger = logger;
        }

        public List<Person> GetAllPersons()
        {
            var persons = _repository.GetAll();

            if (persons == null || !persons.Any())
            {
                _logger.Info("No persons found");
            }

            return persons;
        }

        public Person GetPersonById(int id)
        {
            var person = _repository.GetById(id);

            if (person == null)
            {
                _logger.Info($"No persons found for Id {id}");
            }

            return person;
        }

        public void AddPerson(Person person)
        {
            var isAdded = _repository.Add(person);

            if (!isAdded)
            {
                _logger.Error($"Unabled to add Person");
            }
        }

        public void UpdatePerson(Person person)
        {
            var isUpdated = _repository.Update(person);

            if (!isUpdated)
            {
                _logger.Error($"Unabled to Update Person with ID {person.Id}");
            }
        }

        public void DeletePerson(int id)
        {
            var isDeleted = _repository.Delete(id);

            if (!isDeleted)
            {
                _logger.Error($"Unabled to Update Person with ID {id}");
            }
        }
    }
}
