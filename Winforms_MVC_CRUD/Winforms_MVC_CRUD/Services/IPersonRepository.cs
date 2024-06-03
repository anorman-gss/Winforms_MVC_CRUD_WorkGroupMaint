using System.Collections.Generic;
using Winforms_MVC_CRUD.Models;

namespace Winforms_MVC_CRUD.Services
{
    internal interface IPersonRepository
    {
        bool Add(Person person);
        bool Delete(int id);
        List<Person> GetAll();
        Person GetById(int id);
        bool Update(Person person);
    }
}