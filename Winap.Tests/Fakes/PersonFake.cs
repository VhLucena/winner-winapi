using System;
using Winap.Models.Interfaces;

// ReSharper disable BuiltInTypeReferenceStyle

namespace Winap.Tests.Fakes
{
    public class PersonFake : IPerson
    {
        public String Id { get; } = "123";
        public String FullName { get; } = "Beatriz Akemy Suzuki";
        public String Email { get; } = "biakemy@hotmail.com";
        public DateTime Birthday { get; } = new DateTime(1992, 11, 21);
        public Int64 PhoneNumber { get; } = 18996751718;
        public String Cep { get; } = "16250-000";
        public String DocumentType { get; } = "RG";
        public String DocumentNumber { get; } = "213.118.100-6";
        public String Street { get; } = "Rua Aparecida do Norte";
        public IFormattable NumberOfHome { get; } = 455;
        public String ComplementAddress { get; } = "Perto do Bar do Zé";
        public String Neighborhood { get; } = "Centro";
        public String City { get; } = "Clementina";
        public String State { get; } = "São Paulo";
        public String Country { get; } = "Brazil";
        public Boolean IsDeficient { get; } = false;
        public String EmergencyContactName { get; } = "Martins Almiro dos Santos";
        public Int64 EmergencyContactPhone { get; } = 18996186201;
        public String EmergencyContactEmail { get; } = "vilucenasantos@gmail.com";
        public String Password { get; } = "abelha123";
        public Boolean AllowUserPhotos { get; } = true;
    }
}