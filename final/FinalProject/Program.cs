using System;
using System.Collections.Generic;

class Program
{
    static ReceiptManager receiptManager = new ReceiptManager();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Receipt Manager ===");
            Console.WriteLine("1. Add new receipt");
            Console.WriteLine("2. List receipts");
            Console.WriteLine("3. Save receipts to file");
            Console.WriteLine("4. Load receipts from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddReceipt();
                    break;
                case "2":
                    receiptManager.ListReceipts();
                    break;
                case "3":
                    Console.Write("Enter filename to save (e.g., receipts.json): ");
                    string saveFile = Console.ReadLine();
                    receiptManager.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load (e.g., receipts.json): ");
                    string loadFile = Console.ReadLine();
                    receiptManager.LoadFromFile(loadFile);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddReceipt()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Store name: ");
        string store = Console.ReadLine();

        Console.Write("Total amount: ");
        decimal total = decimal.Parse(Console.ReadLine());

        var receipt = new Receipt(title, date, store, total);
        receiptManager.AddReceipt(receipt);
        Console.WriteLine("Receipt added.");
    }
}
