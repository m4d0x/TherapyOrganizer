namespace Logic;
using Spectre.Console;

public class ApplicationLogic
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

}