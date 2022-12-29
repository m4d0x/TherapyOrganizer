using ClassHandler;
using Dapper;
using MySqlConnector;
namespace DataManager;

public class DBConnection
{
    public static MySqlConnection DBConnect()
    {   //TODO Ändra namn på databasen till engelska. 
        var connection = new MySqlConnection("Server=localhost;Database=clinic_by_rob;Uid=root;");
        return connection;
    }
}