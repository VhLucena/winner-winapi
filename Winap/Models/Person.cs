using System;
using Microsoft.AspNetCore.Routing.Constraints;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;
// ReSharper disable BuiltInTypeReferenceStyle

namespace Winap.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation((BsonType.ObjectId))]        
        public int Id { get; set; }
        
        public String FullName { get; set; }
        public String Email { get; set; }
        public DateTime Birthday { get; set; }
        public long PhoneNumber { get; set; }
        public String Cep { get; set; }
        public String DocumentType { get; set; }
        public String DocumentNumber { get; set; }
        public String Street { get; set; }
        public int NumberOfHome { get; set; }
        public String ComplementAddress { get; set; }
        public String Neighborhood { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public Boolean IsDeficient { get; set; }
        public String EmergencyContactName { get; set; }
        public String EmergencyContactPhone { get; set; }
        public String EmergencyContactEmail { get; set; }
        public String Password { get; set; }
        public Boolean AllowUserPhotos { get; set; }
    }
}