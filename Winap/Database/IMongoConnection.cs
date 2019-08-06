using MongoDB.Driver;

namespace Winap.Models.Interfaces
{
    public interface IMongoConnection<T>
    { 
        IMongoCollection<T> Collection { get; }
    }
}