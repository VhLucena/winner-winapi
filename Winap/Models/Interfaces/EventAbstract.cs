using System;
using System.Globalization;
using MongoDB.Bson.Serialization.Attributes;
using Winap.Models.Fakes;

namespace Winap.Models.Interfaces
{
    [BsonKnownTypes(typeof(Event), typeof(EventFake))]
    public abstract class EventAbstract
    {
        [BsonId]
        public string Id { get; set; }


        [BsonElement("Name")]
        public string Name { get; set; }
        
        [BsonElement("Organizer")]
        public string Organizer { get; set; }
        
        [BsonElement("Date")]
        public DateTime Date { get; set; }
        
        [BsonElement("DateEnroll")]
        public DateTime DateEnroll { get; set; }
        
        [BsonElement("Street")]
        public string Street { get; set; }

        [BsonElement("Complement")]
        public string Complement { get; set; }

        [BsonElement("City")]
        public string City { get; set; }
        
        [BsonElement("State")]
        public string State { get; set; }
        
        [BsonElement("About")]
        public string About { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }

        [BsonElement("Regulation")]
        public string Regulation { get; set; }

        
        public bool IsEqual(object obj)
        {
            if (obj == null)
                return false;
            
            if (!(obj is PersonAbstract))
                return false;

            
            return Id == ((PersonAbstract) obj).Id;
        }
    }
}
