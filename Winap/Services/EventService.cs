using System.Collections.Generic;
using MongoDB.Driver;
using Winap.Database;
using Winap.Exceptions;
using Winap.Models.Interfaces;

namespace Winap.Services
{
    public class EventService : IRepository<EventAbstract, string>
    {
        private readonly IMongoCollection<EventAbstract> _events;
        private readonly IMongoDatabase _database;
        private readonly string _collectionName;
        
        public EventService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);

            _events = _database.GetCollection<EventAbstract>(settings.CollectionName);
            _collectionName = settings.CollectionName;
        }

        public void Create(EventAbstract newEvent)
        {
            try
            {
                _events.InsertOne(newEvent);
            }
            catch (MongoWriteException)
            {
                throw new EventAlreadyExistsException();
            }
        }

        public void Update(EventAbstract newPerson)
        {
            var result = _events.ReplaceOne(person => person.Id == newPerson.Id, newPerson);
            
            if(result.MatchedCount == 0)
                throw new PersonDoesNotExistException();
        }

        public void Remove(string id)
        {
            var result = _events.DeleteOne(person => person.Id == id);
            
            if(result.DeletedCount == 0)
                throw new PersonDoesNotExistException();
        }

        public List<EventAbstract> GetAll()
        {
            return _events.Find(person => true).ToList();
        }

        public EventAbstract Get(string id)
        {
            return _events.Find(person => person.Id == id).FirstOrDefault();
        }
        
        public void Delete(string id)
        {
            var result = _events.DeleteOne(person => person.Id == id);
            
            if(result.DeletedCount == 0)
                throw new PersonDoesNotExistException();
        }

        public void ClearCollection()
        {
            _database.DropCollection(_collectionName);
        }
    }
}