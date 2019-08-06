using System.Collections.Generic;
using MongoDB.Driver;
using Winap.Models.Interfaces;

namespace Winap.Database
{
    public class EventRepository : IRepository<EventAbstract, string>
    {
        private readonly IMongoCollection<EventAbstract> _events;
     
        public EventRepository(IMongoCollection<EventAbstract> events)
        {
            _events = events;
        }
        
        public List<EventAbstract> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public EventAbstract Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Create(EventAbstract entity)
        {
            _events.InsertOne(entity);
        }

        public void Update(EventAbstract entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}