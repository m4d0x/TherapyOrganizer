using Spectre.Console;

namespace Logic;
public class AppLogic
{


    public static string CheckIfValid(string userInput)
    {
        bool containsNullOrBlank = String.IsNullOrWhiteSpace(userInput);
        bool validInput = true;

        while (validInput)
        {
            if (containsNullOrBlank)
            {
                AnsiConsole.Write(new Markup("\n[underlined bold red] Invalid input. Blank space not allowed - Try again.[/]"));
                Console.ReadKey();
                break;
            }
            else
            {
                return validInput ? "true" : "false";
            }
        }
        return null;
    }

    public static void EmailOutput()
    {
        AnsiConsole.Write(new Markup("[red]- Create Account -[/]"));
        AnsiConsole.Write(new Markup("\n[green] Enter email address: [/]"));
    }
    
    public static void PassWordOutput()
    {
          AnsiConsole.Write(new Markup("[red]- Create Account -[/]"));
        AnsiConsole.Write(new Markup("\n[green] Enter password: [/]"));
    }/*  */





}