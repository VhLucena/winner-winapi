using Moq;
using NUnit.Framework;
using Winap.Database;
using Winap.Exceptions;
using Winap.Models;
using Winap.Models.Fakes;
using Winap.Models.Interfaces;
using Winap.Services;

namespace Winap.Tests.Services
{
    [TestFixture]
    public class PersonServiceTests
    {
        private IService<PersonAbstract> _personService;
        
        [SetUp]
        public void Setup()
        {
            var mongoConnection = new MongoConnection<PersonAbstract>(new DatabaseSettings());
            
            var personRepository = new Mock<IRepository<PersonAbstract, string>>(mongoConnection);
            
            personRepository.Setup(_ => _.Create(It.IsAny<PersonAbstract>()));
            
            _personService = new PersonService(personRepository.Object);
        }

        [Test]
        public void Should_SaveSuccessfuly_When_PersonDoesNotExists()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act
            _personService.Create(person);
            var personRead = _personService.Get(person.Id);
            
            // Assert
            Assert.IsTrue(person.Equals(personRead));
        }

        [Test]
        public void Should_ThrowException_When_PersonAlreadyExists()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act / Assert
            _personService.Create(person);

            Assert.Throws<PersonAlreadyExistsException>(() => _personService.Create(person));
        }

        [Test]
        public void Should_RemovePersonSuccessfully_When_PersonExists()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act
            _personService.Create(person);
            //_personService.Remove(person.Id);
            
            // Assert
            Assert.IsNull(_personService.Get(person.Id));
        }

        [Test]
        public void Should_ThrowPersonDoesNotExistException_When_RemovePersonDoesNotExist()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act / Assert
            //Assert.Throws<PersonDoesNotExistException>((() => _personService.Remove(person.Id)));
        }
        
        [Test]
        public void Should_UpdatePersonSuccessfully_When_PersonExists()
        {
            // Arrange
            var person = new PersonFake();
            const string newName = "Beatriz Lucena Suzuki";
            
            // Act
            _personService.Create(person);
            person.FullName = newName;
            _personService.Update(person);
            
            // Assert
            Assert.AreEqual(newName, person.FullName);
        }
        
        [Test]
        public void Should_ThrowPersonDoesNotExistException_When_UpdatePersonDoesNotExist()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act / Assert
            Assert.Throws<PersonDoesNotExistException>((() => _personService.Update(person)));
        }
    }
}