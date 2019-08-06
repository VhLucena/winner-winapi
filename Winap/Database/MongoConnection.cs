using MongoDB.Driver;

namespace Winap.Models.Interfaces
{
    public class MongoConnection<T> : IMongoConnection<T>
    {
        public IMongoCollection<T> Collection { get; }
        
        public MongoConnection(IDatabaseSettings settings)
        {
            Collection = new MongoClient(settings.ConnectionString)
                .GetDatabase(settings.DatabaseName)
                .GetCollection<T>(settings.CollectionName);
        }

    }
}