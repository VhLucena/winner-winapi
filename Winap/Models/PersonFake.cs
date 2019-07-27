using System;
using MongoDB.Bson.Serialization.Attributes;
using Winap.Models.Interfaces;
// ReSharper disable All
// ReSharper disable BuiltInTypeReferenceStyle

namespace Winap.Models
{
    public class PersonFake : PersonAbstract
    {
        public PersonFake()
        {
            DocumentNumber = "213.118.100-6";
            FullName = "Beatriz Akemy Suzuki";
            Email = "biakemy@hotmail.com";
            Birthday = new DateTime(1992, 11, 21);
            PhoneNumber  = 18996751718;
            Cep = "16250-000";
            DocumentType = "RG";
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
            EmergencyContactEmail = "vilucenasantos@gmail.com";
            Password = "abelha123";
            AllowUserPhotos  = true;
        }
    }
}