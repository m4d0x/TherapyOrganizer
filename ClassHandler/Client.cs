namespace ClassHandler;
public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Occupation { get; set; }
    public int PhoneNumber { get; set; } //hantera strängen för att ta bort - och " "/mellanslag
    public string Email { get; set; }
    public string Password { get; set; }
    public int CaseId { get; set; }

    public Client(string firstName, string lastName, string occupation, int phoneNumber, string email,
        string password) // Create client in C# to DataBase
    {
        FirstName = firstName;
        LastName = lastName;
        Occupation = occupation;
        PhoneNumber = phoneNumber;
        Email = email;
        Password = password;
        
    }
    
    public Client() // Load Client from DataBase Constructor
    {
      
    }
}
