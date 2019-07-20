using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Winap.Models.Interfaces
{
    public abstract class IPerson
    {
        [BsonId]
        [BsonRepresentation((BsonType.ObjectId))]
        public String id;

        public String FullName;
        public String Email;
        public DateTime Birthday;
        public Int64 PhoneNumber;
        public String Cep;
        public String DocumentType;
        public String DocumentNumber;
        public String Street;
        public Int32 NumberOfHome;
        public String ComplementAddress;
        public String Neighborhood;
        public String City;
        public String State;
        public String Country;
        public Boolean IsDeficient;
        public String EmergencyContactName;
        public Int64 EmergencyContactPhone;
        public String EmergencyContactEmail;
        public String Password;
        public Boolean AllowUserPhotos;
    }
}