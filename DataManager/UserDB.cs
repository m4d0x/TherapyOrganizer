using ClassHandler;
using Dapper;
using MySqlConnector;

namespace DataManager;
public class UserDB
{
    public static int activeUserId;
    public static string activeUserName;

    public UserDB()
    {
    }

    public void CreateUser(User newUser)
    {
        var connection = new MySqlConnection(Connector.sqlConString);
        var parameters = new DynamicParameters(newUser);
        var sqlString = "INSERT INTO user (first_name, last_name, email, pass_word, phone_number, isAdmin) VALUES (@FirstName, @LastName, @Email, @PassWord, @PhoneNumber, 0);";
        
        return activeUserId = connection.QuerySingle<int>(sqlString, parameters);

    }

    public User FindUser(string userEmail, string userPassword)
    {
        var connection = new MySqlConnection(Connector.sqlConString);
        string sqlQuery = "SELECT `id` AS UserId, `first_name` AS FirstName, `last_name` AS LastName, `email` AS Email, `password` AS Password `isAdmin`AS IsAdmin FROM `user` WHERE `user.email` = {userEmail} AND `user.password` = {userPassword};";
        var userProfile = connection.Query<User>(sqlQuery, parameters).FirstOrDefault();
        if (userProfile != null)
        {
            activeUserId = userProfile.UserId;
            activeUserName = userProfile.FirstName + " " + userProfile.LastName;
            return userProfile;

        }
        return null;
    }







}