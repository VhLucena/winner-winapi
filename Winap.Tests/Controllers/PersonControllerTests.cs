

using System.Net;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;
using Winap.Controllers;
using Winap.Models;
using Winap.Models.Interfaces;
using Winap.Services;
using Winap.Tests.Fakes;
using Microsoft.AspNetCore.Mvc;

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
                CollectionName = "Person"
            };

            _personService = new PersonService(_settings);
            _personService.ClearCollection();
            
            _personController = new PersonController(_personService);
        }
        
        [Test]
        public void Should_ReturnStatusCode201Created_When_CreatingPersonForFirstTime()
        {
            // Arrange
            var person = new PersonFake();
            
            // Action
            var httpStatusCode = _personController.CreatePerson(person);
            
            // Assert
            Assert.AreEqual(StatusCodes.Status201Created, httpStatusCode);
        }
        
        [Test]
        public void Should_ReturnStatusCode400_When_CreatingPersonAlreadyExists()
        {
            // Arrange
            var person = new PersonFake();
            
            // Action
            _personController.CreatePerson(person);
            var httpStatusCode = _personController.CreatePerson(person);
            
            // Assert
            Assert.AreEqual(StatusCodes.Status400BadRequest, httpStatusCode);
        }
    }
}