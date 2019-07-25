using System;
using MongoDB.Bson;

namespace Winap.Models.Interfaces
{
    public interface IWinnerDatabaseSettings
    {
        String CollectionName { get; set; }
        String ConnectionString { get; set; }
        String DatabaseName { get; set; }
    }
}