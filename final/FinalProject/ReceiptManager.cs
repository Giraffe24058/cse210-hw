using System;
using System.Collections.Generic;

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
}
