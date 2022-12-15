namespace UI;
using Spectre.Console;

public class MainUI
{

    public static void MainMenu()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold green] - Main Menu- [/]\n"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Client Login[/]\n[red]|2|[/][green] User Login[/]\n[red]|3|[/][green] About Us[/]\n[red]|Q|[/][green] Close Application[/]\n"));
            AnsiConsole.Write(new Markup("\n[white]Press any of the [/][underline red]red[/][white] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1)
            {
                ClientUI.ClientMenu();
            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2) // UserUI.UserLogin-Runs => ClientMenu or UserMenu;
            {
                UserUI.UserMenu();

                //AdminUI.AdminMenu();
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3)
            {
                AdminUI.AdminMenu(); // <---------admin så länge för layout och check
            }
            else if (userInput == ConsoleKey.Q || userInput == ConsoleKey.End || userInput == ConsoleKey.Escape)
            {
                isActive = false;
                Console.Clear();
                AnsiConsole.Write(new Markup("\n[bold underline red]Welcome back anytime![/]"));

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