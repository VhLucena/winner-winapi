using System;
using Winap.Models.Enum;
using Winap.Models.Interfaces;
using Winap.Services;

namespace Winap.Database
{
    public class RepositoryFactory<T, K> : IRepositoryFactory<T, K>
    {
        public IRepository<T, K> Make(ServiceTypes serviceType, IDatabaseSettings settings)
        {
            switch (serviceType)
            {
                case ServiceTypes.PersonService:
                    return new PersonService(settings) as IRepository<T, K>;
                    
                case ServiceTypes.EventService:
                    return new EventService(settings) as IRepository<T, K>;
                
                default:
                    throw new Exception($"The RepositoryFactory cannot create {serviceType}" );
            }
        }
    }
}