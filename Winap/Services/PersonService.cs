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
    public class PersonService : IRepository<PersonAbstract, string>
    {
        private readonly IMongoCollection<PersonAbstract> _persons;
        private readonly IMongoDatabase _database;
        private readonly string _collectionName;
        
        public PersonService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);

            _persons = _database.GetCollection<PersonAbstract>(settings.CollectionName);
            _collectionName = settings.CollectionName;
        }

     
        public void Create(PersonAbstract person)
        {
            try
            {
                _persons.InsertOne(person);
            }
            catch (MongoWriteException)
            {
                throw new PersonAlreadyExistsException();
            }
        }

        public void Update(PersonAbstract newPerson)
        {
            var result = _persons.ReplaceOne(person => person.Id == newPerson.Id, newPerson);
            
            if(result.MatchedCount == 0)
                throw new PersonDoesNotExistException();
        }

        public void Remove(string id)
        {
            var result = _persons.DeleteOne(person => person.Id == id);
            
            if(result.DeletedCount == 0)
                throw new PersonDoesNotExistException();
        }

        public List<PersonAbstract> GetAll()
        {
            return _persons.Find(person => true).ToList();
        }

        public PersonAbstract Get(string id)
        {
            return _persons.Find(person => person.Id == id).FirstOrDefault();
        }
        
        public void Delete(string id)
        {
            _persons.DeleteOne(person => person.Id == id);
        }

        public void ClearCollection()
        {
            _database.DropCollection(_collectionName);
        }
    }
}