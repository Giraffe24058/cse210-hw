public abstract class Document
{
    public string Title { get; set; }
    public DateTime Date { get; set; }

    protected Document(string title, DateTime date)
    {
        Title = title;
        Date = date;
    }

    public abstract void Export();
}
