using Winap.Models.Enum;
using Winap.Models.Interfaces;

namespace Winap.Database
{
    public interface IRepositoryFactory<T,K>
    {
        IRepository<T,K> Make(ServiceTypes serviceType, IDatabaseSettings settings);
    }
}