public class ExportService
{
    public void ExportDocument(Document doc)
    {
        doc.Export(); // Polymorphic call
    }
}
