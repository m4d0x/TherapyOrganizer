namespace UI;
using Logic;
using Spectre.Console;

public class UserUI
{
    //Admin Main Menu
    public static void UserMenu()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold white]- Welcome Therapist -[/]\n"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][cyan] Search Client[/]\n[red]|2|[/][cyan] Client Options[/]\n[red]|3|[/][cyan] Clinic Options[/]\n[red]|4|[/][cyan] Diagnose Options[/]\n[red]|Q|[/][cyan] Log Out[/]\n"));
            AnsiConsole.Write(new Markup("\n[white]Press any of the [/][underline red]red[/][white] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1) // SearchClient (kan ev köras lika som AdminUI)
            {
                //Run SearchClient => DB QUERY SELECT * FROM client WHERE client.id/name/email = id/name/email

            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2) // ClientOptions() - körs kan ev behöva läggas i logik för att nås av både user/admin
            {
                //Run menu for client creation, delete, update, get, set admin rules or not
                ClientOptions();
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3) // OpenClientCase() => DB QUERY = DET STORA ASET MED JOINS
            {
                //Run SearchClient//OpenClientCase => DB QUERY SELECT * FROM client WHERE client.id = id/name/email
            }
            else if (userInput == ConsoleKey.D4 || userInput == ConsoleKey.NumPad4) // DiagnoseOptions (UserOnly = No Delete, No Create - Search/List & ReadOnly)
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

    //Sub Menues
    public static void ClientOptions()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold red]- Client Administration-[/]"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Search Client[/]\n[red]|2|[/][green] Create Client[/]\n[red]|3|[/][green] Edit Client[/]\n[red]|4|[/][green] List All Clients[/]\n[red]|5|[/][green] List All Bookings[/]\n[red]|Q|[/][green] Go Back[/]\n"));
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
            else if (userInput == ConsoleKey.D4 || userInput == ConsoleKey.NumPad4) // List All Clients
            {
                //Run ListAllClients => DB QUERY SELECT * FROM client
                //Run ListAllBookings => DB QUERY SELECT * FROM booking /ev COUNT 
            }
            else if (userInput == ConsoleKey.D5 || userInput == ConsoleKey.NumPad5) // List All Bookings - either for this User or for the currentClient
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
    public static void DiagnoseOptions()
    {

        bool isActive = true;
        while (isActive)
        {

            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold red]- Dianose -[/]"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Search Diagnose[/]\n[red]|2|[/][green] List All Diagnoses[/]\n[red]|Q|[/][green] Go Back[/]\n"));
            AnsiConsole.Write(new Markup("\n[green]Press any of the [/][underline red]red[/][green] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1) // Search Diagnose
            {
                //Run SearchDiagnose => DB QUERY SELECT * FROM client WHERE client.id/name/email = id/name/email

            }
            else if (userInput == ConsoleKey.D5 || userInput == ConsoleKey.NumPad2) // List All Diagnose
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