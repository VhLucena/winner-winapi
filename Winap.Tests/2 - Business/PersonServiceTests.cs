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
        private Mock<IRepository<PersonAbstract, string>> personRepository;
        
        [SetUp]
        public void Setup()
        {
            var databaseSettings = new DatabaseSettings { 
                CollectionName = "CollectionName", 
                ConnectionString = "ServerAdress", 
                DatabaseName = "DatabaseName"};
            
            var mongoConnectionMock = new Mock<IMongoConnection<PersonAbstract>>(databaseSettings);
            
            var personRepositoryMock = new Mock<IRepository<PersonAbstract, string>>(mongoConnectionMock);
            

            
            _personService = new PersonService(personRepositoryMock.Object);
        }

        [Test]
        [Ignore("Must fix in the next PR")]
        public void Should_SaveSuccessfuly_When_PersonDoesNotExists()
        {
            // Arrange
            var person = new Person { DocumentNumber = "id" };
            
            personRepository.Setup(x => x.Create(It.IsAny<PersonAbstract>()));
            personRepository.Setup(x => x.Get(It.IsAny<string>())).Returns(person);
            
            _personService = new PersonService(personRepository.Object);
            
            // Act
            _personService.Create(person);
            var personRead = _personService.Get(person.Id);
            
            // Assert
            Assert.AreEqual(person.Id, personRead.Id);
        }

        [Test]
        [Ignore("Must fix in the next PR")]
        public void Should_ThrowException_When_PersonAlreadyExists()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act / Assert
            _personService.Create(person);

            Assert.Throws<PersonAlreadyExistsException>(() => _personService.Create(person));
        }

        [Test]
        [Ignore("Must fix in the next PR")]
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
        [Ignore("Must fix in the next PR")]
        public void Should_ThrowPersonDoesNotExistException_When_RemovePersonDoesNotExist()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act / Assert
            //Assert.Throws<PersonDoesNotExistException>((() => _personService.Remove(person.Id)));
        }
        
        [Test]
        [Ignore("Must fix in the next PR")]
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
        [Ignore("Must fix in the next PR")]
        public void Should_ThrowPersonDoesNotExistException_When_UpdatePersonDoesNotExist()
        {
            // Arrange
            var person = new PersonFake();
            
            // Act / Assert
            Assert.Throws<PersonDoesNotExistException>((() => _personService.Update(person)));
        }
    }
}