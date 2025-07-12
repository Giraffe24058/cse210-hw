using System;

class Program
{
    static void Main(string[] args)
    {
        var receiptManager = new ReceiptManager();
        var reminderService = new ReminderService();
        var exportService = new ExportService();
        var categoryManager = new CategoryManager();

        var receipt = new Receipt("Laptop Purchase", DateTime.Now, "Tech Store", 1299.99m);
        receiptManager.AddReceipt(receipt);
        reminderService.SetReminder(receipt, 30);
        exportService.ExportDocument(receipt);
        categoryManager.AssignCategory("Electronics", receipt);

        receiptManager.ListReceipts();
        categoryManager.ListCategories();
    }
}
