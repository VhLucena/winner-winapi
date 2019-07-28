using System;
using Winap.Models.Interfaces;
// ReSharper disable All

namespace Winap.Models.Fakes
{
    public class EventFake : EventAbstract
    {
        
        public EventFake()
        {
            Id = "123456";
            Name = "65a Maratona de São Silvestre";
            Organizer = "Cidade de São Paulo";
            Date = new DateTime(2020, 12, 30);
            DateEnroll = new DateTime(2020, 12, 25);
            Street = "Avenida do Ibirapuera";
            Complement = "Parque do Ibirapuera";
            City = "São Paulo";
            State = "SP";
            About = "A tradicional corrida de São Silvestre chega na sua 65a versão e conta com inumeras novidades";
            State = "Aberto";
            Regulation = "https://storagefileta.blob.core.windows.net/ticketagora/arquivos/evento/6744/6b7286d10cdf4ff99a6a58c8fbdc9a3b636942070552529166.pdf";
        }
    }
}