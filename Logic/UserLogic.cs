using DataManager;
using Spectre.Console;
namespace Logic;

public class UserLogic
{
    /* 
        public static void UserLogin(User currentUser)
        {
            UserDB userDB = new();
            currentUser = userDB.ExtractSingleUserData();
        } */

    /*    public void LogInUser()
       {
           //user email check
           AnsiConsole.Write(new Markup("[red] Enter email address: "));
           string? emailInput = ApplicationLogic.CheckIfValid(Console.ReadLine().ToLower());
           //password check
           AnsiConsole.Write(new Markup("[red] Enter password: "));
           string? passwordInput = ApplicationLogic.CheckIfValid(Console.ReadLine().ToLower());
           User currentUser = UserLogic.UserLogin(emailInput, passwordInput);

           if (currentUser != null)
           {
               if (currentUser.isAdmin)
               {
                   AdminUI.AdminMenu();
               }
           }
           else if (currentUser.isAdmin)
           {
               if (!currentUser.isAdmin)
               {
                   UserUI.UserMenu();

               }
           }
           else if (currentUser == null)
           {
               AnsiConsole.Write(new Markup("\n[underline bold red] Invalid user email or password: Try again![/]"));
           }

       }
    */
    public static void CreateUser() // Admin Access Only // denna måste skrivas om då writelines inte ska finnas här/* aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa */
    {
        string? emailInput = string.Empty;
        string? passwordInput = string.Empty;
        var currentUser = new UserDB();
        AppLogic.EmailOutput();
        AppLogic.CheckIfValid(emailInput = Console.ReadLine().ToLower());
        AppLogic.PassWordOutput();
        AppLogic.CheckIfValid(passwordInput = Console.ReadLine().ToLower());
        return currentUser = UserDB.UserInsertExecution(emailInput, passwordInput);

    }

    public static void FindUser()
    {
        Console.Clear();
        UserDB userQuery = new();
        foreach (var item in userQuery.ExtractSingleUserData())
        {
            AnsiConsole.Write(new Markup("\n[underline bold red] Name:[/]\n[underline bold red] {item.FirstName}[/]\n"));
        }
    }
}
