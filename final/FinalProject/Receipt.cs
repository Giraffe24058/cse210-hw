using System;

public class Receipt : Document
{
    private string _storeName;
    private decimal _totalAmount;

    public Receipt(string title, DateTime date, string store, decimal total)
        : base(title, date)
    {
        _storeName = store;
        _totalAmount = total;
    }

    public string GetStoreName() => _storeName;
    public decimal GetTotalAmount() => _totalAmount;

    public override void Export()
    {
        Console.WriteLine($"Exporting receipt: {Title}, Store: {_storeName}, Total: {_totalAmount}");
    }
}
