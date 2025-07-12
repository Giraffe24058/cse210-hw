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

    public object ToSerializable()
    {
        return new
        {
            Title = this.Title,
            Date = this.Date.ToString("yyyy-MM-dd"),
            Store = this.GetStoreName(),
            Total = this.GetTotalAmount()
        };
    }

    public static Receipt FromSerializable(string title, string dateStr, string store, decimal total)
    {
        DateTime date = DateTime.Parse(dateStr);
        return new Receipt(title, date, store, total);
    }
}
