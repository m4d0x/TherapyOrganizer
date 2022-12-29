using Dapper;
using ClassHandler;
namespace DataManager;

public class ClientDBConnection IDBConnection
{
    public static Client ClientAccount;
    public static int ActiveClientId;
    public static string ActiveClientName;

    public ClientDBConnection()
    {

    }
    // 2. CreateClient
    public void ClientInsertExecution(string eMail, string passWord)
    {
        //User thisClient = new();
        var connection = new DBConnection();
        var tempClient = new Client { Email = eMail, PassWord = passWord };

        string sqlQuery = "INSERT INTO client (email, pass_word)" +
        "VALUES(@Email, @PassWord)";
        connection.OpenConnection().ExecuteScalar<Client>(sqlQuery, tempClient);
    }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<Client> GetClients()
        {
            string sqlString = @"
                SELECT * FROM `client` ct 
                INNER JOIN case cs ON cs.id = ct.case_id
                INNER JOIN case_log cl ON cs.id = ct.case_id
                WHERE ct.email = @Email";

            List<Client> clients = _connection.Query<Client, Case, CaseLog, Diagnose>(sqlString,
                (player, entity, characterClass) =>
                {
                    player.Entity = entity;
                    player.CharacterClass = characterClass;
                    return player;
                },
                new { @EntityTypeId = (int)EntityType.Player }
            ).ToList();


            // Hämtar vapen, skor och hjälm från databasen
            foreach (Player player in players)
            {
                player.Weapon = GetItem(player.WeaponId);
                player.Boots = GetItem(player.BootsId);
                player.Helm = GetItem(player.HelmId);
            }


            return players;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////








    public Client FindClientAccount(string eMail, string passWord) //should be working right now, check query first
    {
        string sqlQuery = "SELECT id AS ClientId, first_name AS FirstName, last_name AS LastName, email AS Email, pass_word AS Password FROM client WHERE client.email = " + eMail + " AND client.pass_word = " + passWord + ";";
        var connection = new DBConnection();
        var tempClient = connection.OpenConnection().Query<Client>(sqlQuery).FirstOrDefault();

        if (tempClient != null)
        {
            ActiveClientId = tempClient.ClientId;
            ActiveClientName = tempClient.FirstName + " " + tempClient.LastName;
            return tempClient;
        }
        return null;
    }

    public Client FindClientByMailAndPhoneNumber(string email, string phonenumber) //should be working right now, check query first
    {
        string sqlQuery = "SELECT id AS ClientId, first_name AS FirstName, last_name AS LastName, email AS Email, pass_word AS PassWord FROM client WHERE client.email = " + email + " AND client.phone_number = " + phonenumber + ";";
        var connection = new DBConnection();
        var thisClient = connection.OpenConnection().Query<Client>(sqlQuery).FirstOrDefault();

        if (thisClient != null)
        {
            ActiveClientId = thisClient.ClientId;
            ActiveClientName = thisClient.FirstName + " " + thisClient.LastName;
            return thisClient;
        }
        return null;
    }

}