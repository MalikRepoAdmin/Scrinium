using System;
using Microsoft.Data.Sqlite;

public sealed class SqliteConnectionFactory : ISqliteConnectionFactory
{

    private readonly string _connectionString;

    public SqliteConnectionFactory(string connectionString)
    {
        
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("Connection String Cannot be empty");
        }
        else
        {
            this._connectionString = connectionString;   
        }
    }
    
    public SqliteConnection CreateConnection()
    {
        
        return new SqliteConnection(_connectionString);
    }

}