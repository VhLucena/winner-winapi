using System;
using Winap.Models.Interfaces;

namespace Winap.Models
{
    public class WinnerDatabaseSettings : IWinnerDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}