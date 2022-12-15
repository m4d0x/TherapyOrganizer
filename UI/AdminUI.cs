namespace UI;
using Logic;
using Spectre.Console;

public class AdminUI
{
    //Admin Main Menu
    public static void AdminMenu()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold white]- Welcome Admin -[/]\n"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][red] User Options[/]\n[red]|2|[/][red] Client Options[/]\n[red]|3|[/][red] Clinic Options[/]\n[red]|4|[/][red] Diagnose Options[/]\n[red]|Q|[/][red] Log Out[/]\n"));
            AnsiConsole.Write(new Markup("\n[white]Press any of the [/][underline red]red[/][white] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1)
            {
                //Run menu for user creation, delete, update, get, set admin rules or not
                UserOptions();
            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2)
            {
                //Run menu for client creation, delete, update, get, set admin rules or not
                ClientOptions();
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3)
            {
                //Run menu for clinic creation, delete, update
                ClientOptions();
            }
            else if (userInput == ConsoleKey.D4 || userInput == ConsoleKey.NumPad4)
            {
                //Run menu for diagnose creation, delete, update
                DiagnoseOptions();
            }
            else if (userInput == ConsoleKey.Q || userInput == ConsoleKey.End || userInput == ConsoleKey.Escape)
            {
                isActive = false;
            }
            else
            {
                AnsiConsole.Write(new Markup("\n[bold underline red]Invalid keypress, try again![/]"));
                Console.ReadKey();
                isActive = true;
            }
        }
    }
    
    //Admin Sub Menues
    public static void UserOptions()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold red]- User Administration -[/]"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Search User[/]\n[red]|2|[/][green] Create User[/]\n[red]|3|[/][green] Edit User[/]\n[red]|4|[/][green] Delete User[/]\n[red]|5|[/][green] Set User Accessability[/]\n[red]|6|[/][green] List All Users[/]\n[red]|Q|[/][green] Go Back[/]\n"));
            AnsiConsole.Write(new Markup("\n[green]Press any of the [/][underline red]red[/][green] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1) // Search User
            {
                //Run UserSearch = DB QUERY SELECT * FROM user WHERE user contains id/name/mail 
            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2) // Create User
            {
                //Run CreateUser = DB EXECUTE INSERT INTO user (email, password)??
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3) // Edit User
            {
                //Run UserUpdate = DB EXECUTE UPDATE user columns with data
            }
            else if (userInput == ConsoleKey.D4 || userInput == ConsoleKey.NumPad4) // Delete User
            {
                //Run DeleteUser = DB EXECUTE DELETE FROM user WHERE user is id/name/mail/phonenumber
            }
            else if (userInput == ConsoleKey.D5 || userInput == ConsoleKey.NumPad5) // Set User Accessability
            {
                //Run SetUserAccessability = DB QUERY(get the user)(CheckWithC if user isAdmin)(option to set accessability from false to true) //only for admins
            }
            else if (userInput == ConsoleKey.D6 || userInput == ConsoleKey.NumPad6) // List All Users
            {
                //Run ListUsers = DB QUERY SELECT * FROM users
            }
            else if (userInput == ConsoleKey.Q || userInput == ConsoleKey.End || userInput == ConsoleKey.Escape)
            {
                isActive = false;
            }
            else
            {
                AnsiConsole.Write(new Markup("\n[bold underline red]Invalid keypress, try again![/]"));
                Console.ReadKey();
                isActive = true;
            }
        }
    }
    public static void ClientOptions()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold red]- Client Administration-[/]"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Search Client[/]\n[red]|2|[/][green] Create Client[/]\n[red]|3|[/][green] Edit Client[/]\n[red]|4|[/][green] Delete Client[/]\n[red]|5|[/][green] List All Clients[/]\n[red]|6|[/][green] List All Bookings[/]\n[red]|Q|[/][green] Go Back[/]\n"));
            AnsiConsole.Write(new Markup("\n[green]Press any of the [/][underline red]red[/][green] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1) // Search Client
            {
                //Run SearchClient => DB QUERY SELECT * FROM client WHERE client.id/name/email = id/name/email
            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2) // Create Client
            {
                //Run ClientCreation => DB INSERT INTO
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3) // Edit Client
            {
                //Run ClientEdit => DB, QUERY/EXECUTE SELECT client where id/name/else => run edit the value where the columnname bla bla
            }
            else if (userInput == ConsoleKey.D4 || userInput == ConsoleKey.NumPad4) // Delete Client
            {
                //Run DeleteClient => DB EXECUTE where client id/name/mail/phoneNumbert or else is accurate
            }
            else if (userInput == ConsoleKey.D5 || userInput == ConsoleKey.NumPad5) // List All Clients
            {
                //Run ListAllClients => DB QUERY SELECT * FROM client
                //Run ListAllBookings => DB QUERY SELECT * FROM booking /ev COUNT 
            }
            else if (userInput == ConsoleKey.D6 || userInput == ConsoleKey.NumPad6) // List All Bookings
            {
                //Run ListAllBookings => DB QUERY SELECT * FROM booking = certain client or certain booking for a certain client?
                //Run ListAllBookings => DB QUERY SELECT * FROM booking /ev COUNT = all bookings or all for a certain client?
            }
            else if (userInput == ConsoleKey.Q || userInput == ConsoleKey.End || userInput == ConsoleKey.Escape)
            {
                isActive = false;
            }
            else
            {
                AnsiConsole.Write(new Markup("\n[bold underline red]Invalid keypress, try again![/]"));
                Console.ReadKey();
                isActive = true;
            }
        }
    }
    public static void ClinicOptions()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold red]- Clinic -[/]"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Create Clinic[/]\n[red]|2|[/][green] Create Clinic[/]\n[red]|3|[/][green] Edit Clinic[/]\n[red]|4|[/][green] Delete Clinic[/]\n[red]|5|[/][green] List Clinics[/]\n[red]|Q|[/][green] Go Back[/]\n"));
            AnsiConsole.Write(new Markup("\n[green]Press any of the [/][underline red]red[/][green] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1) // Search Clinic
            {
                //Run SearchClient => DB QUERY SELECT * FROM client WHERE client.id/name/email = id/name/email
            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2) // Create Clinic
            {
                //Run ClientCreation => DB INSERT INTO
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3) // Edit Clinic
            {
                //Run ClientEdit => DB, QUERY/EXECUTE SELECT client where id/name/else => run edit the value where the columnname bla bla
            }
            else if (userInput == ConsoleKey.D4 || userInput == ConsoleKey.NumPad4) // Delete Clinic
            {
                //Run DeleteClient => DB EXECUTE where client id/name/mail/phoneNumbert or else is accurate
            }
            else if (userInput == ConsoleKey.Q || userInput == ConsoleKey.End || userInput == ConsoleKey.Escape)
            {
                isActive = false;
            }
            else
            {
                AnsiConsole.Write(new Markup("\n[bold underline red]Invalid keypress, try again![/]"));
                Console.ReadKey();
                isActive = true;
            }
        }
    }
    public static void DiagnoseOptions()
    {

        bool isActive = true;
        while (isActive)
        {

            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold red]- Dianose -[/]"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Search Diagnose[/]\n[red]|2|[/][green] Create Diagnose[/]\n[red]|3|[/][green] Edit Diagnose[/]\n[red]|4|[/][green] Delete Diagnose[/]\n[red]|5|[/][green] List All Diagnoses[/]\n[red]|Q|[/][green] Go Back[/]\n"));
            AnsiConsole.Write(new Markup("\n[green]Press any of the [/][underline red]red[/][green] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1) // Search Diagnose
            {
                //Run SearchDiagnose => DB QUERY SELECT * FROM client WHERE client.id/name/email = id/name/email
                
            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2) // Create Diagnose
            {
                //Run DiagnoseCreation => DB INSERT INTO
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3) // Edit Diagnose
            {
                //Run DiagnoseEdit => DB, QUERY/EXECUTE SELECT client where id/name/else => run edit the value where the columnname bla bla
            }
            else if (userInput == ConsoleKey.D4 || userInput == ConsoleKey.NumPad4) // Delete Diagnose
            {
                //Run DeleteDiagnose => DB EXECUTE where client id/name/mail/phoneNumbert or else is accurate
            }
            else if (userInput == ConsoleKey.D5 || userInput == ConsoleKey.NumPad5) // List All Diagnose
            {
                //Run ListDiagnose => DB QUERY SELECT * FROM diagnose where "hm" is "hm"
                //Run ListDiagnose => DB QUERY SELECT * FROM diagnose = certain diagnose or certain diagnose for a certain diagnose?
                //Run ListAllBookings => DB QUERY SELECT * FROM diagnose /ev COUNT = all diagnose or all for a certain diagnose?
            }
            else if (userInput == ConsoleKey.Q || userInput == ConsoleKey.End || userInput == ConsoleKey.Escape) 
            {
                isActive = false;
            }
            else
            {
                AnsiConsole.Write(new Markup("\n[bold underline red]Invalid keypress, try again![/]"));
                Console.ReadKey();
                isActive = true;
            }
        }
    }
}