
using System;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;
using Winap.Controllers;
using Winap.Models;
using Winap.Models.Interfaces;
using Winap.Services;
using Moq;
using Winap.Database;

namespace Winap.Tests.Controllers
{
    [TestFixture]
    public class PersonControllerTests
    {
        private PersonController _personController;
        private Mock<IRepository<PersonAbstract, string>> _mockPersonService;
        private IWinnerDatabaseSettings _settings;
        
        [SetUp]
        public void Setup()
        {
            _settings = new WinnerDatabaseSettings
            {
                DatabaseName = "Winner",
                ConnectionString = "mongodb://localhost:27017",
                CollectionName = "PersonTests"
            };

            SetupMockPersonService();
            
            _personController = new PersonController(_mockPersonService.Object);
        }

        private void SetupMockPersonService()
        {
            _mockPersonService = new Mock<IRepository<PersonAbstract, string>>();

            _mockPersonService.Setup(x => x.Create(It.IsAny<PersonAbstract>()));
            _mockPersonService.Setup(x => x.Get(It.IsAny<string>())).Returns(It.IsAny<PersonAbstract>());
            _mockPersonService.Setup(x => x.Update(It.IsAny<PersonAbstract>()));
            _mockPersonService.Setup(x => x.Delete(It.IsAny<string>()));
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