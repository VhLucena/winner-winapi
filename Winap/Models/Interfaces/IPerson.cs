using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Winap.Models.Interfaces
{
    public abstract class IPerson : IEqualityComparer<IPerson>
    {
        [BsonId]
        public String DocumentNumber { get; set; }
        
        [BsonElement("FullName")]
        public String FullName { get; set; }

        [BsonElement("Email")]
        public String Email { get; set; }
        
        [BsonElement("BirthDay")]
        public DateTime Birthday { get; set; }
        
        [BsonElement("PhoneNumber")]
        public Int64 PhoneNumber { get; set; }

        [BsonElement("CEP")]
        public String Cep { get; set; }
        
        [BsonElement("DocumentType")]
        public String DocumentType { get; set; }

        [BsonElement("Street")]
        public String Street { get; set; }
        
        [BsonElement("NumberOfHome")]
        public Int32 NumberOfHome { get; set; }
        
        [BsonElement("ComplementAddress")]
        public String ComplementAddress { get; set; }

        [BsonElement("Neighborhood")] 
        public String Neighborhood { get; set; }

        [BsonElement("City")]
        public String City { get; set; }

        [BsonElement("State")]
        public String State { get; set; }
        
        [BsonElement("Country")]
        public String Country { get; set; }
        
        [BsonElement("IsDeficient")]
        public Boolean IsDeficient { get; set; }
        
        [BsonElement("EmergencyContactName")]
        public String EmergencyContactName { get; set; }
        
        [BsonElement("EmergencyContactPhone")]
        public Int64 EmergencyContactPhone { get; set; }
        
        [BsonElement("EmergencyContactEmail")]
        public String EmergencyContactEmail { get; set; }
        
        [BsonElement("Password")]
        public String Password { get; set; }
        
        [BsonElement("AllowUserPhotos")]
        public Boolean AllowUserPhotos { get; set; }


        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            
            var properties = typeof(IPerson).GetProperties();

            foreach (var property in properties)
            {
                stringBuilder.Append(property);
            }

            return stringBuilder.ToString();
        }
        
        public bool Equals(IPerson x, IPerson y)
        {
            return x.ToString() == y.ToString();
        }
        
        public int GetHashCode(IPerson obj)
        {
            return this.GetHashCode();
        }
    }
}
