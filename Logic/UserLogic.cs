﻿using DataManager;
using Spectre.Console;
namespace Logic;

public class UserLogic
{

    public static void UserLogin(User user)
    {
        UserDB.FindUser();
    }

    public void LogInUser()
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

    public static void CreateUser(string email, string password) // Admin Access Only
    {

        var currentUser = new();
        AnsiConsole.WriteLine(new Markup("[red]- Create Account -[/]"));
        AnsiConsole.Write(new Markup("\n[green] Enter email address: [/]"));
        string? emailInput = ApplicationLogic.CheckIfValid(Console.ReadLine().ToLower());
        //password check
        AnsiConsole.WriteLine(new Markup("[red]- Create Account -[/]"));
        AnsiConsole.Write(new Markup("\n[green] Enter password: [/]"));
        string? passwordInput = ApplicationLogic.CheckIfValid(Console.ReadLine().ToLower());
        currentUser = UserDB.CreateUser(emailInput, passwordInput);
    }



}
