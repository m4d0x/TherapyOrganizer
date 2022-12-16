using ClassHandler;
using Dapper;
using MySqlConnector;

namespace DataManager;
public class UserDB
{
    User userContainer = new();
    public static int activeUserId;
    public static string activeUserName;

    public UserDB()
    {
        
    }


    //är den här skriven som insert eller extractFion?
    public static User UserInsertExecution(string eMail, string passWord) // Connection that creates the "shell" of a user containing email and password until user is tossed for the final registration. //tho maybe not if admin does the creation?
    {
        User newUser = new User();
        var connection = new MySqlConnection(Connector.sqlConString);
        var parameters = new DynamicParameters(newUser);
        var sqlString = "INSERT INTO user (first_name, last_name, email, pass_word, phone_number, isAdmin) VALUES (@FirstName, @LastName, @Email, @PassWord, @PhoneNumber, 0);";


        return newUser = connection.QuerySingle<User>(sqlString, parameters);

    }

    // public User ExtractUserLoginData(string userEmail, string userPassword)
    // {
    //     var connection = new MySqlConnection(Connector.sqlConString);
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
    //     var connection = new MySqlConnection(Connector.sqlConString);
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







}