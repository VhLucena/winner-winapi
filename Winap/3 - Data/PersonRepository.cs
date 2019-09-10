using System.Collections.Generic;
using MongoDB.Driver;
using Winap.Models.Interfaces;

namespace Winap.Database
{
    public class PersonRepository : IRepository<PersonAbstract, string>
    {
        private readonly IMongoCollection<PersonAbstract> _mongo;

        public PersonRepository(IMongoConnection<PersonAbstract> mongoConnection)
        {
            _mongo = mongoConnection.Collection;
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
            _mongo.InsertOne(entity);
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