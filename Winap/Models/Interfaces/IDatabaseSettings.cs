using System;
using MongoDB.Bson;

namespace Winap.Models.Interfaces
{
    public interface IDatabaseSettings
    {
        string CollectionName { get; }
        string ConnectionString { get; }
        string DatabaseName { get; }
    }
}