namespace Logic;
using Spectre.Console;

public class ClientLogic
{

    public void LogInClient()
    {

        bool isActive = true;

        while (true)
        {
            Console.Clear();
            //user email check
            AnsiConsole.Write(new Markup("[red] Enter email address: "));
            string? emailInput = CheckIfValid(Console.ReadLine().ToLower());
            //password check
            AnsiConsole.Write(new Markup("[red] Enter password: "));
            string? passwordInput = CheckIfValid(Console.ReadLine().ToLower());
            User currentClient = newClientHandler.UserLogin(emailInput, passwordInput);

            if (currentClient != null)
            {
                if (currentClient.Email == emailInput && currentClient.PassWord == passwordInput) // ??
                {
                    ClientUI.ClientMenu();
                }
            }
            else if (currentClient == null)
            {
                AnsiConsole.Write(new Markup("\n[underline bold red] Invalid user email or password: Try again![/]"));
                Console.ReadKey();
            }
        }

    }
}