

using NUnit.Framework;
using Winap.Controllers;
using Winap.Models;
using Winap.Models.Interfaces;
using Winap.Services;
using Winap.Tests.Fakes;

namespace Winap.Tests.Controllers
{
    [TestFixture]
    public class PersonControllerTests
    {
        private PersonController _personController;
        private PersonService _personService;
        private IWinnerDatabaseSettings _settings;
        
        [SetUp]
        public void Setup()
        {
            _settings = new WinnerDatabaseSettings
            {
                DatabaseName = "Winner",
                ConnectionString = "mongodb://localhost:27017",
                WinnerCollectionName = "Person"
            };

            _personService = new PersonService(_settings);
            _personController = new PersonController(_personService);
        }
        
        [Test]
        public void Should_ReturnStatusCode201Created_When_CreatePersonSuccessfully()
        {
            var person = new PersonFake();
            var httpStatusCode = _personController.CreatePerson(person);
        }
    }
}