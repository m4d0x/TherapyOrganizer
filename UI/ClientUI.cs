namespace UI;
using Spectre.Console;

public class ClientUI
{

    public void ClientMenu()
    {

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            AnsiConsole.Write(new Markup("\n[underline bold white]- Welcome Client -[/]\n"));
            AnsiConsole.Write(new Markup("\n[red]|1|[/][green] Book appointment[/]\n[red]|2|[/][green] Check Appointment[/]\n[red]|3|[/][green] Remove Appointment[/]\n[red]|Q|[/][green] Log Out[/]\n"));
            AnsiConsole.Write(new Markup("\n[white]Press any of the [/][underline red]red[/][white] keys to continue.[/]"));

            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.D1 || userInput == ConsoleKey.NumPad1)
            {
                //Book apppointment - future fix
            }
            else if (userInput == ConsoleKey.D2 || userInput == ConsoleKey.NumPad2)
            {
                //Check appointment - future fix
            }
            else if (userInput == ConsoleKey.D3 || userInput == ConsoleKey.NumPad3)
            {
                //Remove appointment - future fix
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