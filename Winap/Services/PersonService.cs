using System;
using Winap.Models.Interfaces;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Winap.Models;
using Person = Winap.Models.Person;

namespace Winap.Services
{
    public class PersonService
    {
        private readonly IMongoCollection<Person> _persons;

        public PersonService(IWinnerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _persons = database.GetCollection<Person>(settings.WinnerCollectionName);
        }

        public List<Person> GetAllPersons()
        {
            return _persons.Find(person => true).ToList();
        }

        public Person GetById(Int32 id)
        {
            return _persons.Find(person => person.id == id.ToString()).FirstOrDefault();
        }

        public IPerson Create(IPerson person)
        {
            _persons.InsertOne((Person)person);
            return person;
        }

        public void Update(Int32 id, Person newPerson)
        {
            _persons.ReplaceOne(person => person.id == id.ToString(), newPerson);
        }

        public void Remove(Int32 id)
        {
            _persons.DeleteOne(person => person.id == id.ToString());
        }

    }
}