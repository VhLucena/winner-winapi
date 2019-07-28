using System;
using MongoDB.Bson.Serialization.Attributes;
using Winap.Models.Fakes;


namespace Winap.Models.Interfaces
{
    [BsonKnownTypes(typeof(Person), typeof(PersonFake))]
    public abstract class PersonAbstract
    {
        [BsonId]
        public string Id => DocumentNumber;

        [BsonElement("DocumentType")]
        public string DocumentType { get; set; }
        
        [BsonElement("DocumentNumber")]
        public string DocumentNumber { get; set; }

        [BsonElement("FullName")]
        public string FullName { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }
        
        [BsonElement("BirthDay")]
        public DateTime Birthday { get; set; }
        
        [BsonElement("PhoneNumber")]
        public long PhoneNumber { get; set; }

        [BsonElement("CEP")]
        public string Cep { get; set; }

        [BsonElement("Street")]
        public string Street { get; set; }
        
        [BsonElement("NumberOfHome")]
        public int NumberOfHome { get; set; }
        
        [BsonElement("ComplementAddress")]
        public string ComplementAddress { get; set; }

        [BsonElement("Neighborhood")] 
        public string Neighborhood { get; set; }

        [BsonElement("City")]
        public string City { get; set; }

        [BsonElement("State")]
        public string State { get; set; }
        
        [BsonElement("Country")]
        public string Country { get; set; }
        
        [BsonElement("IsDeficient")]
        public bool IsDeficient { get; set; }
        
        [BsonElement("EmergencyContactName")]
        public string EmergencyContactName { get; set; }
        
        [BsonElement("EmergencyContactPhone")]
        public long EmergencyContactPhone { get; set; }
        
        [BsonElement("EmergencyContactEmail")]
        public string EmergencyContactEmail { get; set; }
        
        [BsonElement("Password")]
        public string Password { get; set; }
        
        [BsonElement("AllowUserPhotos")]
        public bool AllowUserPhotos { get; set; }
        
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            
            if (!(obj is PersonAbstract))
                return false;

            
            return Id == ((PersonAbstract) obj).Id;
        }
    }
}
