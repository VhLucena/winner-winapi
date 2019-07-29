
using NUnit.Framework;
using Winap.Database;
using Winap.Models;
using Winap.Models.Enum;
using Winap.Models.Fakes;
using Winap.Models.Interfaces;
using Winap.Services;

namespace Winap.Tests.Services
{
    [TestFixture]
    public class EventServiceTests
    {
        private DatabaseSettings _settings;
        private IRepository<EventAbstract, string> _eventService;

        [SetUp]
        public void Setup()
        {
            _settings = new DatabaseSettings
            {
                DatabaseName = "Winner",
                ConnectionString = "mongodb://localhost:27017",
                CollectionName = "PersonTest"
            };

            _eventService = new RepositoryFactory<EventAbstract, string>().Make(ServiceTypes.EventService, _settings);
            _eventService.ClearCollection();
        }

        [Test]
        public void Should_GetAll_When_PeopleExist()
        {
            var event1 = new EventFake {Id = "1"};
            var event2 = new EventFake {Id = "2"};
            var event3 = new EventFake {Id = "3"};
            var event4 = new EventFake {Id = "4"};
            var event5 = new EventFake {Id = "5"};
           
            _eventService.Create(event1);
            _eventService.Create(event2);
            _eventService.Create(event3);
            _eventService.Create(event4);
            _eventService.Create(event5);
            
            Assert.IsTrue(event1.Equals(_eventService.Get(event1.Id)));
            Assert.IsTrue(event2.Equals(_eventService.Get(event2.Id)));
            Assert.IsTrue(event3.Equals(_eventService.Get(event3.Id)));
            Assert.IsTrue(event4.Equals(_eventService.Get(event4.Id)));
            Assert.IsTrue(event5.Equals(_eventService.Get(event5.Id)));
        }
    }
}