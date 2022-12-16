namespace ClassHandler;

public class User : UltraClass
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int PhoneNumber { get; set; }
    public bool IsAdmin { get; set; }

    public User(string firstName, string lastName, string email, string password, string phoneNumber)// Should phoneNumber be string or int, TODO: Errorhandling for blankspace, -char or else
    {
        //create user/admin in db
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        PhoneNumber = Convert.ToInt32(phoneNumber);
        IsAdmin = false;
    }

    public User()
    {
        //load constructor from db
    }

}