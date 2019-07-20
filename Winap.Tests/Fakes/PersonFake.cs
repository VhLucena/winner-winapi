using System;
using Winap.Models.Interfaces;

// ReSharper disable BuiltInTypeReferenceStyle

namespace Winap.Tests.Fakes
{
    class PersonFake : IPerson
    {
        public PersonFake()
        {
            id = "123";
            FullName = "Beatriz Akemy Suzuki";
            Email = "";
            Birthday = new DateTime(1992, 11, 21);
            PhoneNumber = 18996751718;
            Cep = "16250-000";
            DocumentType = "RG";
            DocumentNumber = "213.118.100-6";
            Street = "Rua Aparecida do Norte";
            NumberOfHome = 455;
            ComplementAddress = "Perto do Bar do Zé";
            Neighborhood = "Centro";
            City = "Clementina";
            State = "São Paulo";
            Country = "Brazil";
            IsDeficient = false;
            EmergencyContactName = "Martins Almiro dos Santos";
            EmergencyContactPhone = 18996186201;
            EmergencyContactEmail = "";
            Password = "abelha123";
            AllowUserPhotos = true;
        }

    }
}