using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ReceiptManager
{
    private List<Receipt> _receipts = new List<Receipt>();

    public void AddReceipt(Receipt receipt)
    {
        _receipts.Add(receipt);
    }

    public void ListReceipts()
    {
        foreach (var receipt in _receipts)
        {
            Console.WriteLine($"{receipt.Title} - {receipt.GetStoreName()} - {receipt.GetTotalAmount()}");
        }
    }

    public List<Receipt> GetAllReceipts() => _receipts;

    public void SaveToFile(string filename)
    {
        var exportList = new List<object>();
        foreach (var r in _receipts)
        {
            exportList.Add(r.ToSerializable());
        }

        File.WriteAllText(filename, JsonSerializer.Serialize(exportList, new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine($"Receipts saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string json = File.ReadAllText(filename);
        var data = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json);

        foreach (var item in data)
        {
            string title = item["Title"].ToString();
            string dateStr = item["Date"].ToString();
            string store = item["Store"].ToString();
            decimal total = Convert.ToDecimal(item["Total"]);

            var receipt = Receipt.FromSerializable(title, dateStr, store, total);
            _receipts.Add(receipt);
        }

        Console.WriteLine("Receipts loaded from file.");
    }
}
