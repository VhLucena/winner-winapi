namespace Winap.Models.Interfaces
{
    public interface IWinnerDatabaseSettings
    {
        string WinnerCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}