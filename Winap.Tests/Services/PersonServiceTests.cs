using NUnit.Framework;
using Winap.Models;
using Winap.Services;
using Winap.Tests.Fakes;

namespace Winap.Tests.Services
{
    [TestFixture]
    public class PersonServiceTests
    {
        private PersonService _personService;
        private WinnerDatabaseSettings _settings;
        
        [SetUp]
        public void Setup()
        {
            _settings = new WinnerDatabaseSettings
            {
                DatabaseName = "Winner",
                ConnectionString = "mongodb://localhost:27017",
                CollectionName = "Person"
            };

            _personService = new PersonService(_settings);
            _personService.ClearCollection();
        }

        [Test]
        public void Should_SaveSuccessfuly_When_PersonDoesNotExists()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act
            _personService.Create(person);
            var personRead = _personService.GetPersonByDocumentNumber(person.DocumentNumber);
            
            // Assert
            Assert.IsTrue((person.Equals(personRead)));
        }
    }
}