using System;
using Winap.Models.Interfaces;

// ReSharper disable BuiltInTypeReferenceStyle

namespace Winap.Models
{
    public class Person : IPerson
    {
        public String Id { get; }
        public String FullName { get; }
        public String Email { get; }
        public DateTime Birthday { get; }
        public Int64 PhoneNumber { get; }
        public String Cep { get; }
        public String DocumentType { get; }
        public String DocumentNumber { get; }
        public String Street { get; }
        public IFormattable NumberOfHome { get; }
        public String ComplementAddress { get; }
        public String Neighborhood { get; }
        public String City { get; }
        public String State { get; }
        public String Country { get; }
        public Boolean IsDeficient { get; }
        public String EmergencyContactName { get; }
        public Int64 EmergencyContactPhone { get; }
        public String EmergencyContactEmail { get; }
        public String Password { get; }
        public Boolean AllowUserPhotos { get; }
    }
}