
namespace Autosaloon.Database
{
    // Připojovací řádek
    public static class ConnectionString
    {
        private static string dataSource = @"(LocalDB)\MSSQLLocalDB";
        private static string linkOnDatabase = @"C:\USERS\PONOM\DESKTOP\AUTOSALOON\AUTOSALOON\DATABASE\DATABASE.MDF";
        
        public static string connectionString = 
            $"Data Source = {dataSource};" +
            $"AttachDbFilename={linkOnDatabase};" +
            $"Integrated Security = True";
    }
}
