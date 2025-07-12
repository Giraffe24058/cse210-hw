public class ReminderService
{
    public void SetReminder(Receipt receipt, int daysUntilReturn)
    {
        var returnDate = receipt.Date.AddDays(daysUntilReturn);
        Console.WriteLine($"Reminder set for {receipt.Title} on {returnDate.ToShortDateString()}");
    }
}
