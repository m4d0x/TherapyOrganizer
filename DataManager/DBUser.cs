using ClassHandler;
using Dapper;
namespace DataManager;
public class UserDB
{
    public static User UserContainer;
    public static int activeUserId;
    public static string activeUserName;

    public UserDB()
    {

    }


    //är den här skriven som insert eller extractFion?
    // public static User UserInsertExecution(string eMail, string passWord) // Connection that creates the "shell" of a user containing email and password until user is tossed for the final registration. //tho maybe not if admin does the creation?
    // {
    //     User newUser = new User();
    //     var connection = new MySqlConnection(DBConnection.sqlConString);
    //     var parameters = new DynamicParameters(newUser);
    //     var sqlString = $"INSERT INTO user (email, pass_word) VALUES ('{eMail}', '{passWord}')";
    //     //var sqlString = "$INSERT INTO user (first_name, last_name, email, pass_word, phone_number, isAdmin) VALUES (@FirstName, @LastName, {eMail}, {passWord}, @PhoneNumber, 0);";

    //     return newUser = connection.QuerySingle<User>(sqlString, parameters);

    // }
    public static void UserInsertExecution(string eMail, string passWord)
    {
        //User tempUser = new();
        var connection = new DBConnection();
        var tempUser = new User { Email = eMail, PassWord = passWord };

        string sqlQuery = "INSERT INTO user (email, pass_word)" +
        "VALUES(@Email, @PassWord)";
        DBConnection.DBConnect().ExecuteScalar<User>(sqlQuery, tempUser);
    }
/* 
    public ActiveOrder GetActiveOrderById(int id)
    {
        var parameters = new DynamicParameters();
        parameters.Add("@Id", id);
        string query = "SELECT id AS Id,stock_id AS StockId, account_id AS AccountId, price_per_stock AS PricePerStock," +
         "amount AS Amount, is_buy_order AS IsBuyOrder, order_date_time AS OrderTimeStamp, is_active AS IsActive FROM active_orders " +
         "WHERE id = @Id;";

        using (var connection = DBConnect())
        {
            try
            {
                ActiveOrder result = connection.QuerySingle<ActiveOrder>(query, parameters);
                return result;
            }

            catch (System.Exception e)
            {
                throw e;
            }

        }
    }

    public ActiveOrder GetActiveOrderById(int id)
    {
        var parameters = new DynamicParameters();
        parameters.Add("@Id", id);
        string query = "SELECT id AS Id,stock_id AS StockId, account_id AS AccountId, price_per_stock AS PricePerStock," +
         "amount AS Amount, is_buy_order AS IsBuyOrder, order_date_time AS OrderTimeStamp, is_active AS IsActive FROM active_orders " +
         "WHERE id = @Id;";

        using (var connection = DBConnect())
        {
            try
            {
                ActiveOrder result = connection.QuerySingle<ActiveOrder>(query, parameters);
                return result;
            }

            catch (System.Exception e)
            {
                throw e;
            }

        }
    }
    public int CreateActiveOrder(ActiveOrder myActiveOrder)
    {
        var parameters = new DynamicParameters(myActiveOrder);

        string query = "INSERT INTO active_orders (stock_id, account_id, price_per_stock, amount, is_buy_order," +
        "order_date_time, is_active)" +
        "VALUES(@StockId, @AccountId, @PricePerStock, @Amount, @IsBuyOrder, @OrderTimeStamp, @IsActive);" +
        "SELECT MAX(id) FROM active_orders;";

        using (var connection = DBConnect())
        {
            try
            {
                var id = connection.ExecuteScalar<int>(query, parameters);
                return id;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    } */




    // public User ExtractUserLoginData(string userEmail, string userPassword)
    // {
    //     var connection = new MySqlConnection(DBConnection.sqlConString);
    //     string sqlQuery = "SELECT `id` AS UserId, `first_name` AS FirstName, `last_name` AS LastName, `email` AS Email, `password` AS Password `isAdmin`AS IsAdmin FROM `user` WHERE `user.email` = {userEmail} AND `user.password` = {userPassword};";
    //     var userProfile = connection.Query<User>(sqlQuery).FirstOrDefault();
    //     if (userProfile != null)
    //     {
    //         activeUserId = userProfile.UserId;
    //         activeUserName = userProfile.FirstName + " " + userProfile.LastName;
    //         return userProfile;

    //     }
    //     return null;
    // }

    // public User ExtractSingleUserData()
    // {
    //     var connection = new MySqlConnection(DBConnection.sqlConString);
    //     string sqlQuery = "SELECT `id` AS UserId, `first_name` AS FirstName, `last_name` AS LastName, `email` AS Email, `password` AS Password `isAdmin`AS IsAdmin FROM `user` WHERE `user.email` = {userEmail} AND `user.password` = {userPassword};";
    //     var userProfile = connection.Query<User>(sqlQuery).FirstOrDefault();
    //     if (userProfile != null)
    //     {
    //         activeUserId = userProfile.UserId;
    //         activeUserName = userProfile.FirstName + " " + userProfile.LastName;
    //         return userProfile;

    //     }
    //     return null;
    // }

    /* using MySqlDBConnection;

     public class DBConnection
    {
          //Parent class that handles the server and user/pw for the database connection
          public MySqlConnection DBConnect()
        {   //TODO Ändra namn på databasen till engelska. 
             var connection = new MySqlConnection("Server=localhost;Database=aktiehandel;Uid=root;");
            return connection;
        }
    } */





}