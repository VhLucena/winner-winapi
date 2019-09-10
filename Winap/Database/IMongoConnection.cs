using MongoDB.Driver;

namespace Winap.Models.Interfaces
{
    public abstract class IMongoConnection<T>
    {
        public abstract IMongoCollection<T> Collection { get; }
    }
}