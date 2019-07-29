using System;
using MongoDB.Bson;

namespace Winap.Models.Interfaces
{
    public interface IDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}