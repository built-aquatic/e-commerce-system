// Database.cs
using System.Data.SqlClient;

public static class Database
{
    private const string ConnectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}
