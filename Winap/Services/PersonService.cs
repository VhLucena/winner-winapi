using Winap.Models.Interfaces;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Winap.Models;

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

        public Person GetById(int id)
        {
            return _persons.Find(person => person.Id == id).FirstOrDefault();
        }

        public Person Create(Person person)
        {
            _persons.InsertOne(person);
            return person;
        }

        public void Update(int id, Person newPerson)
        {
            _persons.ReplaceOne(person => person.Id == id, newPerson);
        }

        public void Remove(int id)
        {
            _persons.DeleteOne(person => person.Id == id);
        }

    }
}