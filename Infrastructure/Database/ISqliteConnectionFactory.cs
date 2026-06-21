using System.Data.Common;
using Microsoft.Data.Sqlite;

public interface ISqliteConnectionFactory
{
    
    SqliteConnection CreateConnection();

}