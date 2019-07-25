using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Winap.Models.Interfaces
{
    public interface IPerson
    {
        String Id { get; }
        String FullName { get; }
        String Email { get; }
        DateTime Birthday { get; }
        Int64 PhoneNumber { get; }
        String Cep { get; }
        String DocumentType { get; }
        String DocumentNumber { get; }
        String Street { get; }
        IFormattable NumberOfHome { get; }
        String ComplementAddress { get; }
        String Neighborhood { get; }
        String City { get; }
        String State { get; }
        String Country { get; }
        Boolean IsDeficient { get; }
        String EmergencyContactName { get; }
        Int64 EmergencyContactPhone { get; }
        String EmergencyContactEmail { get; }
        String Password { get; }
        Boolean AllowUserPhotos { get; }
    }
}