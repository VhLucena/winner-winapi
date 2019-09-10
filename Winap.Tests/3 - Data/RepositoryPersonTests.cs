using System;
using MongoDB.Driver;
using Moq;
using NUnit.Framework;
using Winap.Database;
using Winap.Models.Fakes;
using Winap.Models.Interfaces;

namespace Winap.Tests.Repositories
{
    [TestFixture]
    public class RepositoryPersonTests
    {
        private Mock<IMongoCollection<PersonAbstract>> _mockPersonRepository;
        private PersonRepository _personRepository;

        private void SetupMockHappyPath()
        {
            _mockPersonRepository = new Mock<IMongoCollection<PersonAbstract>>();
            _mockPersonRepository.Setup(x => x.InsertOne(It.IsAny<PersonAbstract>(), null, default));

            _personRepository = new PersonRepository(_mockPersonRepository.Object);
        }
        
        [Test]
        public void Should_CreatePersonSuccessfully()
        {
            // Arrange
            SetupMockHappyPath();

            var personFake = new PersonFake();
            
            // Act / Assert
            try
            {
                _personRepository.Create(personFake);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            
            _mockPersonRepository.Verify(x => x.InsertOne(personFake, null, default), Times.Once);
            
            Assert.Pass();
        }

        [Test]
        public void Should_ReadPersonSuccessfully()
        {
            // Arrange
            SetupMockHappyPath();
            var personFake = new PersonFake();
        }
    }
}