using System.Collections.Generic;
using MongoDB.Driver;
using Winap.Models.Interfaces;

namespace Winap.Database
{
    public class PersonRepository : IRepository<PersonAbstract, string>
    {
        private readonly IMongoCollection<PersonAbstract> _persons;
     
        public PersonRepository(IMongoCollection<PersonAbstract> persons)
        {
            _persons = persons;
        }
        
        public List<PersonAbstract> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public PersonAbstract Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Create(PersonAbstract entity)
        {
            _persons.InsertOne(entity);
        }

        public void Update(PersonAbstract entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}