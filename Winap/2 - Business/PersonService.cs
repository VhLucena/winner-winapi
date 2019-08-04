using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;
using Winap.Database;
using Winap.Exceptions;
using Winap.Models;
using Winap.Models.Interfaces;

namespace Winap.Services
{
    public class PersonService : IService<PersonAbstract>
    {
        private readonly IRepository<PersonAbstract, string> _personRepository;
        
        public PersonService(IRepository<PersonAbstract, string> personRepository)
        {
            _personRepository = personRepository;
        }
        
        public void Create(PersonAbstract person)
        {
            try
            {
                _personRepository.Create(person);
            }
            catch (MongoWriteException)
            {
                throw new PersonAlreadyExistsException();
            }
        }

        public void Update(PersonAbstract newPerson)
        {
            _personRepository.Update(newPerson);
        }

        public List<PersonAbstract> GetAll()
        {
            return _personRepository.GetAll();
        }

        public PersonAbstract Get(string id)
        {
            return _personRepository.Get(id);
        }
        
        public void Delete(string id)
        {
            _personRepository.Delete(id);
        }
    }
}