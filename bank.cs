using System;
using System.Collections.Generic;

class Account
{
    public int Number { get; set; }
    public string Name { get; set; }
    public float Balance { get; set; }

    public void GetAccountInfo()
    {
        Console.Write("Enter the account number: ");
        Number = int.Parse(Console.ReadLine());

        Console.Write("Enter the name for the account: ");
        Name = Console.ReadLine();

        Console.Write("Enter the balance: ");
        Balance = float.Parse(Console.ReadLine());
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account number: {Number}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Balance: {Balance:F2}");
    }
}

class Program
{
    static List<Account> accounts = new List<Account>();

    static void AddAccount()
    {
        Account newAcc = new Account();
        newAcc.GetAccountInfo();
        accounts.Add(newAcc);
    }

    static void DisplayAllAccounts()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("No accounts to display.");
            return;
        }

        foreach (var acc in accounts)
        {
            acc.DisplayAccountInfo();
            Console.WriteLine();
        }
    }

    static Account FindAccount(int number)
    {
        return accounts.Find(acc => acc.Number == number);
    }

    static void UpdateAccount()
    {
        Console.Write("Enter the account number to find: ");
        int number = int.Parse(Console.ReadLine());

        Account acc = FindAccount(number);
        if (acc == null)
        {
            Console.WriteLine("Account not found.");
        }
        else
        {
            Console.WriteLine("Found the account:");
            acc.DisplayAccountInfo();
            Console.WriteLine("Now enter the new account information:");
            acc.GetAccountInfo();
        }
    }

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\nMain menu:");
            Console.WriteLine("  1. Add account");
            Console.WriteLine("  2. Display all accounts");
            Console.WriteLine("  3. Find account");
            Console.WriteLine("  4. Change account");
            Console.WriteLine("  0. Quit program");
            Console.Write("Your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddAccount();
                    break;
                case 2:
                    DisplayAllAccounts();
                    break;
                case 3:
                    Console.Write("Enter the account number to find: ");
                    int number = int.Parse(Console.ReadLine());
                    Account acc = FindAccount(number);
                    if (acc != null)
                    {
                        Console.WriteLine("Found account:");
                        acc.DisplayAccountInfo();
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                    break;
                case 4:
                    UpdateAccount();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 0);
    }
}
