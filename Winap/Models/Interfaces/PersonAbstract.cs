using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Winap.Models.Interfaces
{
    public abstract class PersonAbstract : IEqualityComparer<Person>
    {
        [BsonId]
        public string Id
        {
            get { return DocumentNumber; }
        }

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


        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            
            var properties = typeof(Person).GetProperties();

            foreach (var property in properties)
            {
                stringBuilder.Append(property);
            }

            return stringBuilder.ToString();
        }
        
        public bool Equals(Person x, Person y)
        {
            return x.ToString() == y.ToString();
        }
        
        public int GetHashCode(Person obj)
        {
            return this.GetHashCode();
        }
    }
}
