using System;
using Winap.Models.Interfaces;

namespace Winap.Models
{
    public class WinnerDatabaseSettings : IWinnerDatabaseSettings
    {
        public String CollectionName { get; set; }
        public String ConnectionString { get; set; }
        public String DatabaseName { get; set; }
    }
}