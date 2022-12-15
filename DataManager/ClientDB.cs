using ClassHandler;
using Dapper;
using MySqlConnector;

namespace DataManager;

public class ClientDB
{
   public ClientDB()
   {
      
   }

   public void CreateClient(Client newClient)
   {
      var connection = new MySqlConnection(Connector.sqlConString);
		var parameters = new DynamicParameters (newClient);
   }
   
}