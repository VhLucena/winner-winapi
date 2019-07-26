using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;
using Winap.Models.Interfaces;

namespace Winap.Services
{
    public class PersonService
    {
        private readonly IMongoCollection<IPerson> _persons;
        private readonly IMongoDatabase _database;
        private readonly string _collectionName;
        
        public PersonService(IWinnerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);

            _persons = _database.GetCollection<IPerson>(settings.CollectionName);
            _collectionName = settings.CollectionName;
        }

        public List<IPerson> GetAllPersons()
        {
            return _persons.Find(person => true).ToList();
        }

        public IPerson GetPersonByDocumentNumber(string documentNumber)
        {
            return _persons.Find(person => person.DocumentNumber == documentNumber).FirstOrDefault();
        }

        public void Create(IPerson person)
        {
            try
            {
                _persons.InsertOne(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Update(IFormattable id, IPerson newPerson)
        {
            _persons.ReplaceOne(person => person.DocumentNumber == id.ToString(), newPerson);
        }

        public void Remove(IFormattable id)
        {
            _persons.DeleteOne(person => person.DocumentNumber == id.ToString());
        }

        public void ClearCollection()
        {
            _database.DropCollection(_collectionName);
        }
    }
}